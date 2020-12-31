using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace ADO.NET
{
    public  class InsertRecordUsingSQLQuery
    {
        
        private string connectionString;
        private SqlConnection objConn;
        public InsertRecordUsingSQLQuery()
        {
            connectionString = "Data Source = 192.168.50.95; Initial Catalog = rgurram; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False";
            objConn = new SqlConnection(connectionString);
        }
        public void execute()
        {
            try
            {
                Console.WriteLine("Enter employee details");
                string empid = Console.ReadLine();
                string name = Console.ReadLine();
                int salary = int.Parse(Console.ReadLine());
                string location = Console.ReadLine();
                objConn.Open();
                // SqlCommand sqlCommand = new SqlCommand("INSERT INTO employee_11dec  VALUES (@empid,@name,@salary,@location)", objConn);
                // SqlCommand sqlCommand = new SqlCommand("update employee_11dec SET empid=@empid,name=@name,salary=@salary where location=@location", objConn);
                // SqlCommand sqlCommand = new SqlCommand("delete from employee_11dec WHERE location=@location", objConn);
                
                SqlCommand sqlCommand = new SqlCommand("usp_employee_11dec", objConn);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@empid", empid);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@salary", salary);
                sqlCommand.Parameters.AddWithValue("@location", location);
                sqlCommand.ExecuteNonQuery();
                objConn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("error occured" +ex.Message);
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                    objConn.Close();
            }


        }
    }
}
