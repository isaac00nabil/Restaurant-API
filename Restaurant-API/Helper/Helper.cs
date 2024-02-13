using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace Restaurant_API.Helper
{
    public static class Helper
    {
        //public static string connectionString = @"Server=ISAAC\SQLEXPRESS;Database=restaurant_db;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true";
        public static int ExecuteNonQueryCommand(string query,Dictionary<string,object> obj)
        {
            SqlConnection connection = new SqlConnection(Helper.connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            if(obj != null)
            {
                foreach (KeyValuePair<string,object> kvp in obj)
                {
                    command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                }
            }
            return rows;
        }

        public static DataTable ExecuteQuery(string query, Dictionary<string, object> obj)
        {

            SqlConnection connection = new SqlConnection(Helper.connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            if (obj != null)
            {
                foreach (KeyValuePair<string, object> kvp in obj)
                {
                    command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }

        public static string RandomPassword()
        {
            Random random = new Random();
            string password = "";
            string chars = "QWERTYUIOPqwertyuiop0123456789ASDFGHJKLzxcvbnmZXCVBNMa7894561230sdfghjkl";
            int length = random.Next(10, 15);
            for (int i = 0; i < length; i++)
            {
                int rand = random.Next(0, chars.Length);
                password += chars[rand];

            }
            return password;
        }


    }
}
