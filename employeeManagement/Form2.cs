
using System;

using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Excel;

using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Text;



namespace employeeManagement
{
    public partial class Form2 : Form
    {
        public Form2()
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
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\kirlg\\OneDrive\\Desktop\\My Work\\Visual Studio 2022\\Daldesco\\membersRecord\\employeeManagement\\dataBank.mdf\";Integrated Security=True;Connect Timeout=30;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Members", con))
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

        private void Form2_Load_1(object sender, EventArgs e)
        {
            LoadDataIntoGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
           
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintData();
        }
        private void PrintData()
        {
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;

                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                {
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {


            try
            {
                int totalWidth = 0;
                int totalHeight = dataGridView1.Height;

                // Calculate the total width of the DataGridView
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    totalWidth += col.Width;
                }

                // Create a new bitmap with increased resolution
                using (Bitmap bitmap = new Bitmap(totalWidth, totalHeight))
                {
                    // Create a new Graphics object with increased resolution
                    using (Graphics highResGraphics = Graphics.FromImage(bitmap))
                    {
                        highResGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        highResGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        highResGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        highResGraphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                        // Auto-resize columns for better rendering
                        dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        // Draw the DataGridView content to the bitmap
                        dataGridView1.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, totalWidth, totalHeight));

                        // Rotate 90 degrees
                        bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);

                        // Calculate the position to center the content on the paper
                        int x = (e.MarginBounds.Width - bitmap.Width) / 2 + e.MarginBounds.Left;
                        int y = (e.MarginBounds.Height - bitmap.Height) / 2 + e.MarginBounds.Top;

                        // Draw the rotated and centered image onto the print document
                        e.Graphics.DrawImage(bitmap, x, y);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportToExcel();
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