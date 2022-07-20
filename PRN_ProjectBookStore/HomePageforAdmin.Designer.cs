namespace PRN_ProjectBookStore
{
    partial class HomePageforAdmin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSignIn = new System.Windows.Forms.Button();
            this.btAllProducts = new System.Windows.Forms.Button();
            this.btSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRN_ProjectBookStore.Properties.Resources.anh_sach_800x451;
            this.pictureBox1.Location = new System.Drawing.Point(12, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 451);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.SystemColors.Control;
            this.btSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSignIn.Location = new System.Drawing.Point(881, 257);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(120, 50);
            this.btSignIn.TabIndex = 1;
            this.btSignIn.Text = "LogOut";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // btAllProducts
            // 
            this.btAllProducts.BackColor = System.Drawing.SystemColors.Control;
            this.btAllProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAllProducts.Location = new System.Drawing.Point(961, 362);
            this.btAllProducts.Name = "btAllProducts";
            this.btAllProducts.Size = new System.Drawing.Size(163, 50);
            this.btAllProducts.TabIndex = 3;
            this.btAllProducts.Text = "All Products";
            this.btAllProducts.UseVisualStyleBackColor = false;
            this.btAllProducts.Click += new System.EventHandler(this.btAllProducts_Click);
            // 
            // btSignUp
            // 
            this.btSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.btSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSignUp.Location = new System.Drawing.Point(1095, 257);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(120, 50);
            this.btSignUp.TabIndex = 4;
            this.btSignUp.Text = "Sign Up";
            this.btSignUp.UseVisualStyleBackColor = false;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // HomePageforAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.btAllProducts);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomePageforAdmin";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Button btAllProducts;
        private System.Windows.Forms.Button btSignUp;
    }
}