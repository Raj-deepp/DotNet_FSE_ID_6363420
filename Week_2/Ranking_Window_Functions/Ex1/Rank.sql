SELECT *
FROM (
    SELECT 
        ProductID, ProductName, Category, Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products
) AS RankedProducts
WHERE RankNum <= 3;

SELECT *
FROM (
    SELECT 
        ProductID, ProductName, Category, Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM Products
) AS RankedProducts
WHERE DenseRankNum <= 3;
