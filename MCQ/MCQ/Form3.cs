using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQ
{
    public partial class Form3 : Form
    {
        public static int easy = 0;
        public static int med = 0;
        public static int hard = 0;
        public static int easy1= 0;
        public static int med1= 0;
        public static int hard1 = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            easy += 1;
            easy1 += 1;
            if (radioButton1.Checked)
            {
                button1.Enabled = true;
            }
            else if (radioButton2.Checked)
            {
                button1.Enabled = true;
            }
            else if (radioButton3.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            med += 1;
            med1 += 1;
            if (radioButton1.Checked)
            {
                button1.Enabled = true;
            }
            else if (radioButton2.Checked)
            {
                button1.Enabled = true;
            }
            else if (radioButton3.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            hard += 1;
            hard1 += 1;
            if (radioButton1.Checked)
            {
                button1.Enabled = true;
            }
            else if (radioButton2.Checked)
            {
                button1.Enabled = true;
            }
            else if (radioButton3.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 obj2 = new Form4();
            obj2.ShowDialog();
        }
    }
}
