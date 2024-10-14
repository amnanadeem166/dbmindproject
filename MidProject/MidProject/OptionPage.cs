using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject
{
    public partial class OptionPage : Form
    {

        private readonly StudentForm1 stu = new StudentForm1();
        private readonly CLOSForm clo = new CLOSForm();
        private readonly RubricFrome rub = new RubricFrome();
        private readonly RubricLevelForm rubl = new RubricLevelForm();
        private readonly AssessmentForm ass = new AssessmentForm();
        private readonly AssessmentComponent assc = new AssessmentComponent();
        private readonly StudenceAttendence sa = new StudenceAttendence();
        private readonly EvaluationForm eva = new EvaluationForm();
        private readonly ReportsForm rep = new ReportsForm();
        public OptionPage()
        {
            InitializeComponent();

            stu.Size = splitContainer1.Panel2.Size;
        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stu.TopLevel = false;
            stu.FormBorderStyle = FormBorderStyle.None;
            stu.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(stu);
            stu.Show();
        }


        private void panel_SizeChanged(object sender, EventArgs e)
        {
            // Adjust the size of the form to match the size of the panel
            stu.Size = splitContainer1.Panel2.Size;
        }




        private void OptionPage_Load(object sender, EventArgs e)
        {
            stu.Hide();
            clo.Hide();
            rub.Hide();
            rubl.Hide();
            assc.Hide();
            eva.Hide();
            rep.Hide();

            this.Size = splitContainer1.Panel2.Size;
        }



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Remove any previously added form from splitContainer1.Panel2
            splitContainer1.Panel2.Controls.Clear();

            // Add stu form
            stu.TopLevel = false;
            stu.FormBorderStyle = FormBorderStyle.None;
            stu.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(stu);
            stu.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Remove any previously added form from splitContainer1.Panel2
            splitContainer1.Panel2.Controls.Clear();

            // Add stu form
            clo.TopLevel = false;
            clo.FormBorderStyle = FormBorderStyle.None;
            clo.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(clo);
            clo.Show();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            // Add stu form
            rub.TopLevel = false;
            rub.FormBorderStyle = FormBorderStyle.None;
            rub.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(rub);
            rub.Show();
        }
        //Rubric Level Page
        private void button5_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            // Add stu form
            rubl.TopLevel = false;
            rubl.FormBorderStyle = FormBorderStyle.None;
            rubl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(rubl);
            rubl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            // Add stu form
            ass.TopLevel = false;
            ass.FormBorderStyle = FormBorderStyle.None;
            ass.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(ass);
            ass.Show();
        }


        private void attendence_Click_1(object sender, EventArgs e)
        {

            splitContainer1.Panel2.Controls.Clear();
            // Add stu form
            sa.TopLevel = false;
            sa.FormBorderStyle = FormBorderStyle.None;
            sa.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(sa);
            sa.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            splitContainer1.Panel2.Controls.Clear();
            assc.TopLevel = false;
            assc.FormBorderStyle = FormBorderStyle.None;
            assc.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(assc);
            assc.Show();
        }

        private void eval_btn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            eva.TopLevel = false;
            eva.FormBorderStyle = FormBorderStyle.None;
            eva.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(eva);
            eva.Show();
        }

        private void rep_btn_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            rep.TopLevel = false;
            rep.FormBorderStyle = FormBorderStyle.None;
            rep.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(rep);
            rep.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
