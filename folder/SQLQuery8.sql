/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [customerID]
      ,[OrderID]
      ,[Item]
  FROM [rgurram].[dbo].[OrderNew]

SELECT OrderNew.OrderID, OrderNew.customerID, OrderNew.item, Customer.Customer_Name,Customer.CustomerID,Customer.phoneNo,Product.item,
product.ProductID,product.productName
FROM ((OrderNew
left JOIN Customer ON OrderNew.CustomerID = Customer.CustomerID)
 left JOIN product ON OrderNew.item = product.item);
select* from Product
select * from customer 
select * from ordernew

insert into ordenew 
values (127,423643256,'spoon')
