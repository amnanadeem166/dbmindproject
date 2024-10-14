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
    public partial class AssessmentComponent : Form
    {
        public AssessmentComponent()
        {
            InitializeComponent();
        }

        private void Searchlabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LoadDatabt_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new SqlConnection object using the connection string
                string connectionString = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

                // Create a new SqlConnection object using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    connection.Open();

                    // Execute SQL query to retrieve data excluding marked items
                    string query = @"SELECT [Id], [Name], [RubricId], [TotalMarks], [DateCreated], [DateUpdated], [AssessmentId] FROM [ProjectB].[dbo].[AssessmentComponent] WHERE NOT [Name] LIKE '%_marked%'";
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

        private void Searchbt_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM AssessmentComponent WHERE ID LIKE @searchTerm", con);
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
                    string name = dataGridView1.Rows[rowIndex].Cells["Name"].Value.ToString();
                    string markedName = name + "_marked";

                    string connectionString = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

                    // Create a new SqlConnection object using the connection string
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }

                        // Open connection
                        connection.Open();
                        // Concatenate the special word with the name
                        string queryMarkAssessmentComponent = @"UPDATE [ProjectB].[dbo].[AssessmentComponent] SET [Name] = @MarkedName WHERE [Id] = @Id";
                        using (SqlCommand cmdMarkAssessmentComponent = new SqlCommand(queryMarkAssessmentComponent, connection))
                        {
                            cmdMarkAssessmentComponent.Parameters.AddWithValue("@MarkedName", markedName);
                            cmdMarkAssessmentComponent.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = cmdMarkAssessmentComponent.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Assessment Component item marked for deletion.");
                                // Additional actions after marking (if needed)
                            }
                            else
                            {
                                MessageBox.Show("No rows were affected. Assessment Component item may not exist or no changes were made.");
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
                MessageBox.Show("An error occurred while marking the assessment component item for deletion: " + ex.Message);
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

                SqlCommand cmd = new SqlCommand(@"
        UPDATE AssessmentComponent 
        SET RubricId = (SELECT ID FROM Rubric WHERE ID = @RubricId),
            AssessmentId = (SELECT ID FROM Assessment WHERE ID = @AssessmentId),
            DateCreated = @DateCreated,
            DateUpdated = @DateUpdated 
        WHERE ID = @ID", con);

                cmd.Parameters.AddWithValue("@RubricId", rubricidtb.Text.Trim());
                cmd.Parameters.AddWithValue("@AssessmentId", Assessidtb.Text.Trim());
                cmd.Parameters.AddWithValue("@DateCreated", DateTime.Parse(dateCtb.Text.Trim())); // Assuming newDateCreatedTextBox contains a valid date string
                cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Parse(DateUptb.Text.Trim())); // Assuming you want to update the DateUpdated to the current date and time
                cmd.Parameters.AddWithValue("@ID", textBox1.Text.Trim()); // Assuming Deletetb contains the ID of the row to update

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Assessment component updated successfully.");
                }
                else
                {
                    MessageBox.Show("No assessment component found with the provided ID.");
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
            string name = nametb.Text.Trim();
            int rubricId = int.Parse(rubricidtb.Text.Trim()); // Assuming rubricIdTextBox contains the Rubric ID
            int assessmentId = int.Parse(Assessidtb.Text.Trim()); // Assuming assessmentIdTextBox contains the Assessment ID
            int totalMarks = int.Parse(totalMatb.Text.Trim()); // Assuming totalMarksTextBox contains the total marks
            DateTime dateCreated = DateTime.Parse(dateCtb.Text.Trim()); // Assuming dateCreatedTextBox contains the date created entered by the user
            DateTime dateUpdated = DateTime.Parse(DateUptb.Text.Trim());// Assign the current date and time as the creation date

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
                SqlCommand cmd = new SqlCommand(@"
        INSERT INTO AssessmentComponent (Name, RubricId, AssessmentId, TotalMarks, DateCreated, DateUpdated) 
        VALUES (@Name, 
        (SELECT ID FROM Rubric WHERE ID = @RubricId),
        (SELECT ID FROM Assessment WHERE ID = @AssessmentId),
        @TotalMarks, @DateCreated, @DateCreated ,@DateUpdated , @DateUpdated); 
        SELECT SCOPE_IDENTITY();", con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@RubricId", rubricId);
                cmd.Parameters.AddWithValue("@AssessmentId", assessmentId);
                cmd.Parameters.AddWithValue("@TotalMarks", totalMarks);
                cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
                cmd.Parameters.AddWithValue("@DateUpdated", dateUpdated);

                // Execute the query to insert the new record and get the auto-generated ID
                int newId = Convert.ToInt32(cmd.ExecuteScalar());

                if (newId > 0)
                {
                    MessageBox.Show("New assessment component added successfully with ID: " + newId);
                }
                else
                {
                    MessageBox.Show("Failed to add new assessment component.");
                }

                // Close the connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
