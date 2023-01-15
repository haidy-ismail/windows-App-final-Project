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
    public partial class frmSafe : UserControl
    {
        public frmSafe()
        {
            InitializeComponent();
        }
        private void frmSafe_Load(object sender, EventArgs e)
        {
           
            deleteSafe1.Hide();
        }
     
        private void btnDeleteSafe_Click_1(object sender, EventArgs e)
        {
            if (this.deleteSafe1.Visible == false)
            {
                this.deleteSafe1.Visible = true;
            }
           
        }
    }
}
