using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
namespace employeeManagement
{

    public partial class Home : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DatabaseDal;Integrated Security=True;TrustServerCertificate=True";



        public Home()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start(); // Start the timer
            DoubleBuffered = true; // Enable double buffering

           

        }

        private void Home_Load(object sender, EventArgs e)
        {
       LoadChartData();
            LoadPieChartData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadChartData()
        {
            SuspendLayout(); // Suspend layout updates

            try
            {
               

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Inventory"; // Adjust your query as needed

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing series before adding new data
                            chart1.Series.Clear();

                            // Create a new series
                            Series series = new Series("InventoryData");
                            series.ChartType = SeriesChartType.Column; // Set the chart type to Column

                            int totalStocksOverall = 0;
                            int totalPrice = 0;
                            Dictionary<string, int> categoryStocks = new Dictionary<string, int>();

                            while (reader.Read())
                            {
                                // Assuming you have three columns in your Inventory table: Name, Category, and Quantity
                                string category = reader["specification"].ToString();
                                int quantity = Convert.ToInt32(reader["Price"]);
                                int ins = Convert.ToInt32(reader["in"]);

                                totalStocksOverall += ins;
                                totalPrice += quantity;

                                // Add the 'ins' value to the chart
                                DataPoint dataPoint = new DataPoint();
                                dataPoint.SetValueY(ins);
                                dataPoint.AxisLabel = category; // Assuming 'category' is the label for the X-axis

                                series.Points.Add(dataPoint);
                            }

                            chart1.Series.Add(series);

                            // ... (rest of the code remains unchanged)

                            // Update labels accordingly
                            totalStocksOveralls.Text = $"{totalStocksOverall}";
                            totalStockPerCategory.Text = $"{totalPrice:C}";

                            decimal totalShareCapital = CalculateTotalShareCapital();
                            label11.Text = $"{totalShareCapital:C}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                ResumeLayout();
            }
        }

        private decimal CalculateTotalShareCapital()
        {
            decimal totalShareCapital = 0;

            try
            {
              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ShareCapital FROM Members"; // Adjust your query as needed

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal shareCapital = Convert.ToDecimal(reader["ShareCapital"]);
                                totalShareCapital += shareCapital;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total share capital: {ex.Message}");
            }

            return totalShareCapital;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
             LoadChartData();
                LoadPieChartData();
            
        }
      
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoadPieChartData()
        {
            SuspendLayout(); // Suspend layout updates

            // Initialize totals
            int totalMale = 0;
            int totalFemale = 0;

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Gender, COUNT(*) as Count FROM Members GROUP BY Gender"; // Modify the query as needed

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        // Clear existing series before adding new data
                        pieChart.Series.Clear();

                        // Create a new series
                        Series series = new Series("GenderData");
                        series.ChartType = SeriesChartType.Pie; // Set the chart type to Pie
                        series["PieLabelStyle"] = "Outside"; // Display labels outside the pie

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string gender = reader["Gender"].ToString();
                                int count = Convert.ToInt32(reader["Count"]);

                                // Add data points to the series
                                DataPoint dataPoint = new DataPoint();
                                dataPoint.SetValueY(count);
                                dataPoint.AxisLabel = gender; // Set AxisLabel to Gender

                                series.Points.Add(dataPoint);

                                // Update total counts
                                if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                                    totalMale += count;
                                else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                                    totalFemale += count;
                            }
                        }

                        // Add the series to the chart
                        pieChart.Series.Add(series);

                        // Set chart title with total counts
                        pieChart.Titles.Clear();
                        pieChart.Titles.Add("Members Data");
                        pieChart.Titles[0].Font = new Font("Arial", 10, FontStyle.Bold);
                        pieChart.Titles[0].ForeColor = Color.White;
                        // Adjust legend properties
                        pieChart.Legends[0].Enabled = true;
                        pieChart.Legends[0].Docking = Docking.Right;
                        pieChart.Legends[0].LegendStyle = LegendStyle.Column;

                        // Set chart background to a light color
                   
                    

                        // Set rounded corners

                        // Apply a modern theme
                        pieChart.ApplyPaletteColors();
                        pieChart.Palette = ChartColorPalette.Pastel;

                        pieChart.ChartAreas[0].BackColor = Color.Transparent;
                        // Adjust chart area style

                        // Set pie chart to 3D
                        pieChart.ChartAreas[0].Area3DStyle.Enable3D = true;


                    }
                }

                // Display counts below the chart
                totalMaleLabel.Text = $"{totalMale}";
                totalFemaleLabel.Text = $"{totalFemale}";
                overallTotalLabel.Text = $"{totalMale + totalFemale}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                ResumeLayout();
            }
          
        }


        // Additional chart settings...
      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scrollTimer_Tick(object sender, EventArgs e)
        {
      
        }

        private void pieChart_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(250, 250, 250);
            panel10.BackColor = Color.FromArgb(240, 240, 240);
          
            
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor= Color.White;
           
            panel10.BackColor = Color.FromArgb(237, 237, 237);
          
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(250, 250, 250);
            panel11.BackColor = Color.FromArgb(240, 240, 240);
          
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
       
            panel11.BackColor = Color.FromArgb(237, 237, 237);
           
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(250, 250, 250);
            panel12.BackColor = Color.FromArgb(240, 240, 240);
          
          
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {

            panel7.BackColor = Color.White;
         
            panel12.BackColor = Color.FromArgb(237,237,237);
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.White;
          
            panel13.BackColor = Color.FromArgb(237,237,237);
           
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(250,250,250);
            panel13.BackColor = Color.FromArgb(240,240,240);
         
           
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            panel14.BackColor = Color.FromArgb(250, 250, 250);
            panel15.BackColor = Color.FromArgb(240, 240, 240);
         
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.White;
         
            panel15.BackColor = Color.FromArgb(237,237,237);
           
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(250,250,250);
           
            chart1.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
            chart1.BackColor = Color.White;
           
        }

        private void chart1_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(250,250,250);

            chart1.BackColor = Color.FromArgb(250,250,250);
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
            chart1.BackColor = Color.White;
        }

        private void pieChart_MouseEnter(object sender, EventArgs e)
        {
            pieChart.BackColor = Color.FromArgb(250, 250, 250);

            panel8.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void pieChart_MouseLeave(object sender, EventArgs e)
        {
            pieChart.BackColor = Color.White;
            panel8.BackColor = Color.White;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(250, 250, 250);
            panel3.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.FromArgb(237, 237, 237);
        }

    }
    
}
