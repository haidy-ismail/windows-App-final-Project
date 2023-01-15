using System;
using System.Windows.Forms;

namespace userControl
{
    public partial class frmAction : UserControl
    {
        public frmAction()
        {
            InitializeComponent();
        }
        private void frmAction_Load(object sender, EventArgs e)
        {
            addAction1.Hide();
            editAction1.Hide();
            deleteAction1.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.addAction1.Visible == false)
            {
                this.addAction1.Visible = true;
            }
            editAction1.Hide();
            deleteAction1.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.editAction1.Visible == false)
            {
                this.editAction1.Visible = true;
            }

            addAction1.Hide();
            deleteAction1.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.deleteAction1.Visible == false)
            {
                this.deleteAction1.Visible = true;
            }
            addAction1.Hide();
            editAction1.Hide();
        }

        private void editAction1_Load(object sender, EventArgs e)
        {

        }

        private void deleteAction1_Load(object sender, EventArgs e)
        {

        }
    }
}
