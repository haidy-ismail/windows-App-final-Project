using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using userControl.Models;
using VisioForge.MediaFramework.DSP;

namespace userControl.UserControlBuy
{
    public partial class AddBuy : UserControl
    {
        Dictionary<string, int> temp = new Dictionary<string, int>();

        public AddBuy()
        {
            InitializeComponent();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox2.Text == "" ||
               textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
               textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" ||
               textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" ||
               textBox12.Text == "")
            {
                MessageBox.Show("لا يوجد بيانات");
            }
            else
            {
                List<oldProducts> products = GetData();
                var idItem = int.Parse(textBox13.Text);
                oldProducts _id = products.Where(x => x.رقم_الصنف == idItem).FirstOrDefault();
                if (_id == null)
                {
                    MessageBox.Show(" المنتج غير موجود");
                }
                else
                {
                    Dictionary<string, int> temp = new Dictionary<string, int>();
                    temp.Add(textBox13.Text, int.Parse(textBox14.Text));                  
                    var action = new FullBuy()
                    {
                        // رقم_الحركة = int.Parse(textBox1.Text),
                        نوع_الحركة = comboBox1.Text,
                        تاريخ_الحركة = DateTime.Parse(dateTimePicker2.Text),
                        المبلغ = int.Parse(textBox3.Text),
                        اسم_الحساب = textBox1.Text,
                        مدين = int.Parse(textBox8.Text),
                        دائن = int.Parse(textBox2.Text),
                        طبيعه_الحساب = textBox4.Text,
                        التصنيف = textBox5.Text,
                        كود_الحساب = int.Parse(textBox9.Text),
                        العنوان = textBox10.Text,
                        التليفون = textBox11.Text,
                        طريقه_الحساب = textBox6.Text,
                        الكميه = int.Parse(textBox7.Text),
                        الخصم = int.Parse(textBox12.Text),
                    };
                    action.رقم_وعدد_البضاعة = temp;
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/FullBuyOperation/");
                    HttpResponseMessage respone = client.PostAsJsonAsync("FullBuyOperation/", action).Result;//here we setup package miceosoft.aspnet.api.client
                    string Message = respone.Content.ReadAsStringAsync().Result;
                    temp.Clear();
                    MessageBox.Show("تم حفظ البيانات بنجاح");
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
            catch (Exception m) { MessageBox.Show(m.Message); }
        }
        public List<oldProducts> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Products").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<oldProducts> Products_ = JsonConvert.DeserializeObject<List<oldProducts>>(Message);
            return Products_;
        }
        private void AddBuy_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }
        private void textBox10_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text =""; textBox2.Text = ""; textBox3.Text = "";
            textBox6.Text = ""; textBox5.Text = ""; textBox4.Text = "";
            textBox7.Text = ""; textBox8.Text =""; textBox9.Text = "";
            textBox10.Text = ""; textBox10.Text = ""; textBox12.Text = "";
            textBox12.Text = ""; textBox13.Text = ""; textBox14.Text = ""; comboBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void التليفون_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
