using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class Form2 : Form
    {
        bool logonStatus = false;
        string userName = "Teacher";
        string pass = "Admin";
        public Form2()
        {
            InitializeComponent();
        }

        private void LogonBtn_Click(object sender, EventArgs e)
        {
            if (userIdtextbox.Text == "Teacher" && passwordtextbox.Text == "Admin")
            {
                logonStatus = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("User Id and Password incorrect. Try again.");
            }
        }
    }
}
