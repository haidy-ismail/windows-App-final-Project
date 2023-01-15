namespace userControl
{
    partial class FormSell
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
            this.addSell1 = new userControl.UserControlSell.AddSell();
            this.button1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // addSell1
            // 
            this.addSell1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addSell1.Location = new System.Drawing.Point(197, 23);
            this.addSell1.Name = "addSell1";
            this.addSell1.Size = new System.Drawing.Size(881, 550);
            this.addSell1.TabIndex = 1;
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(16, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "جديد";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addSell1);
            this.Name = "FormSell";
            this.Size = new System.Drawing.Size(1145, 551);
            this.Load += new System.EventHandler(this.FormSell_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlSell.AddSell addSell1;
        private Guna.UI2.WinForms.Guna2GradientButton button1;
    }
}
