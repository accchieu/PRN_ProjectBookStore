namespace PRN_ProjectBookStore
{
    partial class HomePageForUser
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
            this.btSignUpUser = new System.Windows.Forms.Button();
            this.btAllProductsUser = new System.Windows.Forms.Button();
            this.btSignInUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btMyCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSignUpUser
            // 
            this.btSignUpUser.BackColor = System.Drawing.SystemColors.Control;
            this.btSignUpUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSignUpUser.Location = new System.Drawing.Point(946, 399);
            this.btSignUpUser.Name = "btSignUpUser";
            this.btSignUpUser.Size = new System.Drawing.Size(120, 50);
            this.btSignUpUser.TabIndex = 8;
            this.btSignUpUser.Text = "Sign Up";
            this.btSignUpUser.UseVisualStyleBackColor = false;
            this.btSignUpUser.Click += new System.EventHandler(this.btSignUpUser_Click);
            // 
            // btAllProductsUser
            // 
            this.btAllProductsUser.BackColor = System.Drawing.SystemColors.Control;
            this.btAllProductsUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAllProductsUser.Location = new System.Drawing.Point(922, 284);
            this.btAllProductsUser.Name = "btAllProductsUser";
            this.btAllProductsUser.Size = new System.Drawing.Size(163, 50);
            this.btAllProductsUser.TabIndex = 7;
            this.btAllProductsUser.Text = "All Products";
            this.btAllProductsUser.UseVisualStyleBackColor = false;
            this.btAllProductsUser.Click += new System.EventHandler(this.btAllProductsUser_Click);
            // 
            // btSignInUser
            // 
            this.btSignInUser.BackColor = System.Drawing.SystemColors.Control;
            this.btSignInUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSignInUser.Location = new System.Drawing.Point(862, 193);
            this.btSignInUser.Name = "btSignInUser";
            this.btSignInUser.Size = new System.Drawing.Size(120, 50);
            this.btSignInUser.TabIndex = 6;
            this.btSignInUser.Text = "LogOut";
            this.btSignInUser.UseVisualStyleBackColor = false;
            this.btSignInUser.Click += new System.EventHandler(this.btSignInUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRN_ProjectBookStore.Properties.Resources.anh_sach_800x451;
            this.pictureBox1.Location = new System.Drawing.Point(12, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 451);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btMyCart
            // 
            this.btMyCart.BackColor = System.Drawing.SystemColors.Control;
            this.btMyCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMyCart.Image = global::PRN_ProjectBookStore.Properties.Resources.giohang;
            this.btMyCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMyCart.Location = new System.Drawing.Point(1024, 193);
            this.btMyCart.Name = "btMyCart";
            this.btMyCart.Size = new System.Drawing.Size(120, 50);
            this.btMyCart.TabIndex = 9;
            this.btMyCart.Text = "My Cart";
            this.btMyCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMyCart.UseVisualStyleBackColor = false;
            this.btMyCart.Click += new System.EventHandler(this.btMyCart_Click);
            // 
            // HomePageForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btMyCart);
            this.Controls.Add(this.btSignUpUser);
            this.Controls.Add(this.btAllProductsUser);
            this.Controls.Add(this.btSignInUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomePageForUser";
            this.Text = "HomePageForUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSignUpUser;
        private System.Windows.Forms.Button btAllProductsUser;
        private System.Windows.Forms.Button btSignInUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btMyCart;
    }
}