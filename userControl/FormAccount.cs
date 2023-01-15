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
    public partial class FormAccount : UserControl
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            addAccount1.Hide();
            editAccount1.Hide();
            deleteAccount1.Hide();
        }
      //  جديد
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.addAccount1.Visible == false)
            {
                this.addAccount1.Visible = true;
            }
            editAccount1.Hide();
            deleteAccount1.Hide();
        }
     //   تعديل
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.editAccount1.Visible == false)
            {
                this.editAccount1.Visible = true;
            }
            addAccount1.Hide();
            deleteAccount1.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (this.deleteAccount1.Visible == false)
            {
                this.deleteAccount1.Visible = true;
            }
            addAccount1.Hide();
            editAccount1.Hide();
        }
    }
}
