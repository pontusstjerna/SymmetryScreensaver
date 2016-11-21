using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymmetryScreensaver
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            
            LoadSettings();
        }

        private void SaveSettings()
        {
            //Create or get existing Registry subkey
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SymmetryScreensaver");

            key.SetValue("thickness", (float)(thicknessBar.Value/100.0f));
            string value = colourDropdown.Text;
            if (!value.Equals("Select colour"))
                key.SetValue("colour", value.ToUpper());
        }

        private void LoadSettings()
        {
            //Get value stored in registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SymmetryScreensaver");
            if(key == null)
            {
                thicknessBar.Value = 5;
            }
            else
            {
                int thickness = (int)((float.Parse((string)key.GetValue("thickness"))) * 100);
                if(thickness < thicknessBar.Minimum)
                {
                    thickness = thicknessBar.Minimum;
                }else if(thickness > thicknessBar.Maximum)
                {
                    thickness = thicknessBar.Maximum;
                }
                thicknessBar.Value = thickness;
                //Get string value and make First Letter Capital, the rest lower
                object value = key.GetValue("colour");
                if(value != null)
                    colourDropdown.Text = FirstCharToUpper(((string)value).ToLower());
            }
        }

        private string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                MessageBox.Show("Oops, something went terribly wrong!", "Symmetry Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void websiteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("http://www.pontek.se");
            System.Diagnostics.Process.Start(sInfo);
        }
    }
}
