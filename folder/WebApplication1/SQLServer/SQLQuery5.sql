alter procedure usp_CreateEmployeesDetails
	@EmpID as int,
	@EmpName as nvarchar(50),
	@salary as money
as
begin
	insert into EmployeesDetails(EmpID,EmpName,salary) values (@EmpID,@EmpName,@salary)
	--delete  EmployeesDetails  where  EmpID=101 
	delete  EmployeesDetails  where  EmpID=101

	UPDATE EmployeesDetails SET EmpName=@EmpName,salary=@salary WHERE EmpID=@EmpID
end

--execute usp_CreateEmployeesDetails  101 , 'karthik',10000  
execute usp_CreateEmployeesDetails  102 , 'Ravi',25000
execute usp_CreateEmployeesDetails  102 , 'ganesh',25000
--execute usp_CreateEmployeesDetails  103 , 'divya',12000
--execute usp_CreateEmployeesDetails  101 , 'pratheep',12000





select * from EmployeesDetails