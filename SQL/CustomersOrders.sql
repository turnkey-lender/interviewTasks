-- Customers and orders. 
-- A customer may have several orders, an order can belong to only 1 customer
CREATE TABLE Customers (
	Id int, -- PK
	Name varchar(MAX)	
)
CREATE TABLE Orders (
	Id int, -- PK
	Customer_Id int -- FK to Customers
)

-- TODO: create a select statement to get IDs of customers that have no orders
