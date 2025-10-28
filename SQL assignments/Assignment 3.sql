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
WITH popular_products AS (
SELECT TOP 5 p.ProductName, AVG(od.UnitPrice) AS [AveragePrice], SUM(od.Quantity)  AS [TotalSold]
FROM [Order Details] od JOIN Orders o     ON o.OrderID = od.OrderID
    JOIN Customers c  ON c.CustomerID = o.CustomerID
    JOIN Products p   ON p.ProductID = od.ProductID
GROUP BY p.ProductName
ORDER BY SUM(od.Quantity) DESC
)
SELECT DISTINCT pp.ProductName, shipCity , COUNT(*)
FROM [Order Details] od JOIN Orders o ON od.OrderID = o.OrderID
    JOIN products p ON od.ProductID = p.ProductID
    JOIN popular_products pp ON p.ProductName = pp.productName

    GROUP BY  pp.ProductName, shipCity 
    



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

SELECT TOP 1(SELECT TOP 1 e.city
FROM orders o JOIN employees e ON o.EmployeeID = e.EmployeeID
GROUP BY e.City
ORDER BY COUNT(e.EmployeeID)) AS [sold most orders],
(SELECT TOP 1 c.City
FROM [Order Details] od JOIN orders o ON od.OrderID = o.OrderID
    JOIN Customers c ON o.CustomerID = c.customerID 
GROUP BY c.City
ORDER BY SUM(od.Quantity) DESC, c.City) AS [city of most total quantity]
FROM Orders


SELECT *
FROM Orders o JOIN Employees e ON o.EmployeeID = e.EmployeeID

--11. How do you remove the duplicates record of a table?
-- * You can remove the duplicate record by using a DISTINCT keyword in your SELECT statements.
