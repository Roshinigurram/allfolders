/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [customerid]
      ,[orderid]
      ,[orderitem]
  FROM [rgurram].[dbo].[orderdetails]
  UPDATE customerdetails set customerid=10
  WHERE customerid=21
  SELECT *
  FROM customerdetails
  LEFT JOIN orderdetails
  ON customerdetails.customerid=orderdetails.customerid

  select * from customerdetails;
  select * from orderdetails;

  INSERT INTO customerdetails (customerName, customerid, customermobileno)
VALUES ('roshini',11,123343535);

  INSERT INTO orderdetails (customerid,orderid,orderitem )
VALUES ('1',555,'lollipop');

  INSERT INTO customerdetails (customerName, customerid, customermobileno)
VALUES ('roshini',1,123343535);
INSERT INTO orderdetails (customerid,orderid,orderitem )
VALUES ('1',555,'lollipop');
--DELETE FROM orderdetails
--WHERE customerid in (5,6,7,8,9,10);
--DELETE FROM orderdetails
--WHERE customerid = 11;
--DELETE FROM customerdetails
--WHERE customerid = 11;
DELETE FROM orderdetails
WHERE customerid = 1;
DELETE FROM customerdetails
WHERE customerid = 1;
INSERT INTO 



