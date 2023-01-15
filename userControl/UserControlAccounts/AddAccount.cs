using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userControl.Models;

namespace userControl.UserControlAccounts
{
    public partial class AddAccount : UserControl
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accName.Text == "" || double.Parse(madeen.Text) == null
                || double.Parse(daeen.Text) == null || accNature.Text == ""
                || Tsneef.Text == "" || int.Parse(accCode.Text) == null ||
                address.Text == "" || phone.Text == "")
            {
                MessageBox.Show("من فضلك أدخل البيانات");
            }
            else
            {
                using (var httpClient = new HttpClient())
                {
                    var endPoint = new Uri("http://rooneya-001-site1.htempurl.com/Accounts/AddNewAccount");
                    var acc = new Accounts()
                    {
                        //accName.Text = acc.اسم_الحساب;
                        اسم_الحساب = accName.Text,
                        مدين = double.Parse(madeen.Text),
                        دائن = double.Parse(daeen.Text),
                        طبيعه_الحساب = accNature.Text,
                        التصنيف = Tsneef.Text,
                        كود_الحساب = int.Parse(accCode.Text),
                        العنوان = address.Text,
                        التليفون = phone.Text
                    };
                    var newJson = JsonConvert.SerializeObject(acc);
                    var payload = new StringContent(newJson, Encoding.UTF8, "application/json");
                    var result = httpClient.PostAsync(endPoint, payload).Result.Content.ReadAsStringAsync().Result;
                    MessageBox.Show("تم إضافة البيانات بنجاح");
                    HttpClient client = new HttpClient();
                    HttpResponseMessage response = client.GetAsync("http://rooneya-001-site1.htempurl.com/Accounts/GetAll").Result;
                    string Message = response.Content.ReadAsStringAsync().Result;
                    List<Accounts> acc_ = JsonConvert.DeserializeObject<List<Accounts>>(Message);
                    dataGridView1.DataSource = acc_;
                }
            }
        }

        private void accName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void madeen_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
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

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }

        private void daeen_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }

        private void accNature_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tsneef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void accCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }        
    }
}
