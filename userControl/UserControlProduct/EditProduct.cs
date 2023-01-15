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
    public partial class EditProduct : UserControl
    {
        public EditProduct()
        {
            InitializeComponent();
        }
        public List<oldProducts> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Products").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<oldProducts> produc_ = JsonConvert.DeserializeObject<List<oldProducts>>(Message);
            return produc_;
        }
        private void Edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || txtBox2.Text == "" || int.Parse(txtBox3.Text) == null || int.Parse(txtBox4.Text) == null || int.Parse(txtBox5.Text) == null || txtBox6.Text == "")
                {
                    MessageBox.Show("من فضلك أدخل البيانات");
                }
                else
                {
                    var Products = GetData();
                    var OldAction = Products.FirstOrDefault(id => id.رقم_الصنف == int.Parse(textBox1.Text));
                    OldAction.اسم_الصنف = txtBox2.Text;
                    OldAction.سعر_البيع = int.Parse(txtBox3.Text);
                    OldAction.اجمالي_الكميه = int.Parse(txtBox4.Text);
                    OldAction.سعر_الشراء = int.Parse(txtBox5.Text);
                    OldAction.الوصف = txtBox6.Text;
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/Products/");
                    HttpResponseMessage respone = client.PutAsJsonAsync($"{OldAction.رقم_الصنف}", OldAction).Result;
                    MessageBox.Show("تم التعديل بنجاح");
                }
            }
            catch { MessageBox.Show("من فضلك أدخل البيانات"); }        
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Products").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<oldProducts> produc_ = JsonConvert.DeserializeObject<List<oldProducts>>(Message);
            dataGridView1.DataSource = produc_;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentCell.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["رقم_الصنف"].FormattedValue.ToString();
                txtBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["اسم_الصنف"].FormattedValue.ToString();
                txtBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["سعر_البيع"].FormattedValue.ToString();
                txtBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["اجمالي_الكميه"].FormattedValue.ToString();
                txtBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["سعر_الشراء"].FormattedValue.ToString();
                txtBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["الوصف"].FormattedValue.ToString();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch)&& ch !=8 && ch != 64)
            {
                e.Handled = true;
            }
        }
        private void txtBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (! char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
