using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADO.NET
{
    public class Class4
    {
        private string connectionString;
        private DataSet objDS;
        private SqlDataAdapter dataAdapter;
        public Class4()

        {
            connectionString = "Data Source = 192.168.50.95; Initial Catalog = rgurram; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
            objDS = new DataSet();
        }

        public void Execute()
        {
            dataAdapter = new SqlDataAdapter("SELECT empid,name,salary,location from employee_11dec", connectionString);
            dataAdapter.Fill(objDS, "employee_11dec");
            foreach (DataRow row in objDS.Tables["employee_11dec"].Rows)
            {
                Console.WriteLine(row["empid"] + "|"+ row["name"] + "|" + row["salary"] + "|"+row["location"]);
            }
            dataAdapter = new SqlDataAdapter("select studentid,studentName,grade from student_11dec", connectionString);
            dataAdapter.Fill(objDS, "student_11dec");
            foreach (DataRow row1 in objDS.Tables["student_11dec"].Rows)
            {
                Console.WriteLine(row1["studentid"] + " | " + row1["studentName"] + " | " + row1["grade"]);
            }
        }
    }
}
