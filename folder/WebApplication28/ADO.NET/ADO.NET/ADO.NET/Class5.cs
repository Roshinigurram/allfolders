using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace ADO.NET
{
    class Class5
    {
        static  object _connStr;

         public  void LinqExtensionMethods()
        {
            Console.WriteLine("linq examples");

           
            _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            
            var employee1 = GetEmployee();
            // var data=employee1.Where(d => d.name.Equals("geethika"));
            // var data = employee1.Where(d => d.name.StartsWith("s") && d.name.EndsWith("a"));
            var data = employee1.Where(d => d.salary > 20000).OrderByDescending(d=>d.salary);
           // var data2 = employee1.Where(d => d.name.Contains("a"));
            //var data = data1.Concat(data2);
           var data1 = data.ElementAt(2 );
            Console.WriteLine(data1.Autiod+" "+data1.name+" "+data1.location+" "+data1.salary);




            //foreach (var item in data1)
            //{
            //    Console.WriteLine(item.Autiod + " " + item.name + " " + item.location + " " + item.salary);
            //}
        }
        private static IList<Employee> GetEmployee()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection((string)_connStr))
            {
                var sql = "select *from employee_11dec";
                using(SqlCommand sqlCommand=new SqlCommand(sql,sqlConnection))
                {
                    using (SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(dataTable);
                    }
                }

            }
            IList<Employee> employees = new List<Employee>();
            foreach(DataRow row in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    Autiod = int.Parse(row["Autiod"].ToString()),
                    empid = row["empid"].ToString(),
                    name = row["name"].ToString(),
                    salary = decimal.Parse(row["salary"].ToString()),
                    location = row["location"].ToString()


                };
                employees.Add(employee);
            }

            return employees;
        }
    }
}
