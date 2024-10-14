using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configuration = CRUD_Operations.Configuration;

namespace MidProject
{
    public partial class CLOSForm : Form
    {
        public CLOSForm()
        {
            InitializeComponent();
        }

        private void clsearchbt_Click(object sender, EventArgs e)
        {
            string searchTerm = Searchtb.Text.Trim();

            // Check if search term is empty
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [Id], [Name], [DateCreated], [DateUpdated] FROM [ProjectB].[dbo].[Clo] WHERE [Name] LIKE @searchTerm", con);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No matching records found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void deletestb_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected in the DataGridView
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);
                    string itemName = dataGridView1.Rows[rowIndex].Cells["Name"].Value.ToString();
                    string markedItemName = itemName + "_marked";
                    string connectionString = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

                    // Create a new SqlConnection object using the connection string
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the connection
                       
                        // Close connection if already open
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }

                        // Open connection
                        connection.Open();
                        // Concatenate the special word with the item name
                        string queryMarkClo = @"UPDATE [ProjectB].[dbo].[Clo] SET [Name] = @MarkedName WHERE [Id] = @Id";
                        using (SqlCommand cmdMarkClo = new SqlCommand(queryMarkClo, connection))
                        {
                            cmdMarkClo.Parameters.AddWithValue("@MarkedName", markedItemName);
                            cmdMarkClo.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = cmdMarkClo.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item '" + itemName + "' marked for deletion.");
                                // Additional actions after marking (if needed)
                            }
                            else
                            {
                                MessageBox.Show("No rows were affected. Item may not exist or no changes were made.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row from the DataGridView.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while marking the item for deletion: " + ex.Message);
            }
        }





        private void Updatebt_Click(object sender, EventArgs e)
        {
            string name = nametb.Text.Trim();
            DateTime dateCreated;
            DateTime dateUpdated;
            int id;

            // Check if required fields are empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (!int.TryParse(idtb.Text.Trim(), out id))
            {
                MessageBox.Show("Invalid ID. Please enter a valid integer ID.");
                return;
            }

            // Attempt to parse the date strings into DateTime objects
            if (!DateTime.TryParse(DataCtb.Text.Trim(), out dateCreated))
            {
                MessageBox.Show("Invalid date format for 'Date Created'. Please enter a valid date.");
                return;
            }

            if (!DateTime.TryParse(datauptb.Text.Trim(), out dateUpdated))
            {
                MessageBox.Show("Invalid date format for 'Date Updated'. Please enter a valid date.");
                return;
            }

            try
            {
                var con = Configuration.getInstance().getConnection();

                // Close connection if already open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                // Open connection
                con.Open();

                // Prepare and execute SQL command to update record
                SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name = @Name, DateCreated = @DateCreated, DateUpdated = @DateUpdated WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
                cmd.Parameters.AddWithValue("@DateUpdated", dateUpdated);
                cmd.Parameters.AddWithValue("@Id", id);

                // Execute the query and get the number of rows affected
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("ClO information updated successfully.");
                }
                else
                {
                    MessageBox.Show("No CLO found with the provided ID.");
                }

                // Close the connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Addbt_Click(object sender, EventArgs e)
        {
            string name = nametb.Text.Trim();
            DateTime dateCreated = DateTime.Now; // Assign the current date and time as the creation date
            DateTime dateUpdated = DateTime.Now; // Assign the current date and time as the update date

            // Check if required fields are empty
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            try
            {
                var con = Configuration.getInstance().getConnection();

                // Close connection if already open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                // Open connection
                con.Open();

                // Prepare and execute SQL command to insert new record
                SqlCommand cmd = new SqlCommand("INSERT INTO Clo (Name, DateCreated, DateUpdated) VALUES (@Name, @DateCreated, @DateUpdated); SELECT SCOPE_IDENTITY();", con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
                cmd.Parameters.AddWithValue("@DateUpdated", dateUpdated);

                // Execute the query to insert the new record and get the auto-generated ID
                int newId = Convert.ToInt32(cmd.ExecuteScalar());

                if (newId > 0)
                {
                    MessageBox.Show("New clothing item added successfully with ID: " + newId);
                }
                else
                {
                    MessageBox.Show("Failed to add new clothing item.");
                }

                // Close the connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
       
        private void loaddatabt_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

                // Create a new SqlConnection object using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                   
                    // Close connection if already open
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    // Open connection
                    connection.Open();
                    // Execute SQL query to retrieve data excluding marked items
                    string query = @"SELECT * FROM [ProjectB].[dbo].[Clo] WHERE NOT [Name] LIKE '%_marked%'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }



















        private void LoadDataIntoGrid()
        {
           // SqlConnection con = null; // Declare SqlConnection object outside the try block

            try
            {
                var con = Configuration.getInstance().getConnection();

                // Close connection if already open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                // Open connection
                con.Open();
                string query = "SELECT * FROM [ProjectB].[dbo].[Clo]";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
            
        }



    }

}

