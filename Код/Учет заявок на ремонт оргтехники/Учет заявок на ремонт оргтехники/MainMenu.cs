using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учет_заявок_на_ремонт_оргтехники
{
    public partial class MainMenu : Form
    {
        private string connectionString;

        public MainMenu()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DEExample"].ConnectionString;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }
        private void LoadUsers()
        {
            string query = "SELECT * FROM [Users]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void LoadUserTypes()
        {
            string query = "SELECT * FROM [UserTypes]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void LoadOrgTech()
        {
            string query = "SELECT * FROM [OrgTech]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void Comments()
        {
            string query = "SELECT * FROM [Comments]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void LoadStatusRequests()
        {
            string query = "SELECT * FROM [RequestStatus]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void LoadRequests()
        {
            string query = "SELECT * FROM [Requests]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void UpdateRequest()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Requests SET problemDescription = @problemDescription WHERE requestID = @requestID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@problemDescription", "Updated description");
                    command.Parameters.AddWithValue("@requestID", 1);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddRequest(string startDate, string problemDescription, int requestStatusID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Requests (startDate, problemDescription, requestStatusID, clientID) VALUES (@startDate, @problemDescription, @requestStatusID, @clientID);" +
                               "INSERT INTO RequestTech (requestID, orgTechID) VALUES (SCOPE_IDENTITY(), @orgTechID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@problemDescription", problemDescription);
                    command.Parameters.AddWithValue("@requestStatusID", requestStatusID);
                    command.Parameters.AddWithValue("@clientID", "@clientID" + 1);
                    command.Parameters.AddWithValue("@orgTechID", "@orgTechID" + 1);

                    command.ExecuteNonQuery();
                }
            }
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    string query = "INSERT INTO Requests (requestNumber, startDate, orgTechID, problemDescription, statusID, masterID, clientID) VALUES (@requestNumber, @startDate, @orgTechID, @problemDescription, @statusID, @masterID, @clientID)";
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@requestNumber", "REQ123");
            //        command.Parameters.AddWithValue("@startDate", DateTime.Now);
            //        command.Parameters.AddWithValue("@orgTechID", 1);
            //        command.Parameters.AddWithValue("@problemDescription", "Printer not working");
            //        command.Parameters.AddWithValue("@statusID", 1);
            //        command.Parameters.AddWithValue("@masterID", 1);
            //        command.Parameters.AddWithValue("@clientID", 1);
            //        connection.Open();
            //        command.ExecuteNonQuery();
            //    }
            //}
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Requests (startDate, problemDescription, requestStatusID, clientID) VALUES (@startDate, @problemDescription, @requestStatusID, @clientID);" +
                               "INSERT INTO RequestTech (requestID, orgTechID) VALUES (SCOPE_IDENTITY(), @orgTechID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@problemDescription", problemDescription);
                    command.Parameters.AddWithValue("@requestStatusID", requestStatusID);
                    command.Parameters.AddWithValue("@clientID", "@clientID" + 1);
                    command.Parameters.AddWithValue("@orgTechID", "@orgTechID" + 1);

                    command.ExecuteNonQuery();
                }
            }
        }
        private void AssignMaster()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Requests SET masterID = @masterID WHERE requestID = @requestID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@masterID", 2);
                    command.Parameters.AddWithValue("@requestID", 1);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comments();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            LoadOrgTech();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadStatusRequests();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadUserTypes();
        }

        private void MainMenu_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
