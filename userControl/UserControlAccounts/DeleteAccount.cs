using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userControl.Models;

namespace userControl.UserControlAccounts
{
    public partial class DeleteAccount : UserControl
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (accNum.Text == "")
            {
                MessageBox.Show("ادخل رقم الحساب");
            }
            else
            {
                using (var httpClient = new HttpClient())
                {
                    var account = new Accounts()
                    {

                    };
                    var accountSer = JsonConvert.SerializeObject(account);
                    var stringContent = new StringContent(accountSer, Encoding.UTF8, "application/json");
                    string id = accNum.Text;
                    var url = Path.Combine($"http://rooneya-001-site1.htempurl.com/Accounts/Delete/{id}");
                    var response = httpClient.DeleteAsync(url);
                    MessageBox.Show("تم حذف البيانات بنجاح");
                    accNum.Clear();
                }
            }
        }

        private void btnShowAccounts_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync("http://rooneya-001-site1.htempurl.com/Accounts/GetAll").Result;
            string Message = response.Content.ReadAsStringAsync().Result;
            List<Accounts> acc = JsonConvert.DeserializeObject<List<Accounts>>(Message);
            dataGridView1.DataSource = acc;
        }

        private void accNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dataGridView1.CurrentCell.Selected = true;
                accNum.Text = dataGridView1.Rows[e.RowIndex].Cells["رقم_الحساب"].FormattedValue.ToString();

            }
        }
    }
}
