using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace employeeManagement
{
    public partial class inventoryView : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DatabaseDal;Integrated Security=True;TrustServerCertificate=True";


        public inventoryView()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataIntoGridView()
        {

            try
            {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory", con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);

                        dataGridView1.ReadOnly = false;
                        dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;


                        dataGridView1.DataSource = dt;

                        // Assuming dataGridView1 is the name of your DataGridView control
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inventoryView_Load(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportToExcel();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportToPdf();
        }
        private void ExportToPdf()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save PDF File";
                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        Document document = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        document.Open();

                        PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        // Add headers
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(dataGridView1.Columns[j].HeaderText));
                            cell.BackgroundColor = new BaseColor(240, 240, 240); // Light Gray
                            pdfTable.AddCell(cell);
                        }

                        // Add data
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(dataGridView1[k, i].Value?.ToString()));
                                pdfTable.AddCell(cell);
                            }
                        }

                        document.Add(pdfTable);
                        document.Close();

                        MessageBox.Show("PDF file saved successfully.", "Export to PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExportToExcel()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        // Create Excel application
                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                        excelApp.Workbooks.Add();

                        // Add a worksheet
                        Worksheet excelWorksheet = (Worksheet)excelApp.ActiveSheet;

                        // Column headings
                        for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                        {
                            excelWorksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                        }

                        // Data
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                excelWorksheet.Cells[i + 2, j + 1] = dataGridView1[j, i].Value?.ToString();
                            }
                        }

                        // Save the workbook
                        excelApp.ActiveWorkbook.SaveAs(saveFileDialog.FileName);
                        excelApp.ActiveWorkbook.Close();
                        excelApp.Quit();

                        MessageBox.Show("Excel file saved successfully.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
