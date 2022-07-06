using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_ProjectBookStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();
            HomePage main = new HomePage();
            if (Username == string.Empty)
            {
                MessageBox.Show("Username not emty!");
            }
            if (Password == string.Empty)
            {
                MessageBox.Show("Password not emty!");
            }
            if (Username == txtUsername.Text && Password == txtPassword.Text)
            {
                this.Hide();
                main.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
