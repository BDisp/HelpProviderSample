using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetDefaultBrowser()
        {
            string browserName = "msedge.exe";
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        if (progIdValue.ToString().Contains("chrome", StringComparison.OrdinalIgnoreCase))
                            browserName = "chrome.exe";
                        else if (progIdValue.ToString().Contains("firefox", StringComparison.OrdinalIgnoreCase))
                            browserName = "firefox.exe";
                        else if (progIdValue.ToString().Contains("safari", StringComparison.OrdinalIgnoreCase))
                            browserName = "safari.exe";
                        else if (progIdValue.ToString().Contains("opera", StringComparison.OrdinalIgnoreCase))
                            browserName = "opera.exe";
                    }
                }
            }

            return browserName;
        }

        private void OpenHelpBrowser(string hash)
        {
            var defautBrowser = GetDefaultBrowser();
            var url = $@"{"file:///"}{Environment.CurrentDirectory}\..\..\..\..\HelpProviderChmSample\Contents\main.htm#{hash}";
            Process.Start(new ProcessStartInfo { FileName = defautBrowser, Arguments = url, UseShellExecute = true });
        }

        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                OpenHelpBrowser("address");
            }
        }

        private void cityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                OpenHelpBrowser("city");
            }
        }

        private void stateTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                OpenHelpBrowser("state");
            }
        }

        private void zipTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                OpenHelpBrowser("zip");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Help.ShowHelp(this, helpProvider1.HelpNamespace);
            }
            else if (e.KeyCode == Keys.F4)
            {
                OpenHelpBrowser("");
            }
        }
    }
}
