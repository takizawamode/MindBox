/*
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON c.CategoryID = pc.CategoryID
ORDER BY p.ProductName;
*/

