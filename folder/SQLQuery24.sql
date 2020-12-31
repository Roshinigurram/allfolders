/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [orderid]
      ,[orderitem]
  FROM [rgurram].[dbo].[Product]

  select * from customerdetails cust inner join orderdetails o on
cust.customerid = o.customerid inner join Product p on 
p.orderid = o.orderid;