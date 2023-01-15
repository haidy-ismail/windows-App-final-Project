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
    public partial class FormSell : UserControl
    {
        public FormSell()
        {
            InitializeComponent();
        }
        private void FormSell_Load(object sender, EventArgs e)
        {
            addSell1.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.addSell1.Visible == false)
            {
                this.addSell1.Visible = true;
            }
        }
    }
}
