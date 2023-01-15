using System;
using System.Windows.Forms;

namespace userControl
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            MyProgress.Value = startpoint;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                LogIn login = new LogIn();
                this.Hide();
                login.Show();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
