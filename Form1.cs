using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadcaptachimage();
        }
        int num = 0;
        private void loadcaptachimage()
        {
            Random r1 = new Random();
            num = r1.Next(100, 10000);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(num.ToString(), font, Brushes.Green, new Point(0, 0));
            pictureBox1.Image = image;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadcaptachimage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == num.ToString()) 
            {
                MessageBox.Show("Match Text with Captach!!!");
            }
            else
            {
                MessageBox.Show("Does Not Match Text with Captach!!!");
                loadcaptachimage();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
