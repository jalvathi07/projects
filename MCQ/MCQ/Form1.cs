using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQ
{
    public partial class Form1 : Form
    {
        public static string name;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "NAME";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //name = textBox1.Text;
            //File.WriteAllText("F:\\MCQ\\"+textBox1.Text+".txt","");
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
