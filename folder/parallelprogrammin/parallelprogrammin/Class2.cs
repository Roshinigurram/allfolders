using System;
using System.Collections.Generic;
using System.Text;

namespace parallelprogrammin
{
    public class Class2
    {
        private List<employee> Employee;
        public void Add()
        {
            Employee = new List<employee>();
      
            for (var i = 1; i < 6; i++)
            {
                Console.WriteLine($"ENTER {i} EMPLOYEEE DETAILS");
                employee employe1 = new employee
                {
                    
                    DeptName = Console.ReadLine(),
                    EmpNo = int.Parse(Console.ReadLine()),
                    Ename = Console.ReadLine(),
                    salary = int.Parse(Console.ReadLine())
                };
                Employee.Add(employe1);
            }
        }





        public void showall()
        {
            Console.WriteLine("the details are");
            foreach (var emp in Employee)
            {
                Console.WriteLine($"DEPARTMENT NAME:{emp.DeptName} empname:{emp.Ename} empnumber:{emp.EmpNo} salaryis: {emp.salary}");
            }

        }

    }
}