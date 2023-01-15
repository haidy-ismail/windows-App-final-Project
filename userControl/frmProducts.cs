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
    public partial class frmProducts : UserControl
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            addProduct1.Hide();
            editProduct1.Hide();
            deleteProduct1.Hide();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.addProduct1.Visible == false)
            {
                this.addProduct1.Visible = true;
            }
            editProduct1.Hide();
            deleteProduct1.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.editProduct1.Visible == false)
            {
                this.editProduct1.Visible = true;
            }
            addProduct1.Hide();
            deleteProduct1.Hide();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (this.deleteProduct1.Visible == false)
            {
                this.deleteProduct1.Visible = true;
            }
            addProduct1.Hide();
            editProduct1.Hide();
        }
    }
}
