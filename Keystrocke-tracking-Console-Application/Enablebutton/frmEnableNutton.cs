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
//Important to handle files
using System.IO;


namespace Enablebutton
{
    //07.04.2020
    //Vasil Paskalev
    //Run the KeyStrockeTracker Console on Windows startup
    
    public partial class frmEnableButton : Form
    {           
        public frmEnableButton()
        {
            InitializeComponent();
        }

        private void cmdEnable_Click(object sender, EventArgs e)
        {
            //Making the ConsoleApp KeyStrockeTracker Windows-startup-app
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("KeyStrockeTracker", @"C:\Users\vasil\source\repos\Key-tracking-Console\Keystrocke-tracking-Console-Application\KeyStrockeTracker\bin\Debug\netcoreapp3.1\KeyStrockeTracker.exe");
        }
    }
}
