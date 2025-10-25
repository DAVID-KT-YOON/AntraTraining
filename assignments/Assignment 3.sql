USE NorthWind
GO

-- 1. List all cities that have both Employees and Customers.
SELECT DISTINCT c.City
FROM Customers c
WHERE c.city IN (SELECT e.City 
FROM Employees e)

-- 2. List all cities that have Customers but no Employee.
-- a. USE subquery
SELECT e.city
FROM Employees e
WHERE e.city NOT IN(SELECT c.City 
FROM Customers c)
-- b. Do not use subquery
SELECT e.city 
FROM Employees e LEFT JOIN Customers c ON e.City = c.City
WHERE e.city IS NOT NULL AND c.city IS NULL

-- 3. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, COUNT(od.Quantity) AS [total order quantities]
FROM [Order Details] od JOIN (SELECT ProductID, ProductName
FROM Products) AS p ON od.ProductID = p.ProductID
GROUP BY p.ProductName

--4. List all Customer Cities and total products ordered by that city.
SELECT c.city, COUNT(Quantity) AS [total products]
FROM Orders o JOIN customers c ON o.ShipCity = c.City
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City

--5. List all Customer Cities that have at least two customers.
SELECT City, COUNT(*) AS [num of customers]
FROM Customers
GROUP BY City
HAVING COUNT(*) >= 2

--6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, COUNT(DISTINCT od.ProductID) AS [kinds of products]
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
    JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2

--7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT c.ContactName
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it. 

SELECT TOP 5 od.productID,p.ProductName,  SUM(Quantity) AS [most sales]
FROM [Order Details] od JOIN Products p ON od.ProductID = p.ProductID
    JOIN Orders o ON od.OrderID = o.OrderID
    JOIN customers c ON o.CustomerID = c.CustomerID
GROUP BY od.ProductID ,p.ProductName
ORDER BY [most sales] DESC

SELECT
FROM Customers c JOIN orders o ON c.CustomerID = o.CustomerID JOIN 

--9. List all cities that have never ordered something but we have employees there.
--a. use subquery
SELECT e.city
FROM Orders o RIGHT JOIN (SELECT DISTINCT City
FROM Employees) AS e ON o.ShipCity = e.City
WHERE o.ShipCity IS NULL

--b. dont use subquery
SELECT e.City
FROM Orders o Right JOIN Employees e ON o.ShipCity = e.City
WHERE o.ShipCity IS NULL

--10.  List one city, if exists, that is the city from where the employee sold most orders 
-- (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT e.EmployeeID, o.ShipCity, RANK() OVER(PARTITION BY e.EmployeeID ORDER BY COUNT(o.shipCity) )
FROM Orders o JOIN Employees e ON o.EmployeeID = e.EmployeeID
GROUP BY e.EmployeeID, o.ShipCity

--11. How do you remove the duplicates record of a table?
-- * You can remove the duplicate record by using a DISTINCT keyword in your SELECT statements.
