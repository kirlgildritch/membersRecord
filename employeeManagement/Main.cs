using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeManagement
{
   
    //Baho tae
    public partial class Main : Form
    {
        List<Button> menu;
      
     
        private int TargetPosition = 12;
        private int AnimationSpeed = 4;
        private int currentIndex = 0;

       
        private bool isDragging = false;
        private int mouseX, mouseY;
        private Form1 form1;
        private Home home;
        private Inventory inventory;
     
        
        private Help help;
        public Main()
        {
            InitializeComponent();
       
            menu = new List<Button>() { homebtn,membersBtn,inventoryBtn};
            AttachmentMenuHandler(menu);

           
            form1 = new Form1();
            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(form1);
            form1.Hide();


            home = new Home();
            home.TopLevel = false;
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(home);
            home.Show();


            inventory = new Inventory();
            inventory.TopLevel = false;
            inventory.FormBorderStyle = FormBorderStyle.None;
            inventory.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(inventory);
            inventory.Hide();

         

            labelForAll.Text = "Home";
            SetActiveButton(homebtn);

          

            help = new Help(); 
            help.TopLevel = false;  
            help.FormBorderStyle = FormBorderStyle.None;
            help.Dock = DockStyle.Fill; 
            contentPanel.Controls.Add(help);
            help.Hide();
        }
        private void AttachmentMenuHandler(List<Button> menu)
        {
            foreach(var button in menu)
            {
             button.Hide();
                button.Left = -button.Width; // Set initial left position outside the visible area
              

            }
        }
       
     
        private void Main_Load(object sender, EventArgs e)
        {
            homebtn.FlatAppearance.BorderSize = 0;
            membersBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatAppearance.BorderSize = 0;
         
            helpBtn.FlatAppearance.BorderSize = 0;

        }

        private void homebtn_Click(object sender, EventArgs e)
        {

            home.Show();
        
            form1.Hide();
            help.Hide();
            inventory.Hide();
            SetActiveButton(homebtn);
            labelForAll.Text = "Home";
            panel2.Size = new System.Drawing.Size(107, panel2.Size.Width);
            panel3.Size = new System.Drawing.Size(98, panel3.Size.Width);
        }

        private void membersBtn_Click(object sender, EventArgs e)
        {
            panel2.Size = new System.Drawing.Size(250, panel2.Size.Width);
            panel3.Size = new System.Drawing.Size(240, panel3.Size.Width);
            home.Hide();
        
            form1.Show();
            inventory.Hide();
            help.Hide();
            SetActiveButton(membersBtn);
            labelForAll.Text = "Data Bank - Members";

            
        }

        private void labelForAll_Click(object sender, EventArgs e)
        {

        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            panel2.Size = new System.Drawing.Size(250, panel2.Size.Width);
            panel3.Size = new System.Drawing.Size(240, panel3.Size.Width);
            home.Hide();
            form1.Hide();
            inventory.Show();
            help.Hide();
         
            SetActiveButton(inventoryBtn);
            labelForAll.Text = "Data Bank - Inventory";

        }
        private void SetActiveButton(Button activeButton)
        {
            // Reset all buttons to default appearance
            homebtn.BackColor = Color.FromArgb(239, 244, 249);
            membersBtn.BackColor = Color.FromArgb(239, 244, 249);
            inventoryBtn.BackColor = Color.FromArgb(239, 244, 249);
           
            helpBtn.BackColor = Color.FromArgb(239, 244, 249);
            // Set the active button's appearance
            activeButton.BackColor = Color.FromArgb(242,242,242);
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
           
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button currentMenu = menu[currentIndex];

            if (currentMenu.Left < TargetPosition)
            {
                currentMenu.Left += AnimationSpeed;
                currentMenu.Show();
            }
            else if (currentMenu.Left > TargetPosition)
            {
                currentMenu.Left -= AnimationSpeed;
            }
            else
            {
                currentIndex++;
                if (currentIndex >= menu.Count)
                {
                    timer1.Stop();
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void labelAnimationTimer_Tick(object sender, EventArgs e)
        {

        }

       
        private void helpBtn_Click(object sender, EventArgs e)
        {
            home.Hide();
            form1.Hide();
            inventory.Hide();
           
            SetActiveButton(helpBtn);
            help.Show();
            labelForAll.Text = "Help";
            panel2.Size = new System.Drawing.Size(107, panel2.Size.Width);
            panel3.Size = new System.Drawing.Size(98, panel3.Size.Width);
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
      

            // Optionally, you can also update the notification count or icon on the notificationBtn
            // notificationBtn.Text = $"Notifications ({notifications.Count})";
        

    }
}
