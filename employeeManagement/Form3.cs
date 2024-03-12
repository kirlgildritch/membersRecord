using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeManagement
{
    public partial class Form3 : Form
    {

        private Timer fadeTimer;
        private double opacityIncrement = 0.01;
        public Form3()
        {
            InitializeComponent();
            fadeTimer = new Timer();
            fadeTimer.Interval = 10000; // Set the interval in milliseconds
            fadeTimer.Tick += timer1_Tick;
            fadeTimer.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            this.Close();

            if (this.Opacity < 1.0)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                // Stop the timer once opacity reaches 1.0
                fadeTimer.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                // Stop the timer once opacity reaches 1.0
                fadeTimer.Stop();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
          
        }
    }
}
