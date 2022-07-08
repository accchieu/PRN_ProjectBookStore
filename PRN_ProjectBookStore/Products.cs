﻿using PRN_ProjectBookStore.Models;
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = context.Products.ToList();
        }
        private void Search_Load()
        {
            LoadDataGridView();
        }



        private void tbsbName_KeyUp(object sender, KeyEventArgs e)
        {
            var lp = (from p in context.Products where p.Name.Contains(tbsbName.Text.ToLower()) select p).ToList();
            dataGridView1.DataSource = lp;
        }

        private void tbsbPrice_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
