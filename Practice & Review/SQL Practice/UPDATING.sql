SELECT *
FROM Customers c
WHERE c.FirstName LIKE 'A%' 
OR c.FirstName LIKE 'B%'

--the LIKE is choosing a pattern, so FirstName that start with A. 
--The % is a wildcard, means anything with the letter A.
--OR is equivalent to AND in this query

UPDATE c
SET EmailAddress = ''
FROM Customers c
WHERE c.FirstName LIKE 'A%' 
OR c.FirstName LIKE 'B%'
--the UPDATE will update ALL customers whos FirstName start with either A or B
-- the SET will set the email address for ALL customers whos FirstName start with either A or B