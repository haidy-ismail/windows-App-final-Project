namespace userControl
{
    partial class frmProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.addProduct1 = new userControl.UserControlProduct.AddProduct();
            this.deleteProduct1 = new userControl.UserControlProduct.DeleteProduct();
            this.editProduct1 = new userControl.UserControlProduct.EditProduct();
            this.button4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(26, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 387);
            this.panel5.TabIndex = 23;
            // 
            // addProduct1
            // 
            this.addProduct1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addProduct1.Location = new System.Drawing.Point(279, 37);
            this.addProduct1.Name = "addProduct1";
            this.addProduct1.Size = new System.Drawing.Size(1034, 529);
            this.addProduct1.TabIndex = 24;
            // 
            // deleteProduct1
            // 
            this.deleteProduct1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteProduct1.Location = new System.Drawing.Point(327, 76);
            this.deleteProduct1.Name = "deleteProduct1";
            this.deleteProduct1.Size = new System.Drawing.Size(877, 409);
            this.deleteProduct1.TabIndex = 25;
            // 
            // editProduct1
            // 
            this.editProduct1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editProduct1.Location = new System.Drawing.Point(205, 40);
            this.editProduct1.Name = "editProduct1";
            this.editProduct1.Size = new System.Drawing.Size(1022, 493);
            this.editProduct1.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.BorderRadius = 20;
            this.button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button4.FillColor2 = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(20, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 48);
            this.button4.TabIndex = 27;
            this.button4.Text = "حذف";
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BorderRadius = 20;
            this.button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button3.FillColor2 = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(20, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 48);
            this.button3.TabIndex = 28;
            this.button3.Text = "تعديل";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BorderRadius = 20;
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.FillColor2 = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(20, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 48);
            this.button2.TabIndex = 29;
            this.button2.Text = "جديد";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.editProduct1);
            this.Controls.Add(this.deleteProduct1);
            this.Controls.Add(this.addProduct1);
            this.Controls.Add(this.panel5);
            this.Name = "frmProducts";
            this.Size = new System.Drawing.Size(1489, 533);
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private UserControlProduct.AddProduct addProduct1;
        private UserControlProduct.DeleteProduct deleteProduct1;
        private UserControlProduct.EditProduct editProduct1;
        private Guna.UI2.WinForms.Guna2GradientButton button4;
        private Guna.UI2.WinForms.Guna2GradientButton button2;
        private Guna.UI2.WinForms.Guna2GradientButton button3;
    }
}
