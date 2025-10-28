-- 1. 
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice FROM Production.Product pp
-- 2. 
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice FROM Production.Product pp WHERE pp.ListPrice != 0
-- 3. 
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice FROM Production.Product pp WHERE pp.Color IS NULL
-- 4. 
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice FROM Production.Product pp WHERE pp.Color IS NOT NULL
-- 5. 
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice FROM Production.Product pp WHERE pp.Color IS NOT NULL AND pp.ListPrice > 0
-- 6.
SELECT pp.Name + ' ' + pp.Color AS [Name and Color] FROM Production.Product pp WHERE pp.Color IS NOT NULL
-- 7. 
SELECT 'NAME: ' +pp.Name +' -- COLOR: ' + pp.Color FROM Production.Product pp WHERE pp.Name LIKE '%Crankarm%' OR pp.Name LIKE '%Chainring%' ORDER BY     CASE         WHEN pp.Name LIKE 'LL%' THEN 1         WHEN pp.Name LIKE 'ML%' THEN 2         WHEN pp.Name LIKE 'HL%' THEN 3         WHEN pp.Name LIKE '%Bolts' THEN 4         WHEN pp.Name LIKE '%Nut' THEN 5         WHEN pp.Name LIKE 'Chainring' THEN 6     END    
-- 8. 
SELECT pp.ProductID, pp.Name FROM Production.Product pp WHERE pp.ProductID BETWEEN 400 AND 500
-- 9. 
SELECT pp.ProductID, pp.Name, pp.Color FROM Production.Product pp WHERE pp.Color IN ('black', 'blue')
-- 10. 
SELECT * FROM Production.Product pp WHERE pp.Name LIKE 'S%'
-- 11. 
SELECT pp.Name, pp.ListPrice FROM Production.Product pp WHERE pp.Name LIKE 'SEAT%'     OR pp.Name LIKE 'Short-Sleeve Classic Jersey%' ORDER BY pp.Name
-- 12. 
SELECT pp.Name, pp.ListPrice FROM Production.Product pp WHERE pp.Name LIKE 'A%' OR pp.Name LIKE 'S%' ORDER BY pp.Name
-- 13.
SELECT * FROM Production.Product pp WHERE pp.Name LIKE 'SPO[^K]%' ORDER BY pp.Name
-- 14.
SELECT DISTINCT pp.Color FROM Production.Product pp ORDER BY pp.Color DESC

