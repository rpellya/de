using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class SqlClass
    {
        private string _sqlConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=User10;Integrated Security=True";

        public SqlDataReader ExecuteReader(string query)
        {
            var connection = new SqlConnection(_sqlConnectionString);
            
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                return command.ExecuteReader();
            }
        }

        public T ExecuteScalar<T>(string query)
        {
            using (var connection = new SqlConnection(_sqlConnectionString))
            {
                using(var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return (T)command.ExecuteScalar();
                }
            }
        }

        public DataTable GetDataTable(string query)
        {
            using (var connection = new SqlConnection(_sqlConnectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (var connection = new SqlConnection(_sqlConnectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
