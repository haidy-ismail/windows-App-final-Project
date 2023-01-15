namespace userControl.UserControlAccounts
{
    partial class DeleteAccount
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
            this.accNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAccounts = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // accNum
            // 
            this.accNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.accNum.Location = new System.Drawing.Point(230, 54);
            this.accNum.Name = "accNum";
            this.accNum.ReadOnly = true;
            this.accNum.Size = new System.Drawing.Size(172, 23);
            this.accNum.TabIndex = 40;
            this.accNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accNum_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(492, 60);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "رقم الحساب";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 261);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnShowAccounts
            // 
            this.btnShowAccounts.BorderRadius = 20;
            this.btnShowAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAccounts.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAccounts.FillColor2 = System.Drawing.Color.Gray;
            this.btnShowAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAccounts.ForeColor = System.Drawing.Color.Black;
            this.btnShowAccounts.Location = new System.Drawing.Point(402, 110);
            this.btnShowAccounts.Name = "btnShowAccounts";
            this.btnShowAccounts.Size = new System.Drawing.Size(180, 45);
            this.btnShowAccounts.TabIndex = 44;
            this.btnShowAccounts.Text = "عرض الحسابات";
            this.btnShowAccounts.Click += new System.EventHandler(this.btnShowAccounts_Click);
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
            this.button1.Location = new System.Drawing.Point(207, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 44;
            this.button1.Text = "حذف";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowAccounts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.accNum);
            this.Controls.Add(this.label9);
            this.Name = "DeleteAccount";
            this.Size = new System.Drawing.Size(803, 541);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox accNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowAccounts;
        private Guna.UI2.WinForms.Guna2GradientButton button1;
    }
}
