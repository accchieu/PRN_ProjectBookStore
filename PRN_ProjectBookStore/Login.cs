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
            
            PRN_BookStoreContext context = new PRN_BookStoreContext();
            if (Username == string.Empty && Password == string.Empty)
            {
                MessageBox.Show("try again");
            }

            var existUser = context.Accounts.FirstOrDefault(x => x.Username.Equals(txtUsername.Text));
                if (existUser != null && Username == "admin")
                {
                    if (Username == txtUsername.Text && Password == txtPassword.Text)
                    {
                        if (existUser.Password.Equals(txtPassword.Text))
                        {
                            HomePageforAdmin mainAdmin = new HomePageforAdmin();
                            this.Hide();
                            mainAdmin.Show();
                        }
                        else
                        {
                            MessageBox.Show("wrong password");
                        }


                    }


            }
            else
            {
                if (existUser != null)
                {


                    if (Username == txtUsername.Text && Password == txtPassword.Text)
                    {
                        if (existUser.Username.Equals(txtUsername.Text) && existUser.Password.Equals(txtPassword.Text))
                        {
                            HomePageForUser mainUser = new HomePageForUser();
                            this.Hide();
                            mainUser.Show();


                        }
                        else
                        {
                            MessageBox.Show("Password or Username are wrong");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Password or Username don't exist");
                }
            }
     
            }
                
        
            

           
        private void button2_Click(object sender, EventArgs e) //signUp
        {
            SignUp su = new SignUp();
            this.Hide();
            su.Show();
        }

        private void btHomePage_Click(object sender, EventArgs e)
        {
            HomePageforAdmin homePage = new HomePageforAdmin();
            this.Hide();
            homePage.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
