using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using userControl.Models;

namespace userControl
{
    public partial class DeleteAction : UserControl
    {
        public DeleteAction()
        {
            InitializeComponent();
        }
        public List<Actions> GetData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Actions/GetAll").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<Actions> Actions_ = JsonConvert.DeserializeObject<List<Actions>>(Message);
            return Actions_;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("من فضلك أدخل البيانات");
                } 
                else
                {
                    var Actions = GetData();
                    var OldAction = Actions.FirstOrDefault(id => id.رقم_الحركة == int.Parse(textBox1.Text));
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/Actions/");
                    HttpResponseMessage respone = client.DeleteAsync("Delete/" + OldAction.رقم_الحركة).Result;//here we setup package miceosoft.aspnet.api.client                                                                                         //string Message = respone.Content.ReadAsStringAsync().Result;
                    MessageBox.Show("تم حذف البيانات بنجاح");
                    textBox1.Clear();

                }
            }
            catch
            {
                MessageBox.Show("ادخل رقم الحركه");
            }
        }

        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Actions/GetAll").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<Actions> Actions_ = JsonConvert.DeserializeObject<List<Actions>>(Message);
            dataGridView1.DataSource = Actions_;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentCell.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["رقم_الحركة"].FormattedValue.ToString();
                //comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["نوع_الحركة"].FormattedValue.ToString();

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
