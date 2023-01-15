using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userControl
{
    public partial class CasherAction : Form
    {
        public CasherAction()
        {
            InitializeComponent();
        }
        private void CasherAction_Load(object sender, EventArgs e)
        {
         
            this.FormBorderStyle = FormBorderStyle.None;

           
            formSell2.Hide();

        }
        private void btnMax_Click_1(object sender, EventArgs e)
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
            formSell2.Hide();
           
        }
       
     //   البيع
        private void btnInvoices_Click_1(object sender, EventArgs e)
        {
            lblH.Text = "البيع";
            if (this.formSell2.Visible == false)
            {
                this.formSell2.Visible = true;
              
            }
            

        }
     
       private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CasherAction_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            formSell2.Hide();
            
            
        }

       

        private void productCasher1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
        }
    }
}
