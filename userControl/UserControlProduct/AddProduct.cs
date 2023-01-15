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
using VisioForge.Libs.DirectShowLib;

namespace userControl.UserControlProduct
{
    public partial class AddProduct : UserControl
    {
        Image i;
        Bitmap b;
        byte[] file;
        string imageName;
        public AddProduct()
        {
            InitializeComponent();
        }
        private void trying_Load(object sender, EventArgs e)
        {
            add.Enabled = false;
        }       
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(productNameAdd.Text) || string.IsNullOrEmpty(sellingPriceAdd.Text) ||
                    string.IsNullOrEmpty(countityAdd.Text)    || string.IsNullOrEmpty(buyingBoxAdd.Text) ||
                    string.IsNullOrEmpty(categioryAdd.Text)   ||string.IsNullOrEmpty(pictureBox1.Name) )
                {
                    MessageBox.Show("من فضلك أدخل البيانات");
                }
                else
                {
                    using (var httpClient = new HttpClient())
                    {

                        Products acc = new Products()
                        {
                            //accName.Text = acc.اسم_الحساب;
                            productId = 0,
                            productName = productNameAdd.Text,
                            sellingPrice = double.Parse(sellingPriceAdd.Text),
                            quantity = int.Parse(countityAdd.Text),
                            buyingPrice = double.Parse(buyingBoxAdd.Text),
                            disc = categioryAdd.Text,
                            bytes = file,
                            imageName = imageName,
                            category = comboBox1.Text
                        };
                        var endPoint = new Uri("http://rooneya-001-site1.htempurl.com/ProductsWithImages/AddProductWinForm");
                        var newJson = JsonConvert.SerializeObject(acc);
                        var payload = new StringContent(newJson, Encoding.UTF8, "application/json");
                        var result = httpClient.PostAsync(endPoint, payload).Result.Content.ReadAsStringAsync().Result;
                        MessageBox.Show("تمت الإضافة بنجاح");
                        productNameAdd.Clear();
                        sellingPriceAdd.Clear();
                        countityAdd.Clear();
                        buyingBoxAdd.Clear();
                        categioryAdd.Clear();
                    }
                }
            }
            catch (Exception ez)
            {
                MessageBox.Show(ez.ToString());
            }
                
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                i = Image.FromFile(ofd.FileName);
                b = (Bitmap)i;
                pictureBox1.Image = b;
                add.Enabled = true;

                file = File.ReadAllBytes(ofd.FileName);
                FileInfo fi = new FileInfo(ofd.FileName);
                imageName = fi.Name;
                //File.WriteAllBytes(imageName, file);
            }
            else
            {
                add.Enabled = false;
                MessageBox.Show("تم إضافة الصورة بنجاح");
            }
        }
        private void AddProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 64)
            {
                e.Handled = true;
            }
        }
        private void productNameAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

