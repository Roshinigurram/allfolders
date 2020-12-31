using System;
using System.Collections.Generic;
using System.Text;

namespace newproject_11dec
{
    class classlist
    {
        public void mymain()
        {
            List<Employee> emp = new List<Employee>();
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Employee employee = new Employee
            {
                name = Console.ReadLine(),
                id=int.Parse(Console.ReadLine()),
                department=Console.ReadLine(),

            };
            emp.Add(employee);
            for(int i=0;i<n;i++)
            {
                var result = emp[i];
                Console.WriteLine($"empname:{result.name} empid:{result.id} department:{result.department}");
            }
            foreach( var j in emp)
            {
                
                Console.WriteLine($"empname:{j.name} empid:{j.id} department:{j.department}");
            }
        }
    }
}
