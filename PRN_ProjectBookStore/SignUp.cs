using PRN_ProjectBookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_ProjectBookStore
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public bool checkphone(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{9,11}$");
        }
        public bool checkAccount(string ac)//check username va password
        {
            return Regex.IsMatch(ac, "^[a-za-z0-9]{6,24}$");
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            PRN_BookStoreContext context = new PRN_BookStoreContext();
            string username = tbUsername.Text.Trim();
            string fullname = tbFullname.Text.Trim();
            string email = tbEmail.Text.Trim();
            string phonenumber = tbPhoneNumber.Text.Trim();
            string address = tbAddress.Text.Trim();
            string password = tbPassword.Text.Trim();
            string repassword = tbRePassword.Text.Trim();
            if (!checkAccount(username))
            {
                MessageBox.Show("username long time to 6-24 charater");
                return;
            }
            if (!checkAccount(password))
            {
                MessageBox.Show("password long time to 6-24 charater");
                return;
            }
            if (repassword != password)
            {
                MessageBox.Show("password and repassword must be the same");
                return;

            }
            if (!checkphone(phonenumber))
            {
                MessageBox.Show("please enter the correct phone number format 9-11 digits long");
                return;
            }
            Account a = new Account();
            a.Username = username;
            a.Password = password;
            a.Fullname = fullname;
            a.Email = email;
            a.Phone = phonenumber;
            a.Address = address;
            context.Accounts.Add(a);
            context.SaveChanges();
            MessageBox.Show("register successful!");
            SignUp su = new SignUp();
            su.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Hide();
            Login login =  new Login();
            login.Hide();
            login.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
