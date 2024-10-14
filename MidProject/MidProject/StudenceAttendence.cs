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
    public partial class StudenceAttendence : Form
    {
        public StudenceAttendence()
        {
            InitializeComponent();
           
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fetchattendbt1_Click(object sender, EventArgs e)
        {
           var con = Configuration.getInstance().getConnection();
           SqlCommand cmd = new SqlCommand("SELECT ClassAttendance.Id AS ClassAttendenceId,Student.Id AS StudentId,Student.FirstName,Student.RegistrationNumber,ClassAttendance.AttendanceDate,StudentAttendance.AttendanceStatus FROM Student, StudentAttendance, ClassAttendance WHERE Student.Id = StudentAttendance.StudentId AND ClassAttendance.Id = StudentAttendance.AttendanceId", con);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           dataGridView1.DataSource = dt;
           dataGridView1.Columns["StudentId"].Visible = false;
           dataGridView1.Columns["ClassAttendenceId"].Visible = false;
        }

        private void Checkattendbt_Click(object sender, EventArgs e)
        {
            Attendence newform = new Attendence();
            newform.Show();
        }

       private void Deleteattendbt_Click(object sender, EventArgs e)
        {
            ClassAttendence newform = new ClassAttendence();
            newform.Show();

       }
        




    }
}

