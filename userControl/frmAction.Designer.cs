namespace userControl
{
    partial class frmAction
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
            this.button4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.addAction1 = new userControl.AddAction();
            this.deleteAction1 = new userControl.DeleteAction();
            this.editAction1 = new userControl.EditAction();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(30, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 387);
            this.panel5.TabIndex = 22;
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
            this.button4.Location = new System.Drawing.Point(25, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 48);
            this.button4.TabIndex = 26;
            this.button4.Text = "حذف";
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button3.Location = new System.Drawing.Point(25, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 48);
            this.button3.TabIndex = 26;
            this.button3.Text = "تعديل";
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(25, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 48);
            this.button2.TabIndex = 26;
            this.button2.Text = "جديد";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addAction1
            // 
            this.addAction1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAction1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addAction1.Location = new System.Drawing.Point(228, 40);
            this.addAction1.Name = "addAction1";
            this.addAction1.Size = new System.Drawing.Size(806, 490);
            this.addAction1.TabIndex = 23;
            // 
            // deleteAction1
            // 
            this.deleteAction1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteAction1.Location = new System.Drawing.Point(248, 101);
            this.deleteAction1.Name = "deleteAction1";
            this.deleteAction1.Size = new System.Drawing.Size(786, 410);
            this.deleteAction1.TabIndex = 24;
            this.deleteAction1.Load += new System.EventHandler(this.deleteAction1_Load);
            // 
            // editAction1
            // 
            this.editAction1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editAction1.Location = new System.Drawing.Point(214, 24);
            this.editAction1.Name = "editAction1";
            this.editAction1.Size = new System.Drawing.Size(918, 487);
            this.editAction1.TabIndex = 25;
            this.editAction1.Load += new System.EventHandler(this.editAction1_Load);
            // 
            // frmAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.editAction1);
            this.Controls.Add(this.deleteAction1);
            this.Controls.Add(this.addAction1);
            this.Controls.Add(this.panel5);
            this.Name = "frmAction";
            this.Size = new System.Drawing.Size(1214, 571);
            this.Load += new System.EventHandler(this.frmAction_Load);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private AddAction addAction1;
        private DeleteAction deleteAction1;
        private EditAction editAction1;
        private Guna.UI2.WinForms.Guna2GradientButton button4;
        private Guna.UI2.WinForms.Guna2GradientButton button3;
        private Guna.UI2.WinForms.Guna2GradientButton button2;
    }
}
