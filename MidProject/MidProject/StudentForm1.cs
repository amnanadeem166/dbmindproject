using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Configuration = CRUD_Operations.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace MidProject
{
    public partial class StudentForm1 : Form
    {
        public StudentForm1()
        {
            InitializeComponent();
        }

        private void loaddatabt_Click(object sender, EventArgs e)
        {

            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE Status <> 3", con); // Assuming 3 represents "Deleted"
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE RegistrationNumber LIKE @searchTerm", con);
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
                    MessageBox.Show("Registration Number Not Found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletestb_Click(object sender, EventArgs e)
        {
           
                string firstName = fnametxt.Text.Trim();
                string lastName = Lnametb.Text.Trim();
                string contact = contacttb.Text.Trim();
                string email = emailtb.Text.Trim();
                string regNumber = regtb.Text.Trim();
                int statusId;

                // Determine status based on combo box selection
                string status = statuscb.SelectedItem.ToString();
                if (status == "Active")
                {
                    statusId = 2;
                }
                else if (status == "Inactive")
                {
                    statusId = 3;
                }
                else
                {
                    MessageBox.Show("Invalid status selection.");
                    return;
                }

                // Check if required fields are empty
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(contact) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(regNumber))
                {
                    MessageBox.Show("All fields are required.");
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) " +
                                                    "VALUES (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status); " +
                                                    "SELECT SCOPE_IDENTITY();", con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", regNumber);
                    cmd.Parameters.AddWithValue("@Status", statusId);

                    // Execute the query to insert the new record and get the auto-generated ID
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());

                    if (newId > 0)
                    {
                        MessageBox.Show("New student added successfully with ID: " + newId);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new student.");
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
            string firstName = fnametxt.Text.Trim();
            string lastName = Lnametb.Text.Trim();
            string contact = contacttb.Text.Trim();
            string email = emailtb.Text.Trim();
            string regNo = regtb.Text.Trim();


            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(regNo))
            {
                MessageBox.Show("First name, last name, and registration number are required.");
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


                SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email WHERE RegistrationNumber = @RegNo", con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@RegNo", regNo);


                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student information updated successfully.");
                }
                else
                {
                    MessageBox.Show("No student found with the provided registration number.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            string status = statuscb.SelectedItem.ToString();

            if (status == "Active")
            {
                try
                {
                    var con = Configuration.getInstance().getConnection();

                    // Close the connection if it's already open
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    // Open the connection
                    con.Open();

                    // Construct the SQL UPDATE query to set status to "Inactive"
                    SqlCommand cmd = new SqlCommand("UPDATE Student SET Status = 3 WHERE FirstName = @FirstName AND LastName = @LastName AND RegistrationNumber = @RegNo", con);
                    cmd.Parameters.AddWithValue("@FirstName", fnametxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", Lnametb.Text.Trim());
                    cmd.Parameters.AddWithValue("@RegNo", regtb.Text.Trim());

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student status updated to Inactive in database.");
                    }
                    else
                    {
                        MessageBox.Show("No student found with the provided information.");
                    }

                    // Close the connection
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (status == "Inactive")
            {
                MessageBox.Show("Cannot change the status of an inactive student.");
            }
            else
            {
                MessageBox.Show("Invalid status selected.");
            }
        }
    }
}
