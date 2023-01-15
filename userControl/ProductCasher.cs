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

namespace userControl
{
    public partial class ProductCasher : UserControl
    {
        public ProductCasher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //oldProducts old = new oldProducts();
           
            HttpClient client = new HttpClient();
            HttpResponseMessage respone = client.GetAsync("http://rooneya-001-site1.htempurl.com/Products").Result;
            string Message = respone.Content.ReadAsStringAsync().Result;
            List<ProductCasher> Products_ = JsonConvert.DeserializeObject<List<ProductCasher>>(Message);
            // dataGridView1.Rows.Add(old.رقم_الصنف, old.اسم_الصنف, old.اجمالي_الكميه, old.سعر_البيع);
            dataGridView1.DataSource = Products_;
        }

        private void ProductCasher_Load(object sender, EventArgs e)
        {

        }
    }
}
