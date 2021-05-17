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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MOD_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int a))
            {
                if (int.TryParse(textBox2.Text, out int b))
                    wynik1.Text = (a % b).ToString();
                else
                    wynik1.Text = "N/A";
            }
            else
                wynik1.Text = "N/A";
        }

        private void NWW_button_Click(object sender, EventArgs e)
        {
            //wynik1.Text = Program.Nww(a,b).ToString();
        }

        private void NWD_button_Click(object sender, EventArgs e) 
        {
            //wynik1.Text = Program.Nwd(a,b).ToString();
        }
    }
}

