-- 1.      How many products can you find in the Production.Product table?
SELECT COUNT(*) AS products
FROM Production.Product

-- 2.      Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(*) AS [number of products]
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

-- 3.      How many Products reside in each SubCategory? Write a query to display the results with the following titles.
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
GROUP BY ProductSubcategoryID

--4.      How many products that do not have a product subcategory.
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
GROUP BY ProductSubcategoryID
HAVING ProductSubcategoryID IS NULL

--5.      Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT ProductID, SUM(Quantity) AS [sum of products]
FROM Production.ProductInventory
GROUP BY ProductID

--6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 AND quantity < 100
GROUP BY ProductID

--7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
SELECT Shelf, productID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 AND quantity < 100
GROUP BY productID, Shelf

--8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT productID, AVG(quantity) AS TheAVG
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

--9. Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
SELECT ProductID, shelf, AVG(quantity) AS TheAVG
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

--10. Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
SELECT p.productID, p.shelf, AVG(p.Quantity) AS TheAVG
FROM (SELECT *
FROM Production.ProductInventory
WHERE shelf != 'N/A') p
GROUP BY p.productID, p.shelf

--11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
SELECT pp.Color, pp.Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.product pp
GROUP BY pp.Color, pp.Class

--12 Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
SELECT pc.Name AS Country, ps.Name AS Province
FROM person.CountryRegion pc JOIN person.StateProvince ps ON pc.CountryRegionCode = ps.CountryRegionCode

--13  Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
SELECT pc.Name AS Country, ps.Name AS Province
FROM person.CountryRegion pc JOIN person.StateProvince ps ON pc.CountryRegionCode = ps.CountryRegionCode
WHERE pc.Name IN('Germany', 'Canada')

--14 List all Products that has been sold at least once in last 27 years.
SELECT DISTINCT productName
FROM products JOIN [Order Details] ON products.ProductID = [Order Details].ProductID
    JOIN orders ON orders.OrderID = [Order Details].OrderID
WHERE OrderDate > DATEADD(YEAR, -27, GETDATE())

--15 List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 SUM(od.quantity) AS [products sold], o.ShipPostalCode
FROM products p JOIN [Order Details] od ON p.ProductID = od.ProductID
    JOIN orders o ON o.OrderID = od.OrderID
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.quantity) DESC

--16 List top 5 locations (Zip Code) where the products sold most in last 27 years.
SELECT TOP 5 SUM(od.quantity) AS [products sold], o.ShipPostalCode
FROM products p JOIN [Order Details] od ON p.ProductID = od.ProductID
    JOIN orders o ON o.OrderID = od.OrderID
WHERE OrderDate > DATEADD(YEAR, -27, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.quantity) DESC

-- 17 List all city names and number of customers in that city.     
SELECT DISTINCT ShipCity , CustomerID
FROM orders o 
WHERE o.ShipPostalCode IN
(SELECT TOP 5 o.ShipPostalCode
FROM [Order Details] od JOIN orders o ON o.OrderID = od.OrderID
GROUP BY o.ShipPostalCode
ORDER BY SUM(od.quantity) DESC) 

--18  List city names which have more than 2 customers, and number of customers in that city
SELECT shipCity, COUNT(c.customerID)
FROM orders o JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY ShipCity
HAVING COUNT(c.customerID) >= 2


--19 List the names of customers who placed orders after 1/1/98 with order date.
SELECT DISTINCT ContactName
FROM Orders o JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE orderDate >= '1998-1-1'

--20 List the names of all customers with most recent order dates
SELECT ContactName, MAX(OrderDate) 
FROM Orders o JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY ContactName

--21  Display the names of all customers  along with the  count of products they bought
SELECT c.CustomerID, c.ContactName, COUNT(od.Quantity) AS [count of products]
FROM orders o JOIN [Order Details] od ON o.orderID = od.OrderID
    JOIN customers c on o.CustomerID = c.CustomerID
GROUP BY  c.CustomerID, c.ContactName

--22  Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID,  COUNT(od.Quantity) AS [count of products]
FROM orders o JOIN [Order Details] od ON o.orderID = od.OrderID
    JOIN customers c on o.CustomerID = c.CustomerID
GROUP BY  c.CustomerID
HAVING COUNT(od.Quantity) >= 100

-- 23.  List all of the possible ways that suppliers can ship their products. Display the results as below
SELECT ShipVia, su.CompanyName, s.companyName
FROM orders o JOIN Shippers s ON o.ShipVia = s.ShipperID
JOIN suppliers su ON o.ShipRegion = su.Region

--24 Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate, p.ProductName
FROM products p JOIN [Order Details] od ON p.ProductID = od.ProductID
    JOIN orders o ON od.OrderID = o.OrderID
ORDER BY OrderDate

--25 Displays pairs of employees who have the same job title.
SELECT e1.FirstName + ' ' + e1.LastName AS FullName, e2.FirstName + ' ' + e2.LastName AS Fullname
FROM Employees e1 JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID < e2.EmployeeID

--26.  Display all the Managers who have more than 2 employees reporting to them.
SELECT e2.firstName,COUNT(e1.ReportsTo) AS [num of employees reporting]
FROM Employees e1 JOIN Employees e2 ON e1.ReportsTo = e2.EmployeeID
GROUP BY e2.FirstName
HAVING COUNT(e1.ReportsTo) >=2

--27 Display the customers and suppliers by city. The results should have the following columns
SELECT City, CompanyName AS [Name], ContactName,'Customer' AS [Type]
FROM Customers
UNION
SELECT City, CompanyName AS [Name], ContactName, 'Supplier' AS [Type]
FROM Suppliers
ORDER BY City