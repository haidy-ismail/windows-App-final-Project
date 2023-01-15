using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using userControl.Models;

namespace userControl
{
    public partial class FromInvoice : UserControl
    {
        public FromInvoice()
        {
            InitializeComponent();
        }
        public void LoadData(string type)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Invoices/GetAll").Result;

            string Message = respone.Content.ReadAsStringAsync().Result;

            List<Invoice> invoices = JsonConvert.DeserializeObject<List<Invoice>>(Message);

            dataGridView1.DataSource = invoices.Where(x => x.طريقه_الحساب == type).ToList();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadData("بيع");
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadData("مرتجع بيع");
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadData("شراء");
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            LoadData("مرتجع شراء");
        }  
        private List<Invoice> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Invoices/GetAll").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<Invoice> Actions_ = JsonConvert.DeserializeObject<List<Invoice>>(Message);
            return Actions_;
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                var Actions_ = GetData();
                var OldAction = Actions_.FirstOrDefault(date_ => date_.التاريخ == Convert.ToDateTime(textBox1.Text));
                if (OldAction != null)
                {
                    if (dateTimePicker1.Value != null)
                    {
                        var date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                        var datagrid_type = dataGridView1.DataSource.GetType();
                        List<Invoice> oldList = dataGridView1.DataSource as List<Invoice>;
                        dataGridView1.DataSource = oldList.Where(x => x.التاريخ.ToString("MM/dd/yyyy") == date).ToList();
                    }
                    else
                    {
                        MessageBox.Show("لا توجد بيانات");
                    }
                }
                else 
                {
                    MessageBox.Show("لا يوجد بيانات");
                }
            }
            catch
            {
                MessageBox.Show("لا توجد بيانات للعرض");
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ادخل رقم الفاتورة");
                }
                else
                {
                    var Actions_ = GetData();
                    var OldAction = Actions_.FirstOrDefault(id => id.رقم_الفاتوره == int.Parse(textBox1.Text));
                    HttpClient client_ = new HttpClient();
                    client_.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/Invoices/");
                    HttpResponseMessage respone_ = client_.DeleteAsync("Delete/" + OldAction.رقم_الفاتوره).Result;
                    string Message_ = respone_.Content.ReadAsStringAsync().Result;
                    MessageBox.Show("تم الحذف بنجاح");
                    textBox1.Clear();
                }
            }
            catch
            {
                MessageBox.Show("لا توجد بيانات للحذف");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentCell.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["رقم_الفاتوره"].FormattedValue.ToString();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Invoices/GetById/").Result;

                string Message = respone.Content.ReadAsStringAsync().Result;

                List<Invoice> invoices = JsonConvert.DeserializeObject<List<Invoice>>(Message);

                dataGridView1.DataSource = invoices.Where(x => x.رقم_الفاتوره == int.Parse(textBox1.Text)).ToList();
            }
            catch
            {
                MessageBox.Show("ادخل رقم الفاتورة");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }
    }
}
