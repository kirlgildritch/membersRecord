using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeManagement.Dialogs
{
    public partial class messageDialog : Form
    {
     
     int toastX, toastY;
        public messageDialog(string Message)

        {
            InitializeComponent();

            label1.Text = Message;
       
           
        this.FormBorderStyle = FormBorderStyle.None;
       
        }
     
      private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height + 5;

            this.Location = new Point(toastX, toastY);
        }

        private void messageDialog_Load(object sender, EventArgs e)
        {
            Position();
        }
        int y = 100;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if(y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if(toastY > 760)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if(toastY <= 800)
            {
                timer.Stop();
                toastHide.Start();
            }
        }
    }
}
