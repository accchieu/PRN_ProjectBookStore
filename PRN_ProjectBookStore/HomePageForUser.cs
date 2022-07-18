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
    public partial class HomePageForUser : Form
    {
        public HomePageForUser()
        {
            InitializeComponent();
        }

        private void btSignInUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.Hide();
        }

        private void btAllProductsUser_Click(object sender, EventArgs e)
        {
            ProductForUser p = new ProductForUser();
            p.Show();
            this.Hide();
        }

        private void btSignUpUser_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            signUp.Hide();
        }
    }
}
