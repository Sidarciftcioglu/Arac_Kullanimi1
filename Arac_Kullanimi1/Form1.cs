using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");//Bir komutun sol tarafında küp işareti varsa o komutun sonunda mutlaka parantez açılıp kapanır.Yani onun bir metod olduğunu bildirir.
            MessageBox.Show("I win!:)");
        }

       private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Sidar";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Sidar";
            label7.Text = "Çiftçioğlu";
            label8.Text = "Software Engineer";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Hello world!";
            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text= textBox3.Text;
            label12.Text= textBox4.Text;
        }
    }
}
