/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [empid]
      ,[name]
      ,[salary]
      ,[location]
      ,[Autiod]
      ,[dateofjoining]
  FROM [rgurram].[dbo].[employee_11dec]
  