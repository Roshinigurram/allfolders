/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [customerid]
      ,[orderid]
      ,[orderitem]
  FROM [rgurram].[dbo].[orderdetails]
  SELECT orderdetails.