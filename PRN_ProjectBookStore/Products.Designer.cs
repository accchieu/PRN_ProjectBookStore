namespace PRN_ProjectBookStore
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbsbName = new System.Windows.Forms.Label();
            this.tbsbName = new System.Windows.Forms.TextBox();
            this.lbsbPrice = new System.Windows.Forms.Label();
            this.tbsbPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pid,
            this.Name,
            this.description,
            this.price,
            this.quantity,
            this.catid});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(903, 729);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pid
            // 
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "pid";
            this.pid.MinimumWidth = 6;
            this.pid.Name = "pid";
            this.pid.Width = 125;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // catid
            // 
            this.catid.DataPropertyName = "catid";
            this.catid.HeaderText = "catid";
            this.catid.MinimumWidth = 6;
            this.catid.Name = "catid";
            this.catid.Width = 125;
            // 
            // lbsbName
            // 
            this.lbsbName.AutoSize = true;
            this.lbsbName.Location = new System.Drawing.Point(1032, 12);
            this.lbsbName.Name = "lbsbName";
            this.lbsbName.Size = new System.Drawing.Size(172, 20);
            this.lbsbName.TabIndex = 1;
            this.lbsbName.Text = "Search Product By Name";
            // 
            // tbsbName
            // 
            this.tbsbName.Location = new System.Drawing.Point(921, 52);
            this.tbsbName.Name = "tbsbName";
            this.tbsbName.Size = new System.Drawing.Size(349, 27);
            this.tbsbName.TabIndex = 2;
            this.tbsbName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbsbName_KeyUp);
            // 
            // lbsbPrice
            // 
            this.lbsbPrice.AutoSize = true;
            this.lbsbPrice.Location = new System.Drawing.Point(1048, 148);
            this.lbsbPrice.Name = "lbsbPrice";
            this.lbsbPrice.Size = new System.Drawing.Size(109, 20);
            this.lbsbPrice.TabIndex = 3;
            this.lbsbPrice.Text = "Search By Price";
            // 
            // tbsbPrice
            // 
            this.tbsbPrice.Location = new System.Drawing.Point(921, 202);
            this.tbsbPrice.Name = "tbsbPrice";
            this.tbsbPrice.Size = new System.Drawing.Size(349, 27);
            this.tbsbPrice.TabIndex = 4;
            this.tbsbPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbsbPrice_KeyUp);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbsbPrice);
            this.Controls.Add(this.lbsbPrice);
            this.Controls.Add(this.tbsbName);
            this.Controls.Add(this.lbsbName);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbsbName;
        private System.Windows.Forms.TextBox tbsbName;
        private System.Windows.Forms.Label lbsbPrice;
        private System.Windows.Forms.TextBox tbsbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn catid;
    }
}