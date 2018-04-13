using System;
using System.Data.SqlClient;

namespace Demos
{
    class AsyncDB
    {
        public static void ReadDBSync()
        {
            var cnnString = @"Data Source=.;Initial Catalog=Customers;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cnnString);
            cnn.Open();

            var sql = "Select * From dbo.Customers";
            SqlCommand cmd = new SqlCommand(sql, cnn);

            var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var id = rdr.GetInt32(0);
                var name = rdr.GetString(1);
                Console.WriteLine("id {0}, name {1}", id, name);
            }

            cnn.Close();
        }
        public async static void ReadDBAsync()
        {
            var cnnString = @"Data Source=.;Initial Catalog=Customers;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cnnString);
            cnn.Open();

            var sql = "Select * From dbo.Customers";
            SqlCommand cmd = new SqlCommand(sql, cnn);

            var rdr = cmd.ExecuteReader();
            while (await rdr.ReadAsync())
            {
                var id = rdr.GetInt32(0);
                var name = rdr.GetString(1);
                Console.WriteLine("id {0}, name {1}", id, name);
            }

            cnn.Close();
        }
    }
}
