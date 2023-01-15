namespace userControl
{
    partial class frmSafe
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
            this.btnDeleteSafe = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteSafe1 = new userControl.UserControlSafe.DeleteSafe();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.btnDeleteSafe);
            this.panel5.Location = new System.Drawing.Point(29, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 387);
            this.panel5.TabIndex = 23;
            // 
            // btnDeleteSafe
            // 
            this.btnDeleteSafe.BorderRadius = 20;
            this.btnDeleteSafe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSafe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteSafe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteSafe.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteSafe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteSafe.FillColor2 = System.Drawing.Color.Gray;
            this.btnDeleteSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSafe.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSafe.Location = new System.Drawing.Point(19, 226);
            this.btnDeleteSafe.Name = "btnDeleteSafe";
            this.btnDeleteSafe.Size = new System.Drawing.Size(153, 48);
            this.btnDeleteSafe.TabIndex = 27;
            this.btnDeleteSafe.Text = "حذف";
            this.btnDeleteSafe.Click += new System.EventHandler(this.btnDeleteSafe_Click_1);
            // 
            // deleteSafe1
            // 
            this.deleteSafe1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteSafe1.Location = new System.Drawing.Point(243, 51);
            this.deleteSafe1.Name = "deleteSafe1";
            this.deleteSafe1.Size = new System.Drawing.Size(933, 496);
            this.deleteSafe1.TabIndex = 25;
            // 
            // frmSafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.deleteSafe1);
            this.Controls.Add(this.panel5);
            this.Name = "frmSafe";
            this.Size = new System.Drawing.Size(1362, 571);
            this.Load += new System.EventHandler(this.frmSafe_Load);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        //private UserControlSafe.EditSafe editSafe1;
        private UserControlSafe.DeleteSafe deleteSafe1;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteSafe;
    }
}
