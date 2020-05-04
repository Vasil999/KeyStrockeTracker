using Microsoft.Win32;
using System;

namespace Keystrocke_tracking_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        }
    }
}
