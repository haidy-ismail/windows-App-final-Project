using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userControl.Models;

namespace userControl.UserControlAccounts
{
    public partial class EditAccount : UserControl
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private void btnShowِAccounts_Click_1(object sender, EventArgs e)
        {


            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("http://rooneya-001-site1.htempurl.com/Accounts/GetAll").Result;
            string Message = response.Content.ReadAsStringAsync().Result;
            List<Accounts> acc = JsonConvert.DeserializeObject<List<Accounts>>(Message);
            dataGridView1.DataSource = acc;
        }
        
          
            
        
        private void accNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }

        private void accName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                
                dataGridView1.CurrentCell.Selected = true;
               accNum.Text = dataGridView1.Rows[e.RowIndex].Cells["رقم_الحساب"].FormattedValue.ToString();
               accName.Text = dataGridView1.Rows[e.RowIndex].Cells["اسم_الحساب"].FormattedValue.ToString();
               madeen.Text = dataGridView1.Rows[e.RowIndex].Cells["مدين"].FormattedValue.ToString();
                daeen.Text = dataGridView1.Rows[e.RowIndex].Cells["دائن"].FormattedValue.ToString();
                Tsneef.Text = dataGridView1.Rows[e.RowIndex].Cells["التصنيف"].FormattedValue.ToString();
                accCode.Text = dataGridView1.Rows[e.RowIndex].Cells["كود_الحساب"].FormattedValue.ToString();
                address.Text = dataGridView1.Rows[e.RowIndex].Cells["العنوان"].FormattedValue.ToString();
                phone.Text = dataGridView1.Rows[e.RowIndex].Cells["التليفون"].FormattedValue.ToString();
                accNature.Text = dataGridView1.Rows[e.RowIndex].Cells["طبيعه_الحساب"].FormattedValue.ToString();
            }
        }

        private List<Accounts> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("http://rooneya-001-site1.htempurl.com/Accounts/GetAll").Result;
            string Message = response.Content.ReadAsStringAsync().Result;
            List<Accounts> acc_ = JsonConvert.DeserializeObject<List<Accounts>>(Message);
            return acc_;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (accName.Text == "" || madeen.Text == "" || daeen.Text == ""
                    || accCode.Text == "" || accNum.Text == "" || Tsneef.Text == ""
                    || address.Text == "" || phone.Text == "" || accNature.Text == "")
                {
                    MessageBox.Show("من فضلك أدخل البيانات");
                }
                else
                {
                        var accounts = GetData();
                        var OldAction = accounts.FirstOrDefault(id_ => id_.رقم_الحساب == int.Parse(accNum.Text));
                        // OldAction.رقم_الحركة = int.Parse(textBox1.Text)
                             OldAction.اسم_الحساب = accName.Text;
                             OldAction.مدين = double.Parse(madeen.Text);
                             OldAction.دائن = double.Parse(daeen.Text);
                             OldAction.طبيعه_الحساب = accNature.Text;
                             OldAction.التصنيف = Tsneef.Text;
                             OldAction.كود_الحساب = int.Parse(accCode.Text);
                             OldAction.العنوان = address.Text;
                             OldAction.التليفون = phone.Text;

                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri($"http://rooneya-001-site1.htempurl.com/Accounts/");
                        HttpResponseMessage respone = client.PutAsJsonAsync("Update/" + OldAction.رقم_الحساب, OldAction).Result;
                        MessageBox.Show("تم التعديل بنجاح");
                        
                    
                }
            }
            catch (Exception m) { MessageBox.Show(m.Message); }
        }
       
    }
}