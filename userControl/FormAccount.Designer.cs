namespace userControl
{
    partial class FormAccount
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
            this.addAccount1 = new userControl.UserControlAccounts.AddAccount();
            this.editAccount1 = new userControl.UserControlAccounts.EditAccount();
            this.deleteAccount1 = new userControl.UserControlAccounts.DeleteAccount();
            this.button1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // addAccount1
            // 
            this.addAccount1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAccount1.Location = new System.Drawing.Point(201, 16);
            this.addAccount1.Name = "addAccount1";
            this.addAccount1.Size = new System.Drawing.Size(753, 474);
            this.addAccount1.TabIndex = 13;
            // 
            // editAccount1
            // 
            this.editAccount1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editAccount1.Location = new System.Drawing.Point(210, 3);
            this.editAccount1.Name = "editAccount1";
            this.editAccount1.Size = new System.Drawing.Size(770, 518);
            this.editAccount1.TabIndex = 14;
            // 
            // deleteAccount1
            // 
            this.deleteAccount1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteAccount1.Location = new System.Drawing.Point(219, 16);
            this.deleteAccount1.Name = "deleteAccount1";
            this.deleteAccount1.Size = new System.Drawing.Size(803, 541);
            this.deleteAccount1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BorderRadius = 20;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor2 = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(28, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "جديد";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.button2.Location = new System.Drawing.Point(28, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "تعديل";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(28, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 45);
            this.button3.TabIndex = 16;
            this.button3.Text = "حذف";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteAccount1);
            this.Controls.Add(this.editAccount1);
            this.Controls.Add(this.addAccount1);
            this.Name = "FormAccount";
            this.Size = new System.Drawing.Size(1062, 582);
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlAccounts.AddAccount addAccount1;
        private UserControlAccounts.EditAccount editAccount1;
        private UserControlAccounts.DeleteAccount deleteAccount1;
        private Guna.UI2.WinForms.Guna2GradientButton button1;
        private Guna.UI2.WinForms.Guna2GradientButton button2;
        private Guna.UI2.WinForms.Guna2GradientButton button3;
    }
}
