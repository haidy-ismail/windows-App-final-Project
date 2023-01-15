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

namespace userControl.UserControlProduct
{
    public partial class DeleteProduct : UserControl
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }
        public List<oldProducts> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Products").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<oldProducts> Products_ = JsonConvert.DeserializeObject<List<oldProducts>>(Message);
            return Products_;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var Products = GetData();
                var OldAction = Products.FirstOrDefault(id => id.رقم_الصنف == int.Parse(textBox1.Text));
                if (textBox2.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("ادخل الحقول الفارغه...!");
                }
                else
                {
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/Products/");
                    HttpResponseMessage respone = client.DeleteAsync($"{OldAction.رقم_الصنف}").Result;                                                                                //string Message = respone.Content.ReadAsStringAsync().Result;
                    MessageBox.Show("تم حذف المنتج!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch 
            { 
                MessageBox.Show("ادخل رقم المنتج"); 
            }
        }
        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
              HttpClient client = new HttpClient();
                HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Products").Result;
                string Message = respone.Content.ReadAsStringAsync().Result;
            List<oldProducts> Products_ = JsonConvert.DeserializeObject < List < oldProducts>>(Message);
                dataGridView1.DataSource = Products_;                    
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentCell.Selected = true;
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["رقم_الصنف"].FormattedValue.ToString();
                    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["اسم_الصنف"].FormattedValue.ToString();
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
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
