using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Win32;

namespace EnjoyPlayer
{
    public partial class License : MetroForm
    {
        public License()
        {
            InitializeComponent();
        }
        #region License
        private void metroButton1_Click(object sender, EventArgs e)
        {
            LicenseCheck();
            //bunifuCustomLabel1.Text = checkMachineType().ToString();
        }
        public static bool checkMachineType()
        {
            RegistryKey winLogonKey = Registry.CurrentUser.OpenSubKey(@"Software\EnjoyStream", true);
            return (winLogonKey.GetValueNames().Contains("KEY"));
        }
        void LicenseCheck()
        {
            try
            {
                Form1 main = new Form1();
                RegistryKey license = Registry.CurrentUser.OpenSubKey(@"Software\EnjoyStream", false);
                var licensekey = license.GetValue("LICENSE").ToString();
                RegistryKey call = Registry.CurrentUser.OpenSubKey(@"Software\EnjoyStream", false);
                var callkey = call.GetValue("CALL").ToString();
                if (checkMachineType().ToString() == "True")
                {
                    RegistryKey winLogonKey = Registry.CurrentUser.OpenSubKey(@"Software\EnjoyStream", true);
                    var key = winLogonKey.GetValue("KEY").ToString();
                    if (licensekey.Equals(AesOperation.DecryptString(key, callkey).ToString()))
                    {
                        this.Hide();
                        main.Closed += (s, args) => this.Close();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid product key!\n (Bad license)!", "EnjoyStream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }
                else if (licensekey.Equals(AesOperation.DecryptString(keyinput.Text, callkey).ToString()))
                {
                    //WRITE THE KEY
                    RegistryKey winkey = Registry.CurrentUser.CreateSubKey(@"Software\EnjoyStream");
                    winkey.SetValue("KEY", keyinput.Text.ToString());
                    winkey.Close();
                    Hide();
                    main.Closed += (s, args) => this.Close();
                    main.Show();
                }
            }
            catch
            {
                MessageBox.Show("Invalid product key!\n", "EnjoyStream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        private void License_Shown_1(object sender, EventArgs e)
        {
            try
            {
                Form1 main = new Form1();
                RegistryKey license = Registry.CurrentUser.OpenSubKey(@"Software\EnjoyStream", false);
                var licensekey = license.GetValue("LICENSE").ToString();
                RegistryKey call = Registry.CurrentUser.OpenSubKey(@"Software\EnjoyStream", false);
                var callkey = call.GetValue("CALL").ToString();
                if (checkMachineType().ToString() == "True")
                {
                    RegistryKey winLogonKey = Registry.CurrentUser.OpenSubKey(@"Software\EnjoyStream", true);
                    var key = winLogonKey.GetValue("KEY").ToString();
                    if (licensekey.Equals(AesOperation.DecryptString(key, callkey).ToString()))
                    {
                        Hide();
                        main.Closed += (s, args) => this.Close();
                        main.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error! Please contact with the developer!\n", "EnjoyStream", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
