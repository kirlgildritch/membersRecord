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
    public partial class Settings : Form
    {
        public event EventHandler<bool> NotificationPreferenceChanged;
        private bool isNotificationPreferenceOn;
        public Settings()
        {
            InitializeComponent();
            isNotificationPreferenceOn = false;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

     
        private void notificationPreference_CheckedChanged(object sender, EventArgs e)
        {
            isNotificationPreferenceOn = notificationPreference.Checked;
            NotificationPreferenceChanged?.Invoke(this, isNotificationPreferenceOn);
        }

        private void auditTrail_CheckedChanged(object sender, EventArgs e)
        {

        }
        public bool GetNotificationPreference()
        {
            return isNotificationPreferenceOn;
        }
      
    }
}
