using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using userControl.Models;

namespace userControl
{
    public partial class EditAction : UserControl
    {
        public EditAction()
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
                if (comboBox1.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("من فضلك أدخل البيانات");
                }
                else
                {
                    var Actions = GetData();
                    var OldAction = Actions.FirstOrDefault(id => id.رقم_الحركة == int.Parse(textBox1.Text));
                    // OldAction.رقم_الحركة = int.Parse(textBox1.Text);
                    OldAction.نوع_الحركة = comboBox1.Text;
                    OldAction.تاريخ_الحركة = DateTime.Parse(dateTimePicker1.Text);
                    OldAction.المبلغ = int.Parse(textBox3.Text);
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://rooneya-001-site1.htempurl.com/Actions/");
                    HttpResponseMessage respone = client.PutAsJsonAsync("Update/" + OldAction.رقم_الحركة, OldAction).Result;
                    MessageBox.Show("تم التعديل بنجاح");
                }
            }catch(Exception m) { MessageBox.Show(m.Message); }
        } 
        //ShowAllData
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
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["نوع_الحركة"].FormattedValue.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["تاريخ_الحركة"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["المبلغ"].FormattedValue.ToString();
            }
        }

        private void EditAction_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }   
    }
}
