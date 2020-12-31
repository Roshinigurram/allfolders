using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Class6
    {
        
        private List<Employee> employee;

       
        int n = int.Parse(Console.ReadLine());
        public void add()
        {
            employee = new List<Employee>();
            Console.WriteLine("are you ready to enter the details");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"enter employee {i} details");
                Employee employee1 = new Employee
                {
                    EmpNo = int.Parse(Console.ReadLine()),
                    EmpName = Console.ReadLine(),
                   doj = Console.ReadLine(),


                };


                employee.Add(employee1);  
            }
            Parallel.For(0, employee.Count, (indexCount) =>
            {
                var emp = employee[indexCount];
                Console.WriteLine($"Emp id: {emp.EmpNo}\tEmp name: {emp.EmpName}\tDOJ: {emp.doj}");
            });

        }
        
    }
}
