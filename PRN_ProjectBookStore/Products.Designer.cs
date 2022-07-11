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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbsbName = new System.Windows.Forms.Label();
            this.btAllProduct = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbsbName = new System.Windows.Forms.TextBox();
            this.lbsbId = new System.Windows.Forms.Label();
            this.tbsbPID = new System.Windows.Forms.TextBox();
            this.lbsbPrice = new System.Windows.Forms.Label();
            this.tbsbPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.catidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(805, 547);
            this.dataGridView1.TabIndex = 0;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "Pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "Pid";
            this.pidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // catidDataGridViewTextBoxColumn
            // 
            this.catidDataGridViewTextBoxColumn.DataPropertyName = "Catid";
            this.catidDataGridViewTextBoxColumn.HeaderText = "Catid";
            this.catidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catidDataGridViewTextBoxColumn.Name = "catidDataGridViewTextBoxColumn";
            this.catidDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(PRN_ProjectBookStore.Models.Product);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PRN_ProjectBookStore.Models.Product);
            // 
            // lbsbName
            // 
            this.lbsbName.AutoSize = true;
            this.lbsbName.Location = new System.Drawing.Point(823, 213);
            this.lbsbName.Name = "lbsbName";
            this.lbsbName.Size = new System.Drawing.Size(114, 20);
            this.lbsbName.TabIndex = 2;
            this.lbsbName.Text = "Search by name";
            // 
            // btAllProduct
            // 
            this.btAllProduct.Location = new System.Drawing.Point(61, 74);
            this.btAllProduct.Name = "btAllProduct";
            this.btAllProduct.Size = new System.Drawing.Size(94, 29);
            this.btAllProduct.TabIndex = 3;
            this.btAllProduct.Text = "All Product";
            this.btAllProduct.UseVisualStyleBackColor = true;
            this.btAllProduct.Click += new System.EventHandler(this.btAllProduct_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(518, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tbsbName
            // 
            this.tbsbName.Location = new System.Drawing.Point(977, 210);
            this.tbsbName.Name = "tbsbName";
            this.tbsbName.Size = new System.Drawing.Size(193, 27);
            this.tbsbName.TabIndex = 7;
            this.tbsbName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbsbName_KeyUp);
            // 
            // lbsbId
            // 
            this.lbsbId.AutoSize = true;
            this.lbsbId.Location = new System.Drawing.Point(823, 270);
            this.lbsbId.Name = "lbsbId";
            this.lbsbId.Size = new System.Drawing.Size(148, 20);
            this.lbsbId.TabIndex = 8;
            this.lbsbId.Text = "Search by product ID";
            // 
            // tbsbPID
            // 
            this.tbsbPID.Location = new System.Drawing.Point(977, 267);
            this.tbsbPID.Name = "tbsbPID";
            this.tbsbPID.Size = new System.Drawing.Size(193, 27);
            this.tbsbPID.TabIndex = 9;
            this.tbsbPID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbsbPID_KeyUp);
            // 
            // lbsbPrice
            // 
            this.lbsbPrice.AutoSize = true;
            this.lbsbPrice.Location = new System.Drawing.Point(823, 331);
            this.lbsbPrice.Name = "lbsbPrice";
            this.lbsbPrice.Size = new System.Drawing.Size(110, 20);
            this.lbsbPrice.TabIndex = 10;
            this.lbsbPrice.Text = "Search by price";
            // 
            // tbsbPrice
            // 
            this.tbsbPrice.Location = new System.Drawing.Point(977, 328);
            this.tbsbPrice.Name = "tbsbPrice";
            this.tbsbPrice.Size = new System.Drawing.Size(193, 27);
            this.tbsbPrice.TabIndex = 11;
            this.tbsbPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbsbPrice_KeyUp);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tbsbPrice);
            this.Controls.Add(this.lbsbPrice);
            this.Controls.Add(this.tbsbPID);
            this.Controls.Add(this.lbsbId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbsbName);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btAllProduct);
            this.Controls.Add(this.lbsbName);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label lbsbName;
        private System.Windows.Forms.Button btAllProduct;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbsbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Label lbsbId;
        private System.Windows.Forms.TextBox tbsbPID;
        private System.Windows.Forms.Label lbsbPrice;
        private System.Windows.Forms.TextBox tbsbPrice;
    }
}