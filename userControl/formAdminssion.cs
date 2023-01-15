using System;
using System.Drawing;
using System.Windows.Forms;

namespace userControl
{
    public partial class formAdminssion : Form
    {
        public formAdminssion()
        {
            InitializeComponent();
        }

        private void formAdminssion_Load(object sender, EventArgs e)
        {
            button2.BackColor = Color.Navy;
            this.FormBorderStyle = FormBorderStyle.None;
            frmAction2.Hide();
            fromInvoice1.Hide();
            frmSafe2.Hide();
            formBuy1.Hide();
            formSell1.Hide();
            frmProducts1.Hide();
            formAccount1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMaxed.Location = btnMax.Location;
            btnMaxed.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxed.Visible = false;
            btnMax.Visible = true;
        }

     //   الفواتير
        private void btnRegister_Click(object sender, EventArgs e)
        {
            label2.Text = "الفواتير";
            if (this.fromInvoice1.Visible == false)
            {
                this.fromInvoice1.Visible = true;
                btnRegister.BackColor = Color.DarkSlateGray;
                button2.BackColor = panel1.BackColor;
                btnAction.BackColor = panel1.BackColor;
                button1.BackColor = panel1.BackColor;
                btnInvoices.BackColor = panel1.BackColor;
                btnGoods.BackColor = panel1.BackColor;
                btnAccpunts.BackColor = panel1.BackColor;
            }

            frmAction2.Hide();
            frmSafe2.Hide();
            formBuy1.Hide();
            formSell1.Hide();
            frmProducts1.Hide();
            formAccount1.Hide();

        }
    //    الهوم
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "الصفحة الرئيسية";
            if (this.button2.Visible == false)
            {
                this.button2.Visible = true;
                button2.BackColor = Color.Navy;
                btnRegister.BackColor = panel1.BackColor;
                btnAction.BackColor = panel1.BackColor;
                button1.BackColor = panel1.BackColor;
                btnInvoices.BackColor = panel1.BackColor;
                btnGoods.BackColor = panel1.BackColor;
                btnAccpunts.BackColor = panel1.BackColor;
            }
            frmAction2.Hide();
            fromInvoice1.Hide();
            frmSafe2.Hide();
            formBuy1.Hide();
            formSell1.Hide();
            frmProducts1.Hide();
            formAccount1.Hide();
        }
//الحركة
        private void btnAction_Click_1(object sender, EventArgs e)
        {
            label2.Text = "الحركة";
            if (this.frmAction2.Visible == false)
            {
                this.frmAction2.Visible = true;
                btnAction.BackColor = Color.Navy;
                btnRegister.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                button1.BackColor = panel1.BackColor;
                btnInvoices.BackColor = panel1.BackColor;
                btnGoods.BackColor = panel1.BackColor;
                btnAccpunts.BackColor = panel1.BackColor;
            }
            fromInvoice1.Hide();
            frmSafe2.Hide();
            formBuy1.Hide();
            formSell1.Hide();
            frmProducts1.Hide();
            formAccount1.Hide();
        }
      //  الخزنة
        private void btnSafe_Click_1(object sender, EventArgs e)
        {
            label2.Text = "الخزنة";
            if (this.frmSafe2.Visible == false)
            {
                this.frmSafe2.Visible = true;
                button2.BackColor = Color.Navy;
                btnRegister.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnAction.BackColor = panel1.BackColor;
                button1.BackColor = panel1.BackColor;
                btnInvoices.BackColor = panel1.BackColor;
                btnGoods.BackColor = panel1.BackColor;
                btnAccpunts.BackColor = panel1.BackColor;
            }
            fromInvoice1.Hide();
            frmAction2.Hide();
            formBuy1.Hide();
            formSell1.Hide();
            frmProducts1.Hide();
            formAccount1.Hide();

        }
      //  الشراء
        private void button1_Click_2(object sender, EventArgs e)
        {
            label2.Text = "الشراء";
            if (this.formBuy1.Visible == false)
            {
                this.formBuy1.Visible = true;
                button1.BackColor = Color.Navy;
                btnRegister.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnAction.BackColor = panel1.BackColor;
                btnInvoices.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnGoods.BackColor = panel1.BackColor;
                btnAccpunts.BackColor = panel1.BackColor;
            }
            fromInvoice1.Hide();
            frmAction2.Hide();
            frmSafe2.Hide();
            formSell1.Hide();
            frmProducts1.Hide();
            formAccount1.Hide();
        }
      //  البيع
        private void btnInvoices_Click_1(object sender, EventArgs e)
        {
            label2.Text = "البيع";
            if (this.formSell1.Visible == false)
            {
                this.formSell1.Visible = true;
                btnInvoices.BackColor = Color.Navy;
                btnRegister.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnAction.BackColor = panel1.BackColor;
                button1.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnGoods.BackColor = panel1.BackColor;
                btnAccpunts.BackColor = panel1.BackColor;
            }
            fromInvoice1.Hide();
            frmAction2.Hide();
            frmSafe2.Hide();
            formBuy1.Hide();
            frmProducts1.Hide();
            formAccount1.Hide();
        }
        //البضاعة
        private void btnGoods_Click(object sender, EventArgs e)
        {
            label2.Text = "البضاعة";
            if (this.frmProducts1.Visible == false)
            {
                this.frmProducts1.Visible = true;
                btnGoods.BackColor = Color.Navy;
                btnRegister.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnAction.BackColor = panel1.BackColor;
                button1.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnInvoices.BackColor = panel1.BackColor;
                btnAccpunts.BackColor = panel1.BackColor;
            }
            fromInvoice1.Hide();
            frmAction2.Hide();
            frmSafe2.Hide();
            formBuy1.Hide();
            formSell1.Hide();
            formAccount1.Hide();
        }

        private void btnAccpunts_Click_1(object sender, EventArgs e)
        {

            label2.Text = "الحسابات";
            if (this.formAccount1.Visible == false)
            {
                this.formAccount1.Visible = true;
                btnAccpunts.BackColor = Color.Navy;
                btnRegister.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnAction.BackColor = panel1.BackColor;
                button1.BackColor = panel1.BackColor;
                button2.BackColor = panel1.BackColor;
                btnInvoices.BackColor = panel1.BackColor;
                btnGoods.BackColor = panel1.BackColor;
            }
            fromInvoice1.Hide();
            frmAction2.Hide();
            frmSafe2.Hide();
            formBuy1.Hide();
            formSell1.Hide();
            frmProducts1.Hide();
        }
        //تسجيل الخروج
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
        }

        private void formSell1_Load(object sender, EventArgs e)
        {

        }
    }
}
