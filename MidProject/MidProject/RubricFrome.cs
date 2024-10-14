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
    public partial class RubricFrome : Form
    {
        public RubricFrome()
        {
            InitializeComponent();
        }

        private void searchbt_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("SELECT TOP (1000) [Id], [Details], [CloId] FROM [ProjectB].[dbo].[Rubric] WHERE [Details] LIKE @searchTerm", con);
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
                    string details = dataGridView1.Rows[rowIndex].Cells["Details"].Value.ToString();
                    int cloId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["CloId"].Value);
                    string markedDetails = details + "_marked";

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
                        // Concatenate the special word with the details
                        string queryMarkRubric = @"UPDATE [ProjectB].[dbo].[Rubric] SET [Details] = @MarkedDetails WHERE [Id] = @Id";
                        using (SqlCommand cmdMarkRubric = new SqlCommand(queryMarkRubric, connection))
                        {
                            cmdMarkRubric.Parameters.AddWithValue("@MarkedDetails", markedDetails);
                            cmdMarkRubric.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = cmdMarkRubric.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Rubric item marked for deletion.");
                                // Additional actions after marking (if needed)
                            }
                            else
                            {
                                MessageBox.Show("No rows were affected. Rubric item may not exist or no changes were made.");
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
                MessageBox.Show("An error occurred while marking the rubric item for deletion: " + ex.Message);
            }
        }

        private void Updatebt_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();


                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


                con.Open();


                SqlCommand cmd = new SqlCommand("UPDATE Rubric SET Details = @Details WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Details", detailstb.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", idtb.Text.Trim());


                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Rubric information updated successfully.");
                }
                else
                {
                    MessageBox.Show("No Rubric found with the provided ID.");
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Addbt_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            con.Close();
            try
            {
                con = new SqlConnection("Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True");
                con.Open();

                // Select the rows from Clo table where ID matches any CloID from Rubric table
                List<int> cloIDs = new List<int>();
                using (SqlCommand selectCloCmd = new SqlCommand(
                    @"SELECT ID 
                FROM Clo 
                WHERE ID NOT IN (SELECT CloID FROM Rubric)", con))
                {
                    using (SqlDataReader reader = selectCloCmd.ExecuteReader())
                    {
                        // Load Clo IDs into a list
                        while (reader.Read())
                        {
                            int cloID = reader.GetInt32(0);
                            cloIDs.Add(cloID);
                        }
                    }
                }

                // Iterate through the list of Clo IDs and insert into the Rubric table
                foreach (int cloID in cloIDs)
                {
                    using (SqlCommand insertRubricCmd = new SqlCommand(
                        @"INSERT INTO Rubric (ID, Details, CloID) 
                    VALUES (@ID, @Details, @CloID)", con))
                    {
                        insertRubricCmd.Parameters.AddWithValue("@ID", idtb.Text.Trim());
                        insertRubricCmd.Parameters.AddWithValue("@Details", detailstb.Text);
                        insertRubricCmd.Parameters.AddWithValue("@CloID", cloID);

                        // Execute the insert query
                        int rowsAffected = insertRubricCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New rubric added successfully for CloID: " + cloID);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add a new rubric for CloID: " + cloID);
                        }
                    }
                }
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
                    string query = @"SELECT [Id], [Details], [CloId] FROM [ProjectB].[dbo].[Rubric] WHERE NOT [Details] LIKE '%_marked%'";
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

        
    }
}
