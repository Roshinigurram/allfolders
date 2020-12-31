/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [orderid]
      ,[orderplaced]
  FROM [rgurram].[dbo].[orders_11dec]


  select *from  product_11dec   left join orders_11dec on  product_11dec.id=orders_11dec.orderid;
  select  *from  product_11dec   inner join orders_11dec  on product_11dec.id=orders_11dec.orderid;
  select EmpID,sum(salary) from employee_11dec
  group by EmpID
  SELECT MAX(salary) from employee_11dec
  SELECT Min(salary) from employee_11dec
  
