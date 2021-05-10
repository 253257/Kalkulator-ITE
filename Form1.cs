using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_ITE
{

    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(this.textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(this.textBox2.Text);
        }

        private void MOD_button_Click(object sender, EventArgs e)
        {
            wynik1.Text = (a % b).ToString();
        }

        private void NWD_button_Click(object sender, EventArgs e) 
        {
            wynik1.Text = Program.Nwd(a,b).ToString();
        }
    }
}

