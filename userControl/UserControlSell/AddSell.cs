using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using Newtonsoft.Json;
using userControl.Models;

namespace userControl.UserControlSell
{
    public partial class AddSell : UserControl

    {
        Dictionary<string, int> temp = new Dictionary<string, int>();

        public AddSell()
        {
            InitializeComponent();
        }       
        private void button2_Click(object sender, EventArgs e)
        {               
            if (textBox1.Text == "" || textBox8.Text == "" || textBox13.Text=="" ||
               textBox3.Text == "" || comboBox2.Text == "" || textBox5.Text == "" ||
               textBox7.Text == "" ||
               textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" ||
               textBox12.Text == "")
            {
                MessageBox.Show("من فضلك أدخل البيانات");
            }
            else
            {
                List<oldProducts> products = GetData();
                var idItem = int.Parse(textBox13.Text);
                oldProducts _id = products.Where(x => x.رقم_الصنف == idItem).FirstOrDefault();
                if (_id == null)
                {
                    MessageBox.Show("المنتج غير موجود");
                }
                else
                {
                    int x = 0;
                    var action = new FullSell()
                    {
                        // رقم_الحركة = int.Parse(textBox1.Text),
                        نوع_الحركة = comboBox2.Text,
                        تاريخ_الحركة = DateTime.Parse(dateTimePicker2.Text),
                        المبلغ = int.Parse(textBox3.Text),
                        اسم_الحساب = textBox1.Text,
                        مدين = int.Parse(textBox8.Text),
                        دائن = x,
                        طبيعه_الحساب = comboBox2.Text,
                        التصنيف = textBox5.Text,
                        كود_الحساب = int.Parse(textBox9.Text),
                        العنوان = textBox10.Text,
                        التليفون = textBox11.Text,
                        طريقه_الحساب = comboBox2.Text,
                        الكميه = int.Parse(textBox7.Text),
                        الخصم = int.Parse(textBox12.Text),
                    };
                    action.رقم_وعدد_البضاعة = temp;
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/FullSellOperation/");
                    HttpResponseMessage respone = client.PostAsJsonAsync("FullSellOperation/", action).Result;//here we setup package miceosoft.aspnet.api.client
                    string Message = respone.Content.ReadAsStringAsync().Result;
                    temp.Clear();
                    MessageBox.Show("Data Saved");
                }
            }                     
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (temp.ContainsKey(textBox13.Text))
                {
                    temp[textBox13.Text] += int.Parse(textBox7.Text);
                }
                else
                {
                    temp.Add(textBox13.Text, int.Parse(textBox7.Text));
                }
                var totalPrice = int.Parse(textBox3.Text) * int.Parse(textBox7.Text);
                dataGridView1.Rows.Add(textBox9.Text, textBox3.Text, textBox7.Text, totalPrice);
            }
            catch(Exception x) { MessageBox.Show(x.Message); }
        }       
        private void AddSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public List<oldProducts> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Products").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<oldProducts> Products_ = JsonConvert.DeserializeObject<List<oldProducts>>(Message);
            return Products_;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Text = ""; textBox1.Text = ""; textBox11.Text = "";

            textBox3.Text = ""; textBox12.Text = ""; textBox5.Text = ""; textBox13.Text = "";

            textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = ""; textBox10.Text = "";
        }
    }
}
