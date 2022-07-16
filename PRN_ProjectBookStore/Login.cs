using PRN_ProjectBookStore.Models;
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
            PRN_BookStoreContext context = new PRN_BookStoreContext();
            if (Username == string.Empty && Password == string.Empty)
            {
                MessageBox.Show("try again");
            }
            var existUser = context.Accounts.FirstOrDefault(x => x.Username.Equals(txtUsername.Text));
            if (existUser != null)
            {
                if (Username == txtUsername.Text && Password == txtPassword.Text)
                {
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("User name or password mismath");
                }
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            this.Hide();
            su.Show();
        }

        private void btHomePage_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
