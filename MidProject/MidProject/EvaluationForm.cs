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


namespace MidProject
{
    public partial class EvaluationForm : Form
    {
        public EvaluationForm()
        {
            InitializeComponent();
            PopulateCLOComboBox();
            PopulateAssessmentComboBox();
        }

        private void clo_btn_Click(object sender, EventArgs e)
        {

            try
            {
                // Define your connection string
                string connectionString = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

                // Create a new SqlConnection object using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    if (cbx_clos.SelectedValue != null && int.TryParse(cbx_clos.SelectedValue.ToString(), out int selectedCLOId))
                    {
                        // Your existing SQL command with the modified WHERE clause to filter by selected CLO ID
                        SqlCommand cmd = new SqlCommand("SELECT (SELECT FirstName + ' ' + LastName FROM Student WHERE Id = StudentId) AS Name, (SELECT RegistrationNumber FROM Student WHERE Id = StudentId) AS RegNo, SUM(ObtainedMarks) AS ObtainedMarks, SUM(TotalMarks) AS TotalMarks " +
                                                         "FROM( " +
                                                         "SELECT StudentId, AC.TotalMarks * CAST((SELECT MeasurementLevel FROM RubricLevel WHERE Id = RubricMeasurementId) AS float) / (SELECT MAX(MeasurementLevel) FROM RubricLevel WHERE RubricId = AC.RubricId) AS ObtainedMarks, AC.TotalMarks, (SELECT CloId FROM Rubric WHERE Id = AC.RubricId) AS CloId " +
                                                         "FROM StudentResult SR " +
                                                         "JOIN AssessmentComponent AC " +
                                                         "ON AC.RubricId IN(SELECT Id FROM Rubric WHERE CloId = @CLOID) AND SR.AssessmentComponentId = AC.Id) p1 " +
                                                         "WHERE CloId = @CLOID AND (SELECT Name FROM Lookup WHERE LookupId = (SELECT Status FROM Student WHERE Id = StudentId)) != 'Inactive'" +
                                                         "GROUP BY StudentId", connection);

                        // Add parameter for the selected CLO ID
                        cmd.Parameters.AddWithValue("@CLOID", selectedCLOId);

                        // Execute the SQL command
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Generate the report using the DataTable
                        // Add your code here to generate the report based on the DataTable 'dt'

                        // Specify the file path to save the PDF report
                        string filePath = @"D:\4thSemester\DBmidproject\dbmidproject-2022-cs-96\MidProject\PDFReports\report.pdf";

                        // Save the report as a PDF file
                        // Replace 'GeneratePDFReport' with your actual method to generate the PDF report
                        GeneratePDFReport(dt, filePath);

                        // Optionally, display a message indicating that the report has been generated
                        MessageBox.Show("Report generated successfully and saved to PDFReports directory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid CLO ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during report generation
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratePDFReport(DataTable reportData, string filePath)
        {
            // Create a new PDF document
            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            try
            {
                // Create a PdfWriter instance to write the document to the specified file path
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                // Open the document
                doc.Open();

                // Create a PdfPTable to hold the report data
                PdfPTable table = new PdfPTable(reportData.Columns.Count);

                // Add table headers
                foreach (DataColumn column in reportData.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    table.AddCell(cell);
                }

                // Add table rows
                foreach (DataRow row in reportData.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString()));
                        table.AddCell(cell);
                    }
                }

                // Add the table to the document
                doc.Add(table);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during PDF generation
                MessageBox.Show("Error generating PDF report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the document
                doc.Close();
            }
        }




        private void PopulateCLOComboBox()
        {
            try
            {
                // Define SQL query to fetch CLO IDs from the database
                string query = "SELECT Id FROM Clo";

                // Create a new SqlConnection object using the predefined connection string
                using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True"))
                {
                    // Create a new SqlDataAdapter to fetch data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Create a new DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Open the database connection
                    connection.Open();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);

                    // Set the ComboBox's DataSource property to the DataTable
                    cbx_clos.DataSource = dataTable;

                    // Set the DisplayMember and ValueMember properties
                    cbx_clos.DisplayMember = "Id"; // Display the CLO ID
                    cbx_clos.ValueMember = "Id";   // Set the value of the selected item to the CLO ID
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during database access
                MessageBox.Show("Error fetching CLO IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void assessment_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Define your connection string
                string connectionString = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

                // Create a new SqlConnection object using the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Check if an assessment title is selected
                    if (cbxAssessmentTitles.SelectedItem != null)
                    {
                        // Retrieve the selected assessment ID from the ComboBox
                        int selectedAssessmentId = Convert.ToInt32(cbxAssessmentTitles.SelectedValue);

                        // Define the SQL command with the selected assessment ID
                        SqlCommand cmd = new SqlCommand("SELECT (SELECT FirstName + ' ' + LastName FROM Student WHERE Id = StudentId) AS Name, (SELECT RegistrationNumber FROM Student WHERE Id = StudentId) AS RegNo, SUM(ObtainedMarks) AS ObtainedMarks, SUM(TotalMarks) AS TotalMarks, ROUND(CAST((SUM(ObtainedMarks) / SUM(TotalMarks)) AS float) * 100, 2) AS Percentage " +
                                       "FROM( " +
                                       "SELECT StudentId, AC.TotalMarks * CAST((SELECT MeasurementLevel FROM RubricLevel WHERE Id = SR.RubricMeasurementId AND RubricId = AC.RubricId) AS float) / (SELECT MAX(MeasurementLevel) FROM RubricLevel WHERE RubricId = AC.RubricId) AS ObtainedMarks, TotalMarks " +
                                       "FROM StudentResult SR " +
                                       "JOIN AssessmentComponent AS AC " +
                                       "ON SR.AssessmentComponentId = AC.Id AND AC.AssessmentId = @AssessmentId " +
                                       "JOIN Student ON SR.StudentId = Student.Id " +
                                       "JOIN LookUp ON Lookup.Name = 'Inactive' AND Lookup.LookupId != Student.Status) p1 " +
                                       "GROUP BY StudentId", connection);

                        // Add the selected assessment ID as a parameter
                        cmd.Parameters.AddWithValue("@AssessmentId", selectedAssessmentId);

                        // Execute the SQL command
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Specify the file path to save the PDF report
                        string filePath = @"D:\4thSemester\DBmidproject\dbmidproject-2022-cs-96\MidProject\PDFReports\report2.pdf";

                        // Generate the report using the DataTable
                        GeneratePDFReport1(dt, filePath);

                        // Display a success message
                        MessageBox.Show("Report generated successfully and saved to PDFReports directory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Display an error message if no assessment title is selected
                        MessageBox.Show("Please select an assessment title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during report generation
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void PopulateAssessmentComboBox()
        {
            try
            {
                // Define SQL query to fetch assessment titles
                string query = "SELECT DISTINCT Title FROM Assessment";

                using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear existing items in the combo box
                    cbxAssessmentTitles.Items.Clear();

                    // Add assessment titles to the combo box
                    foreach (DataRow row in dataTable.Rows)
                    {
                        cbxAssessmentTitles.Items.Add(row["Title"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching assessment titles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GeneratePDFReport1(DataTable data, string filePath)
        {
            // Create a new PDF document
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            // Add content to the PDF document based on the assessment data
            foreach (DataRow row in data.Rows)
            {
                // Example: Add assessment data to the PDF document
                doc.Add(new Paragraph("Student ID: " + row["StudentId"]));
                doc.Add(new Paragraph("Name: " + row["Name"]));
                doc.Add(new Paragraph("Registration Number: " + row["RegNo"]));
                doc.Add(new Paragraph("Obtained Marks: " + row["ObtainedMarks"]));
                doc.Add(new Paragraph("Total Marks: " + row["TotalMarks"]));
                doc.Add(new Paragraph("\n")); // Add spacing between student data
            }

            doc.Close();
        }
    }
}

