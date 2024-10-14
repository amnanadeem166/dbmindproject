using iTextSharp.text.pdf;
using iTextSharp.text;
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
using System.Diagnostics;

namespace MidProject
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = @"D:\4thSemester\DBmidproject\dbmidproject-2022-cs-96\MidProject\PDFReports";
                string reportName = "Class Attendance Report"; // Hardcoded report name

                string filePath = Path.Combine(directoryPath, "Class Attendance Report.pdf");

                // Establish connection to the database
                var con = Configuration.getInstance().getConnection();

                // Close connection if already open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                // Open connection
                con.Open();

                if (!string.IsNullOrEmpty(reportName))
                {
                    string query = string.Empty;
                    switch (reportName)
                    {
                        case "Class Attendance Report":
                            // Define SQL query for class attendance report
                            query = @"
                        SELECT
                            Student.RegistrationNumber,
                            ClassAttendance.AttendanceDate,
                            StudentAttendance.AttendanceStatus
                        FROM
                            Student
                        JOIN
                            StudentAttendance ON Student.Id = StudentAttendance.StudentId
                        JOIN
                            ClassAttendance ON ClassAttendance.Id = StudentAttendance.AttendanceId";
                            break;
                        // Add other cases for additional reports

                        default:
                            MessageBox.Show("Invalid report name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Create SQL command with parameters
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Execute command and fill DataTable with results
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Generate PDF
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        // Create a PDF document
                        Document document = new Document();
                        PdfWriter.GetInstance(document, fs);

                        // Add a title
                        Paragraph title = new Paragraph($"{reportName}\n\n");
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Open(); // Open the document for writing
                        document.Add(title);

                        // Add data to the document
                        PdfPTable table = new PdfPTable(dt.Columns.Count);
                        table.WidthPercentage = 100;

                        // Add header row
                        foreach (DataColumn column in dt.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }

                        // Add data rows
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (object item in row.ItemArray)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(item.ToString()));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                            }
                        }

                        // Add table to the document
                        document.Add(table);

                        // Close the document
                        document.Close();
                    }

                    MessageBox.Show($"{reportName} PDF generated successfully and saved at:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Report name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //Studence Report //


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Call the method to generate the PDF report
            GeneratePDFReportS();
        }

        private void GeneratePDFReportS()
        {
            try
            {
                // Specify the directory where you want to save the PDF report
                string directoryPath = @"D:\4thSemester\DBmidproject\dbmidproject-2022-cs-96\MidProject\PDFReports";
                // Specify the file path for the PDF report
                string filePath = Path.Combine(directoryPath, "StudentReport.pdf");

                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True"))
                {
                    connection.Open();

                    // SQL query to retrieve student and assessment result data
                    string query = @"
                SELECT
                    sa.AttendanceId,
                    c.AttendanceDate,
                    s.FirstName + ' ' + s.LastName AS StudentName,
                    l.Name AS AttendanceStatus
                FROM
                    StudentAttendance sa
                JOIN
                    ClassAttendance c ON sa.AttendanceId = c.Id
                JOIN
                    Student s ON sa.StudentId = s.Id
                JOIN
                    Lookup l ON sa.AttendanceStatus = l.LookupId
                ORDER BY
                    sa.AttendanceId,
                    s.FirstName,
                    s.LastName";

                    // Create SQL command and data adapter
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // Fill the data table with query results
                    da.Fill(dt);

                    // Generate PDF report
                    GeneratePDFReport(dt, filePath);
                }

                // Display message after generating the report
                MessageBox.Show($"Report generated successfully. You can find it at:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratePDFReport(DataTable dt, string filePath)
        {
            try
            {
                // Create a PDF document
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document
                document.Open();

                // Add a title
                Paragraph title = new Paragraph("Student Report\n\n");
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Create a PDF table
                PdfPTable table = new PdfPTable(dt.Columns.Count);
                table.WidthPercentage = 100;

                // Add column headers to the PDF table
                foreach (DataColumn column in dt.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                // Add data rows to the PDF table
                foreach (DataRow row in dt.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                // Add table to the document
                document.Add(table);

                // Close the document
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Student Average Marks
       
        

        private void dateattend_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = @"D:\4thSemester\DBmidproject\dbmidproject-2022-cs-96\MidProject\PDFReports";
                // Specify the directory where you want to save the report
                string filePath = Path.Combine(directoryPath, "StudentAverageMarks.pdf");

                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True"))
                {
                    connection.Open();

                    // SQL query to retrieve student and assessment result data
                    string query = @"
                SELECT s.FirstName, s.LastName, ac.Id AS AssessmentComponentId, AVG(sr.RubricMeasurementId) AS AvgMarks
                FROM Student s
                JOIN StudentResult sr ON s.Id = sr.StudentId
                JOIN AssessmentComponent ac ON sr.AssessmentComponentId = ac.Id
                GROUP BY s.FirstName, s.LastName, ac.Id";

                    // Create SQL command and data adapter
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // Fill the data table with query results
                    da.Fill(dt);

                    // Generate PDF report
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        // Create a PDF document
                        Document document = new Document();
                        PdfWriter.GetInstance(document, fs);

                        // Open the document
                        document.Open();

                        // Add a title
                        Paragraph title = new Paragraph("Student Average Marks\n\n");
                        title.Alignment = Element.ALIGN_CENTER;
                        document.Add(title);

                        // Create a PDF table
                        PdfPTable table = new PdfPTable(dt.Columns.Count);
                        table.WidthPercentage = 100;

                        // Add column headers to the PDF table
                        foreach (DataColumn column in dt.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }

                        // Add data rows to the PDF table
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (object item in row.ItemArray)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(item.ToString()));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(cell);
                            }
                        }

                        // Add table to the document
                        document.Add(table);

                        // Close the document
                        document.Close();
                    }

                    // Display message after generating the report
                    MessageBox.Show($"Report generated successfully. You can find it at:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //Studence Attendence Report


        private void Studenceatt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = @"D:\4thSemester\DBmidproject\dbmidproject-2022-cs-96\MidProject\PDFReports";
                string reportName = "Studence Attendance Report"; // Hardcoded report name

                string filePath = Path.Combine(directoryPath, "Studence Attendance Report.pdf");

                // Establish connection to the database
                var con = Configuration.getInstance().getConnection();

                // Close connection if already open
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                // Open connection
                con.Open();

                if (!string.IsNullOrEmpty(reportName))
                {
                    string query = "SELECT R2.Id, Student.RegistrationNumber, R2.PresentDays, " +
                                   "((CAST(R2.PresentDays as float) / CAST(R2.TotalDays AS float)) * 100) AS [Attendance Percentage] " +
                                   "FROM (SELECT Student.Id, R1.PresentDays, (SELECT COUNT(Id) FROM ClassAttendance) AS TotalDays " +
                                   "FROM (SELECT Student.Id, COUNT(Student.Id) AS PresentDays " +
                                   "FROM Student INNER JOIN StudentAttendance ON Student.Id = StudentAttendance.StudentId " +
                                   "WHERE StudentAttendance.AttendanceStatus = 1 GROUP BY Student.Id) AS R1 " +
                                   "INNER JOIN Student ON Student.Id = R1.Id) AS R2 INNER JOIN Student ON Student.Id = R2.Id";

                    // Create SQL command with parameters
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Execute command and fill DataTable with results
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Generate PDF report
                    GeneratePDFReport1(dt, filePath);

                    // Display message after generating the report
                    MessageBox.Show($"PDF report generated successfully. You can find it at:\n{filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Report name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratePDFReport1(DataTable dt, string filePath)
        {
            try
            {
                // Create a new PDF document
                Document document = new Document();

                // Create a PdfWriter instance to write the document to the specified file path
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document
                document.Open();

                // Add a title to the document
                Paragraph title = new Paragraph("Student Attendance Report\n\n");
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Create a PdfPTable to hold the report data
                PdfPTable table = new PdfPTable(dt.Columns.Count);
                table.WidthPercentage = 100;

                // Add table headers
                foreach (DataColumn column in dt.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                // Add table rows
                foreach (DataRow row in dt.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                // Add the table to the document
                document.Add(table);

                // Close the document
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}





