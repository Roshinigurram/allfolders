/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product_Name]
      ,[productID]
      ,[Id]
  FROM [rgurram].[dbo].[Product]
  SELECT *
FROM ((product
left JOIN Customer ON product.id = customer.CustomerID)
left JOIN Cust_order ON Cust_order.productid = product.ProductID);

SELECT *FROM Product
SELECT * FROM Customer
SELECT * FROM CUST_ORDER
INSERT INTO CUSTOMER
VALUES (124,'ROSHINI',452452526)
INSERT INTO CUSTOMER
VALUES (128,'SREE',452365366)

