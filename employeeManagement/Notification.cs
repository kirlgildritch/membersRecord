using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeManagement
{
    public class Notification
    {
        public string Message { get; set; }

        public Notification(string message)
        {
            Message = message;
        }


    }
}
