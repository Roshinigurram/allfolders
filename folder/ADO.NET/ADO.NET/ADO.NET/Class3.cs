using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ADO.NET
{
    class Class3
    {
        private string connectionString;
        private SqlConnection objConn;

        public Class3()
        {
            connectionString = "Data Source = 192.168.50.95; Initial Catalog = rgurram; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
            objConn = new SqlConnection(connectionString);
        }
        public string GetEmpNameById(int employeeId)
        {
            objConn.Open();
            SqlCommand sqlCommand = new SqlCommand("select name from employee_11dec where empid=@empid", objConn);
            sqlCommand.Parameters.AddWithValue("@empid", employeeId);
          
            var name = sqlCommand.ExecuteScalar();
            objConn.Close();
            return Convert.ToString(name);
        }
        
        
    }
}
