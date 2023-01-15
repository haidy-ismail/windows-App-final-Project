using System;
using System.Windows.Forms;

namespace userControl
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtBoxUserName.Text = "";
            txtBoxPassword.Text = "";
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (txtBoxUserName.Text == "" || txtBoxPassword.Text == "")
            {
                MessageBox.Show("من فضلك أدخل إسم المستخدم و كلمة المرور");
            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "مدير النظام")
                    {
                        if (txtBoxUserName.Text == "Admin" && txtBoxPassword.Text == "Admin")
                        {
                            formAdminssion frmadmin = new formAdminssion();
                            frmadmin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("أدخل إسم المستخدم و كلمة المرور صحيحة");
                        }
                    }
                    else if (comboBox1.SelectedItem.ToString() ==  "الكاشير")
                    {
                        if (txtBoxUserName.Text == "Casher" && txtBoxPassword.Text == "Casher")
                        {
                            CasherAction Casher = new CasherAction();
                            Casher.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("أدخل إسم المستخدم و كلمة المرور صحيحة");
                        }


                    }
                    else
                    {
                        MessageBox.Show("رجاء اختر  نوع المستخدم ");
                    }
                }
                else
                {
                    MessageBox.Show("رجاء اختر نوع المستخدم");
                }
            }
        }
    }
}
