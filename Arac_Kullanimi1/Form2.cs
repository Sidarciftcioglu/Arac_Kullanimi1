using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arac_Kullanimi1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Eskişehir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Architect");
            listBox1.Items.Add("Influencer");
            listBox1.Items.Add("Football Player");
            listBox1.Items.Add("Accounting Manager");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text+" "+textBox4.Text+" "+textBox2.Text+" "+textBox1.Text);
        }
    }
}
