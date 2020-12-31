using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADO.NET
{
    class ReadEmpDetails
    {
        private string connectionString;
        private SqlConnection objConn;
        public ReadEmpDetails()
        {
         connectionString= "Data Source = 192.168.50.95; Initial Catalog = rgurram; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
            objConn = new SqlConnection(connectionString);
        }
        public void Execute()
        {
            objConn.Open();
            SqlCommand sqlCommand = new SqlCommand("select empid,name,salary,location from employee_11dec", objConn);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader["empid"] + "\t" +sqlDataReader["name"] +"\t" + "\t" + sqlDataReader["salary"] + "\t" +"\t" + sqlDataReader["location"]);
            }
            objConn.Close();
        }
    }
}
 