using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Important for handling events that manipulate the system registry
using Microsoft.Win32;
//Important to handle files and directories
using System.IO;

namespace Remove_Button
{
    //07.04.2020
    //Vasil Paskalev
    //Button for removing Console from Windows startup
    
    public partial class frmRemoveButton : Form
    {
        public frmRemoveButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Removing the Console from Windows startup
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.DeleteValue("KeyStrockeTracker", false);
        }
    }
}
