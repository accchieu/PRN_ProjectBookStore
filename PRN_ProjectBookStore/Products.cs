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
    public partial class Products : Form
    {
        List<Product> listP = new List<Product>();
        PRN_BookStoreContext context = new PRN_BookStoreContext();
        public Products()
        {
            InitializeComponent();
        }
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
        private void Products_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        //private void btAllProduct_Click(object sender, EventArgs e)
        //{
        //    var lp = (from p in context.Products select p).ToList();
        //    dataGridView1.DataSource = lp;
        //}
        private void tbsbName_KeyUp(object sender, KeyEventArgs e)
        {
            var lp = (from p in context.Products where p.Name.Contains(tbsbName.Text.ToLower()) select p).ToList();
            dataGridView1.DataSource = lp;
        }
        private void tbsbPID_KeyUp(object sender, KeyEventArgs e)
        {
            var lp = (from p in context.Products where p.Pid == tbsbPID.Text.ToLower() select p).ToList();
            dataGridView1.DataSource = lp;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            btUpdate.Enabled = true;
            btDelete.Enabled = true;

            var check = context.Products.FirstOrDefault(x => x.Pid == tbPid.Text);
            if (check != null)
            {
                MessageBox.Show(" Id already exists");
                return;
            }
            else
            {
                Product p = new Product();
                p.Pid = tbPid.Text;
                p.Name = tbName.Text;
                p.Description = tbDescription.Text;
                p.Price = Convert.ToDouble(tbPrice.Text);
                p.Quantity = Convert.ToInt32(tbQuantity.Text);
                p.Catid = tbCatId.Text;
                p.Image = "aaa";



                context.Products.Add(p);
                context.SaveChanges();
                LoadDataGridView();
                ResetValue();
                MessageBox.Show("Add successfull");
                tbPid.Enabled = true;
            }


            //PRN_BookStoreContext context = new PRN_BookStoreContext();
            //Product p = new Product() { Pid = tbPid.Text, Name = tbName.Text, Description = tbDescription.Text, Price = Convert.ToDouble(tbPrice.Text), Quantity = Convert.ToInt32(tbQuantity.Text), Catid = "cat1", Image="aaa" };
            //context.Products.Add(p);

            //context.SaveChanges();
            //LoadDataGridView();
        }
        private void ResetValue()
        {
            tbPid.Text = "";
            tbName.Text = "";
            tbDescription.Text = "";
            tbPrice.Text = "";
            tbQuantity.Text = "";
            tbCatId.Text = "";

        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            Product product = context.Products.FirstOrDefault(p => p.Pid == tbPid.Text);
            product.Name = tbName.Text;
            product.Description = tbDescription.Text;
            product.Price = Convert.ToDouble(tbPrice.Text);
            product.Quantity = Convert.ToInt32(tbQuantity.Text);
            
            context.SaveChanges();
            LoadDataGridView();
            ResetValue();
            MessageBox.Show("Update successfull");
            tbPid.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btAdd.Enabled = true;
            tbPid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbQuantity.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbCatId.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbPid.Enabled = false;
            

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = true;
            btUpdate.Enabled = true;
            if (tbPid.Text.Trim() == "")
            {
                MessageBox.Show("You have not selected a record", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (MessageBox.Show("Do you want to delete this data?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = context.Products.Single(x => x.Pid == tbPid.Text);
                context.Products.Remove(result);
                context.SaveChanges();
                LoadDataGridView();
                ResetValue();
                tbPid.Enabled = true;
            }
        }



        //private void UpdateDataGrid()
        //{
        //    dataGridView1.Columns["Pid"].DataPropertyName = "Pid";
        //    dataGridView1.Columns["Name"].DataPropertyName = "Name";
        //    dataGridView1.Columns["Description"].DataPropertyName = "Description";
        //    dataGridView1.Columns["Price"].DataPropertyName = "Price";
        //    dataGridView1.Columns["Quantity"].DataPropertyName = "Quantity";
        //    dataGridView1.Columns["Cart"].ReadOnly = true;
        //    dataGridView1.Columns["Bills"].ReadOnly = true;
        //    dataGridView1.DataSource = GetProducts();
        //}

        ////private Product GetProductInfo()
        ////{
        ////    Product p = new Product();
        ////    p.Pid = tbPid.Text;
        ////    p.Name = tbName.Text;
        ////    p.Description = tbDescription.Text;
        ////    p.Price = Convert.ToDouble(tbPrice.Text);
        ////    p.Quantity = Convert.ToInt32(tbPrice.Text);
        ////    return p;

        ////}

        //public static void EditProduct(Product p)
        //{
        //    List<Product> listP = new List<Product>();
        //    PRN_BookStoreContext context = new PRN_BookStoreContext();
        //    foreach (Product product in listP)
        //    {
        //        product.Pid = p.Pid;
        //        product.Name = p.Name;
        //        product.Description = p.Description;
        //        product.Price = Convert.ToDouble(p.Price);
        //        product.Quantity = Convert.ToInt32(p.Quantity);

        //    }
        //    context.SaveChanges();
        //}

        //private void btAdd_Click(object sender, EventArgs e)
        //{
        //    PRN_BookStoreContext context = new PRN_BookStoreContext();
        //    Product p = new Product() {Pid = tbPid.Text, Name = tbName.Text, Description = tbDescription.Text, Price = Convert.ToDouble(tbPid.Text), Quantity = Convert.ToInt32(tbQuantity.Text) };
        //    context.Products.Add(p);

        //    context.SaveChanges();
        //    LoadDataGridView();

        //}

        //private void btUpdate_Click(object sender, EventArgs e)
        //{

        //}

        //private void btDelete_Click(object sender, EventArgs e)
        //{
        //    PRN_BookStoreContext context = new PRN_BookStoreContext();
        //    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        //    {
        //        string Pid = Convert.ToString(row.Cells[0].Value);
        //        Product p = context.Products.FirstOrDefault(x => x.Pid == Pid);
        //        context.Products.Remove(p);
        //    }

        //    context.SaveChanges();
        //    LoadDataGridView();
        //}


        //private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    Product change = new Product();
        //    if (dataGridView1.CurrentCell != null)
        //    {
        //        Product p = new Product();
        //        DataGridViewRow row = dataGridView1.CurrentRow;
        //        change.Pid = row.Cells["pid"].Value.ToString();
        //        change.Name = row.Cells["Name"].Value.ToString();
        //        change.Description = row.Cells["Description"].Value.ToString();
        //        change.Price = Convert.ToDouble(row.Cells["Price"].Value.ToString());
        //        change.Quantity = Convert.ToInt32(row.Cells["Quamtity"].Value.ToString());
        //    }
        //    string message = $"Do you want update Product {change.Pid}";
        //    string title = "Update";
        //    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        //    DialogResult result = MessageBox.Show(message, title, buttons);
        //    if (result == DialogResult.Yes)
        //    {

        //        EditProduct(change);
        //        MessageBox.Show("Update successfully!");

        //    }
        //    UpdateDataGrid();


        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int rowClickedIndex;
        //    rowClickedIndex = e.RowIndex;
        //    DataGridViewRow row = dataGridView1.Rows[rowClickedIndex];
        //    MessageBox.Show(row.Cells["Pid"].Value.ToString());
        //}

        //private void btnAllProducts_Product_Click(object sender, EventArgs e)
        //{
        //    var lp = (from p in context.Products select p).ToList();
        //        dataGridView1.DataSource = lp;
        //}
    }
}
