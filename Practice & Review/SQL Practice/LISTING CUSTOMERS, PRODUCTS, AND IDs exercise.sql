SELECT *
FROM Customers c

SELECT *
FROM Favorite f

SELECT *
FROM Product p

--list all favorite products for a given CustomerId--
SELECT c.CustomerId, FirstName, LastName, ProductName
FROM Customers c
JOIN Favorite f ON c.CustomerId = f.ProductId
JOIN Product p ON  p.ProductId = f.ProductId
WHERE c.CustomerId=3

--list all customers that have favorited a given ProductId--

SELECT c.CustomerId, c.FirstName
FROM Favorite f
JOIN Customers c ON f.CustomerId = c.CustomerId
WHERE f.ProductId=3

--list all customers that have favorite at least one product--
SELECT c.FirstName, c.LastName
FROM Customers c
JOIN Favorite f ON c.CustomerId = f.CustomerId

--list all customers that have no favorites--
SELECT c.FirstName, c.LastName
FROM Customers c
LEFT JOIN Favorite f ON c.CustomerId = f.CustomerId
WHERE f.favoriteId IS NULL

--list all products that have no favorites--
SELECT p.ProductId, p.ProductName
FROM Product p
LEFT JOIN Favorite f ON p.ProductId = f.ProductId
WHERE f.FavoriteID IS NULL
