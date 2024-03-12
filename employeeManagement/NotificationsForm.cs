using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using employeeManagement.Properties;
using System.Xml.Serialization;
namespace employeeManagement
{
    public partial class NotificationsForm : Form
    {
        private static NotificationsForm instance;

        public static NotificationsForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new NotificationsForm();
                }
                return instance;
            }
        }



        internal NotificationsForm()
        {
            InitializeComponent();
           
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {
           
        }
      

        private void btnMarkAllAsRead_Click(object sender, EventArgs e)
        {
          
      
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }


        public void AddNotification(Notification notification)
        {
            // Add your code here to display the notification in the form
            // For example, you can add the notification to a ListBox or use a custom control
            // You may also want to consider using a timer to automatically hide or remove notifications after a certain time
        }



        private void label_Click(object sender, EventArgs e)
        {

        }
      
      
    }
}
