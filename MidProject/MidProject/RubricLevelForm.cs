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
    public partial class RubricLevelForm : Form
    {
        public RubricLevelForm()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM RubricLevel WHERE Id LIKE @searchTerm", con);
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
                    MessageBox.Show("ID Not Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected in the DataGridView
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);
                    int rubricId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["RubricId"].Value);
                    string details = dataGridView1.Rows[rowIndex].Cells["Details"].Value.ToString();
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

                        connection.Open();
                        // Concatenate the special word with the details
                        string queryMarkRubricLevel = @"UPDATE [ProjectB].[dbo].[RubricLevel] SET [Details] = @MarkedDetails WHERE [Id] = @Id";
                        using (SqlCommand cmdMarkRubricLevel = new SqlCommand(queryMarkRubricLevel, connection))
                        {
                            cmdMarkRubricLevel.Parameters.AddWithValue("@MarkedDetails", markedDetails);
                            cmdMarkRubricLevel.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = cmdMarkRubricLevel.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Rubric Level item marked for deletion.");
                                // Additional actions after marking (if needed)
                            }
                            else
                            {
                                MessageBox.Show("No rows were affected. Rubric Level item may not exist or no changes were made.");
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
                MessageBox.Show("An error occurred while marking the rubric level item for deletion: " + ex.Message);
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

                if (!int.TryParse(idtb.Text.Trim(), out int id))
                {
                    MessageBox.Show("Invalid ID. Please enter a valid integer ID.");
                    return;
                }

                // Check if ID exists in the RubricLevel table
                SqlCommand checkIdCmd = new SqlCommand("SELECT COUNT(*) FROM RubricLevel WHERE Id = @Id", con);
                checkIdCmd.Parameters.AddWithValue("@Id", id);

                int idCount = Convert.ToInt32(checkIdCmd.ExecuteScalar());

                if (idCount == 0)
                {
                    MessageBox.Show("Error: Provided ID does not exist in the RubricLevel table.");
                    return;
                }

                // Check if required fields are empty
                if (string.IsNullOrEmpty(detailstb.Text.Trim()) || string.IsNullOrEmpty(measurestb.Text.Trim()))
                {
                    MessageBox.Show("Details and Measurement Level are required.");
                    return;
                }

                // Check if RubricId is provided in the textbox
                if (!string.IsNullOrEmpty(rubricidtb.Text.Trim()))
                {
                    if (!int.TryParse(rubricidtb.Text.Trim(), out int rubricId))
                    {
                        MessageBox.Show("Invalid Rubric ID. Please enter a valid integer Rubric ID.");
                        return;
                    }

                    // Check if the provided RubricId matches the existing RubricId
                    SqlCommand checkRubricIdCmd = new SqlCommand("SELECT RubricId FROM RubricLevel WHERE Id = @Id", con);
                    checkRubricIdCmd.Parameters.AddWithValue("@Id", id);

                    int existingRubricId = Convert.ToInt32(checkRubricIdCmd.ExecuteScalar());

                    if (existingRubricId != rubricId)
                    {
                        MessageBox.Show("Error: RubricId cannot be updated.");
                        return;
                    }
                }

                SqlCommand cmd = new SqlCommand("UPDATE RubricLevel SET Details = @Details, MeasurementLevel = @MeasurementLevel WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Details", detailstb.Text.Trim());
                cmd.Parameters.AddWithValue("@MeasurementLevel", measurestb.Text.Trim());
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("RubricLevel information updated successfully.");
                }
                else
                {
                    MessageBox.Show("No RubricLevel found with the provided ID.");
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

            try
            {
                var con = Configuration.getInstance().getConnection();

                // Close connection if already open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();

                // Check if the provided RubricId exists in the Rubric table
                SqlCommand checkRubricCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Rubric WHERE Id = @Id", con);
                checkRubricCmd.Parameters.AddWithValue("@Id", rubricidtb.Text.Trim());

                int rubricCount = (int)checkRubricCmd.ExecuteScalar();

                if (rubricCount > 0)
                {
                    // Insert into the RubricLevel table
                    using (SqlCommand insertRubricLevelCmd = new SqlCommand(
                        @"INSERT INTO RubricLevel (RubricId, Details, MeasurementLevel) 
            VALUES (@RubricId, @Details, @MeasurementLevel)", con))
                    {
                        insertRubricLevelCmd.Parameters.AddWithValue("@RubricId", rubricidtb.Text.Trim());
                        insertRubricLevelCmd.Parameters.AddWithValue("@Details", detailstb.Text);
                        insertRubricLevelCmd.Parameters.AddWithValue("@MeasurementLevel", measurestb.Text);

                        // Execute the insert query
                        int rowsAffected = insertRubricLevelCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New rubric level added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add a new rubric level.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No matching records found in Rubric table for the provided Id.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void loadbt_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new SqlConnection object using the connection string
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
                    // Execute SQL query to retrieve data excluding marked items
                    string query = @"SELECT [Id], [RubricId], [Details], [MeasurementLevel] FROM [ProjectB].[dbo].[RubricLevel] WHERE NOT [Details] LIKE '%_marked%'";
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
