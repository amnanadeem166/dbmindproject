using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Configuration = CRUD_Operations.Configuration;

namespace MidProject
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void loadbt_Click(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void LoadAttendance()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT ClassAttendance.Id AS ClassAttendenceId, Student.Id AS StudentId, Student.FirstName, Student.RegistrationNumber, ClassAttendance.AttendanceDate, StudentAttendance.AttendanceStatus FROM Student, StudentAttendance, ClassAttendance WHERE Student.Id = StudentAttendance.StudentId AND ClassAttendance.Id = StudentAttendance.AttendanceId", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["StudentId"].Visible = false;
                dataGridView1.Columns["ClassAttendenceId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                    int classAttendanceId = Convert.ToInt32(row.Cells["ClassAttendenceId"].Value);
                    int attendanceStatus = Convert.ToInt32(row.Cells["AttendanceStatus"].Value);

                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE StudentAttendance SET AttendanceStatus = @status WHERE StudentId = @studentId AND AttendanceId = @classAttendanceId", con);
                    cmd.Parameters.AddWithValue("@status", attendanceStatus);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@classAttendanceId", classAttendanceId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Attendance updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated. Attendance not updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating attendance: " + ex.Message);
            }
        }





        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "AttendanceStatus" && e.Value != null)
            {
                int status = Convert.ToInt32(e.Value);
                if (status == 1)
                {
                    e.Value = "Present";
                }
                else if (status == 4)
                {
                    e.Value = "Absent";
                }
            }
        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }




    }
}
