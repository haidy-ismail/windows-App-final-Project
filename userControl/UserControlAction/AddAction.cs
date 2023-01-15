using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using userControl.Models;

namespace userControl
{
    public partial class AddAction : UserControl
    {
        public AddAction()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("من فضلك أدخل البيانات");
            }
            else
            {
                var move = new Actions()
            {
                // رقم_الحركة = int.Parse(textBox1.Text),
                نوع_الحركة = comboBox1.Text,
                تاريخ_الحركة = DateTime.Parse(dateTimePicker1.Text),
                المبلغ = int.Parse(textBox2.Text)
            };
            
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/Actions/");
                HttpResponseMessage respone = client.PostAsJsonAsync("AddAction/", move).Result;//here we setup package miceosoft.aspnet.api.client
                string Message = respone.Content.ReadAsStringAsync().Result;
                MessageBox.Show("تمت الإضافة بنجاح");
            }
            HttpClient client_ = new HttpClient();
            HttpResponseMessage respone_ = client_.GetAsync("http://rooneya-001-site1.htempurl.com/Actions/GetAll").Result;
            string Message_ = respone_.Content.ReadAsStringAsync().Result;
            List<Actions> Actions_ = JsonConvert.DeserializeObject<List<Actions>>(Message_);
            dataGridView1.DataSource = Actions_;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }
    }
}
