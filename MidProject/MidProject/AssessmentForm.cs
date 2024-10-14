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
    public partial class AssessmentForm : Form
    {
        public AssessmentForm()
        {
            InitializeComponent();
        }




        private void TWeighttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Assessment WHERE ID LIKE @searchTerm", con);
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Check if any row is selected in the DataGridView
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);
                    string title = dataGridView1.Rows[rowIndex].Cells["Title"].Value.ToString();
                    string markedTitle = title + "_marked";

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

                        // Concatenate the special word with the title
                        string queryMarkAssessment = @"UPDATE [ProjectB].[dbo].[Assessment] SET [Title] = @MarkedTitle WHERE [Id] = @Id";
                        using (SqlCommand cmdMarkAssessment = new SqlCommand(queryMarkAssessment, connection))
                        {
                            cmdMarkAssessment.Parameters.AddWithValue("@MarkedTitle", markedTitle);
                            cmdMarkAssessment.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = cmdMarkAssessment.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Assessment item marked for deletion.");
                                // Additional actions after marking (if needed)
                            }
                            else
                            {
                                MessageBox.Show("No rows were affected. Assessment item may not exist or no changes were made.");
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
                MessageBox.Show("An error occurred while marking the assessment item for deletion: " + ex.Message);
            }
        }

        private void addbt_Click(object sender, EventArgs e)
        {

            string title = titletb.Text.Trim();
            DateTime dateCreated = DateTime.Now; // Assign the current date and time as the creation date
            int totalMarks = int.Parse(TMarkstb.Text.Trim()); // Assuming the total marks is an integer value
            float totalWeightage = float.Parse(TWeighttb.Text.Trim()); // Assuming the total weightage is a float value

            // Check if required fields are empty
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title is required.");
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES (@Title, @DateCreated, @TotalMarks, @TotalWeightage); SELECT SCOPE_IDENTITY();", con);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
                cmd.Parameters.AddWithValue("@TotalMarks", totalMarks);
                cmd.Parameters.AddWithValue("@TotalWeightage", totalWeightage);

                // Execute the query to insert the new record and get the auto-generated ID
                int newId = Convert.ToInt32(cmd.ExecuteScalar());

                if (newId > 0)
                {
                    MessageBox.Show("New assessment added successfully with ID: " + newId);
                }
                else
                {
                    MessageBox.Show("Failed to add new assessment.");
                }

                // Close the connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Updatebt_Click(object sender, EventArgs e)
        {
            string Id = idtb.Text.Trim();
            string title = titletb.Text.Trim();
            DateTime dateCreated = DateTime.Parse(DateCtb.Text.Trim()); // Convert string to DateTime
            string TotalMarks = TMarkstb.Text.Trim();
            string TotalWeightage = TWeighttb.Text.Trim();


            if (string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(TotalMarks) || string.IsNullOrEmpty(TotalWeightage))
            {
                MessageBox.Show("ID, Title, Total Marks, and Total Weightage are required.");
                return;
            }

            try
            {
                var con = Configuration.getInstance().getConnection();


                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.Open();


                SqlCommand cmd = new SqlCommand("UPDATE Assessment SET Title = @Title, DateCreated = @DateCreated, TotalMarks = @TotalMarks , TotalWeightage = @TotalWeightage  WHERE  ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(Id)); // Convert Id to integer
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@DateCreated", dateCreated);
                cmd.Parameters.AddWithValue("@TotalMarks", TotalMarks);
                cmd.Parameters.AddWithValue("@TotalWeightage", TotalWeightage);


                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Assessment information updated successfully.");
                }
                else
                {
                    MessageBox.Show("No Assessment found with the provided ID.");
                }

                con.Close();
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
                    connection.Open();

                    // Execute SQL query to retrieve data excluding marked items
                    string query = @"SELECT [Id], [Title], [DateCreated], [TotalMarks], [TotalWeightage] FROM [ProjectB].[dbo].[Assessment] WHERE NOT [Title] LIKE '%_marked%'";
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
