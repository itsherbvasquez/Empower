SELECT f.ProductId,
COUNT (*) AS [QuantityOfCustomersThatFavorited]
FROM Favorite f
GROUP BY f.ProductID
HAVING COUNT(*) > 1