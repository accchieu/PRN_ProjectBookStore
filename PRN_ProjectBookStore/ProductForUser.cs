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
    public partial class ProductForUser : Form
    {
        public ProductForUser()
        {
            InitializeComponent();
        }


        List<Product> listP = new List<Product>();
        PRN_BookStoreContext context = new PRN_BookStoreContext();

        private void LoadDataGridView()
        {
            PRN_BookStoreContext context = new PRN_BookStoreContext();
            dataGridView1.DataSource = context.Products.ToList();
        }
        private static List<Product> GetProducts()
        {
            PRN_BookStoreContext context = new PRN_BookStoreContext();
            return (from p in context.Products select p).ToList();
        }



        private void ProductForUser_Load_1(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void tbsbName_KeyUp(object sender, KeyEventArgs e)
        {
            var lp = (from p in context.Products where p.Name.Contains(tbsbName.Text) select p).ToList();
            dataGridView1.DataSource = lp;
        }

        private void tbsbPID_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbsbPID.Text == "")
            {
                var lp = (from p in context.Products select p).ToList();
                dataGridView1.DataSource = lp;
            }
            else
            {
                var lp = (from p in context.Products where p.Pid == tbsbPID.Text.ToLower() select p).ToList();
                dataGridView1.DataSource = lp;
            }
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBox1.Text == "Literature")
            {
                var cat = (from p in context.Products where p.Catid == "cat1" select p).ToList();
                dataGridView1.DataSource = cat;
            }
            else if(comboBox1.Text == "Mystery")
            {
                var cat = (from p in context.Products where p.Catid == "cat2" select p).ToList();
                dataGridView1.DataSource = cat;
            }
            else if(comboBox1.Text == "Romance")
            {
                var cat = (from p in context.Products where p.Catid == "cat3" select p).ToList();
                dataGridView1.DataSource = cat;
            }
            else
            {
                var cat = (from p in context.Products select p).ToList();
                dataGridView1.DataSource = cat;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var cat = (from p in context.Products.OrderBy(s => s.Price) select p).ToList();
            dataGridView1.DataSource = cat;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cat = (from p in context.Products.OrderBy(s => s.Name) select p).ToList();
            dataGridView1.DataSource = cat;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Add To Cart")
            {

            }
        }

        








        //Tạo DataGridView
        //        DataGridView dgv = new DataGridView();
        //        dgv.Dock = DockStyle.Fill;
        //this.Controls.Add(dgv);

        ////Thêm một cột chứa button
        //DataGridViewButtonColumn bcm1 = new DataGridViewButtonColumn();
        //        dgv.Columns.Add(bcm1);

        ////Thêm dòng
        //dgv.Rows.Add("Nút nhân của cột 1 dòng 1");


        //private void tbsbname_keyup(object sender, keyeventargs e)
        //{
        //    var lp = (from p in context.products where p.name.contains(tbsbname.text.tolower()) select p).tolist();
        //    datagridview1.datasource = lp;
        //}
        //private void tbsbpid_keyup(object sender, keyeventargs e)
        //{
        //    if (tbsbpid.text == "")
        //    {
        //        var lp = (from p in context.products select p).tolist();
        //        datagridview1.datasource = lp;
        //    }
        //    else
        //    {
        //        var lp = (from p in context.products where p.pid == tbsbpid.text.tolower() select p).tolist();
        //        datagridview1.datasource = lp;
        //    }
        //}



    }
}
