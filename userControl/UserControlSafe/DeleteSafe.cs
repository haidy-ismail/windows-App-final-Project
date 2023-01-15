using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using userControl.Models;

namespace userControl.UserControlSafe
{
    public partial class DeleteSafe : UserControl
    {
        public DeleteSafe()
        {
            InitializeComponent();
        }
        public List<Safe> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Safe/Get").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<Safe> safe_ = JsonConvert.DeserializeObject<List<Safe>>(Message);
            return safe_;
        }
        private void btnDeleteSafe_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("من فضلك أدخل البيانات");
                }
                else
                {
                    var Safe = GetData();
                    var OldAction = Safe.FirstOrDefault(id => id.رقم_المسلسل == int.Parse(textBox1.Text));
                    OldAction.الحركه = comboBox1.Text;
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/Safe/");
                    HttpResponseMessage respone = client.DeleteAsync("Delete/" + OldAction.رقم_المسلسل).Result;//here we setup package miceosoft.aspnet.api.client                                                                                                      //string Message = respone.Content.ReadAsStringAsync().Result;
                    MessageBox.Show("تم الحذف بنجاح");
                    textBox1.Clear();
                }
            }
            catch
             
            { 
                MessageBox.Show("ادخل رقم المسلسل");
            }
        }
        //ShowAllData
        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Safe/Get").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<Safe> safe_ = JsonConvert.DeserializeObject<List<Safe>>(Message);
            dataGridView1.DataSource = safe_;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentCell.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["رقم_المسلسل"].FormattedValue.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["الحركه"].FormattedValue.ToString();
                //dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["التاريخ"].FormattedValue.ToString();
                //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["وارد"].FormattedValue.ToString();
                //textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["منصرف"].FormattedValue.ToString();
                //textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["رصيد"].FormattedValue.ToString();
                //textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["الحساب"].FormattedValue.ToString();
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
