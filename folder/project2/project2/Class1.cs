using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Class1
    {
        private List<Department> departments;
        int n = int.Parse(Console.ReadLine());
        public void MyMethod()

        {
            departments = new List<Department>();
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"enter department {i} details");
                Department department1 = new Department
                {
                    departmentId = int.Parse(Console.ReadLine()),
                    departmentName = Console.ReadLine(),

                };
                departments.Add(department1);
            }
            Console.WriteLine("paralle for loop");
            Parallel.For(0, departments.Count, (indexCount) =>
            {
                var dep = departments[indexCount];
                Console.WriteLine($" departmentid: {dep.departmentId} department name: {dep.departmentName}");

            });
            Console.WriteLine("paraller for each");
            Parallel.ForEach(departments ,dd=>{
                Console.WriteLine($" departmentid: {dd.departmentId} department name: {dd.departmentName}");
            });

        }
    }
}
