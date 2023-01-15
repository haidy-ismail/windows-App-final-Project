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
    public partial class FormBuy : UserControl
    {
        public FormBuy()
        {
            InitializeComponent();
        }
        private void FormBuy_Load(object sender, EventArgs e)
        {
            addBuy1.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.addBuy1.Visible == false)
            {
                this.addBuy1.Visible = true;
            }
        }
    }
}
