namespace userControl.UserControlProduct
{
    partial class AddProduct
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buyingBoxAdd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.categioryAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sellingPriceAdd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.countityAdd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.productNameAdd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button2 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(905, -27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "سعر الشراء";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(741, -27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "التصنيف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(487, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 67;
            this.label8.Text = "الفئه";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "مفروشات",
            "اجهزة كهربائية",
            "أدوات منزليه"});
            this.comboBox1.Location = new System.Drawing.Point(204, 127);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 34);
            this.comboBox1.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(771, 292);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 61;
            this.label11.Text = "سعر الشراء";
            // 
            // buyingBoxAdd
            // 
            this.buyingBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyingBoxAdd.Location = new System.Drawing.Point(539, 286);
            this.buyingBoxAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buyingBoxAdd.Name = "buyingBoxAdd";
            this.buyingBoxAdd.Size = new System.Drawing.Size(198, 32);
            this.buyingBoxAdd.TabIndex = 60;
            this.buyingBoxAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProduct_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(781, 363);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "التصنيف";
            // 
            // categioryAdd
            // 
            this.categioryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categioryAdd.Location = new System.Drawing.Point(539, 352);
            this.categioryAdd.Margin = new System.Windows.Forms.Padding(2);
            this.categioryAdd.Name = "categioryAdd";
            this.categioryAdd.Size = new System.Drawing.Size(198, 32);
            this.categioryAdd.TabIndex = 57;
            this.categioryAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productNameAdd_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(776, 164);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 56;
            this.label13.Text = "سعر البيع";
            // 
            // sellingPriceAdd
            // 
            this.sellingPriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingPriceAdd.Location = new System.Drawing.Point(540, 158);
            this.sellingPriceAdd.Margin = new System.Windows.Forms.Padding(2);
            this.sellingPriceAdd.Name = "sellingPriceAdd";
            this.sellingPriceAdd.Size = new System.Drawing.Size(198, 32);
            this.sellingPriceAdd.TabIndex = 55;
            this.sellingPriceAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProduct_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(798, 226);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 54;
            this.label14.Text = "الكميه";
            // 
            // countityAdd
            // 
            this.countityAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countityAdd.Location = new System.Drawing.Point(539, 220);
            this.countityAdd.Margin = new System.Windows.Forms.Padding(2);
            this.countityAdd.Name = "countityAdd";
            this.countityAdd.Size = new System.Drawing.Size(198, 32);
            this.countityAdd.TabIndex = 53;
            this.countityAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProduct_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(765, 107);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 52;
            this.label15.Text = "أسم الصنف";
            // 
            // productNameAdd
            // 
            this.productNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameAdd.Location = new System.Drawing.Point(540, 96);
            this.productNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.productNameAdd.Name = "productNameAdd";
            this.productNameAdd.Size = new System.Drawing.Size(198, 32);
            this.productNameAdd.TabIndex = 51;
            this.productNameAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productNameAdd_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(254, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // add
            // 
            this.add.BorderRadius = 20;
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.FillColor2 = System.Drawing.Color.Gray;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Location = new System.Drawing.Point(168, 228);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 45);
            this.add.TabIndex = 71;
            this.add.Text = "إضافة منتج";
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.button2.Location = new System.Drawing.Point(557, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 45);
            this.button2.TabIndex = 71;
            this.button2.Text = "إضافة صورة";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buyingBoxAdd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.categioryAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sellingPriceAdd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.countityAdd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.productNameAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(1034, 529);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddProduct_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox buyingBoxAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox categioryAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sellingPriceAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox countityAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox productNameAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton add;
        private Guna.UI2.WinForms.Guna2GradientButton button2;
    }
}
