using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ADO.NET
{
    class Class2
    {
        private string connectionString;
        private SqlConnection objConn;
        public Class2()
        {
            connectionString= "Data Source = 192.168.50.95; Initial Catalog = rgurram; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
            objConn = new SqlConnection(connectionString);
        }
        public void ReadEmpById(int employeeId)
        {
            objConn.Open();
            SqlCommand sqlCommand = new SqlCommand("select empid,name,salary,location from employee_11dec where empid=@empid",objConn);
            sqlCommand.Parameters.AddWithValue( "@empid",employeeId);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if(sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader["empid"] + "\t" + sqlDataReader["name"] + "\t" + sqlDataReader["salary"] + "\t" + sqlDataReader["location"]);
            
            }
            objConn.Close();

        }
    }
}
