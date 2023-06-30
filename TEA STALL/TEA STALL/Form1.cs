using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEA_STALL
{
    public partial class Form1 : Form
    {
        public static int bill = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("TEA");
            comboBox1.Items.Add("COFFEE");
            comboBox1.Items.Add("LEMON TEA");
            comboBox2.Items.Add("SODA");
            comboBox2.Items.Add("JUICE");
            comboBox2.Items.Add("SHAKES");
            comboBox3.Items.Add("VADA");
            comboBox3.Items.Add("BISCUITS");
            comboBox3.Items.Add("PUFFS");
            listBox1.Items.Add("                        CHAYA CORNER");
            listBox1.Items.Add("");
            listBox1.Items.Add("                               B I L L");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = -1;
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
                button1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox2.Enabled = true;
                numericUpDown2.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = -1;
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 0;
                button1.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBox3.Enabled = true;
                numericUpDown3.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox3.SelectedIndex = -1;
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 0;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int drinks = 0;
            int cooldrinks = 0;
            int snacks = 0;
            if (checkBox1.Checked)
            {
                if (comboBox1.Text == "TEA")
                {
                    int tea = 10;
                    drinks = (int)numericUpDown1.Value * tea;
                    listBox1.Items.Add("COST FOR TEA :" + drinks);
                    bill = bill + drinks;
                }
                else if (comboBox1.Text == "LEMON TEA")
                {
                    int tea = 15;
                    drinks = (int)numericUpDown1.Value * tea;
                    listBox1.Items.Add("COST FOR  LEMON TEA :" + drinks);
                    bill = bill + drinks;
                }
                else if (comboBox1.Text == "COFFEE")
                {
                    int tea = 15;
                    drinks = (int)numericUpDown1.Value * tea;
                    listBox1.Items.Add("COST FOR COFFEE :" + drinks);
                    bill = bill + drinks;
                }
                if (checkBox2.Checked)
                {
                    if (comboBox2.Text == "SODA")
                    {
                        int soda = 20;
                        cooldrinks = (int)numericUpDown2.Value * soda;
                        listBox1.Items.Add("COST FOR SODA :" + cooldrinks);
                        bill = bill + cooldrinks;
                    }
                    else if (comboBox2.Text == "SHAKES")
                    {
                        int shakes = 30;
                        cooldrinks = (int)numericUpDown2.Value * shakes;
                        listBox1.Items.Add("COST FOR SODA :" + cooldrinks);
                        bill = bill + cooldrinks;
                    }
                    else if (comboBox2.Text == "JUICE")
                    {
                        int juice = 25;
                        cooldrinks = (int)numericUpDown2.Value * juice;
                        listBox1.Items.Add("COST FOR JUICE :" + cooldrinks);
                        bill = bill + cooldrinks;
                    }
                    if (checkBox3.Checked)
                    {
                        if (comboBox3.Text == "VADA")
                        {
                            int vada = 8;
                            snacks = (int)numericUpDown3.Value * vada;
                            listBox1.Items.Add("COST FOR VADA :" + cooldrinks);
                            bill = bill + snacks;
                        }
                        else if (comboBox3.Text == "BISCUITS")
                        {
                            int biscuits = 5;
                            snacks = (int)numericUpDown3.Value * biscuits;
                            listBox1.Items.Add("COST FOR VADA :" + snacks);
                            bill = bill + snacks;
                        }
                        else if (comboBox3.Text == "PUFFS")
                        {
                            int puffs = 20;
                            snacks = (int)numericUpDown3.Value * puffs;
                            listBox1.Items.Add("COST FOR PUFFS :" + snacks);
                            bill = bill + snacks;
                        }
                    }
                    listBox1.Items.Add(" TOTAL AMOUNT :" + bill);
                }
            }
        }
           
            

        private void button2_Click(object sender, EventArgs e)
        {
                            listBox1.Items.Clear();
                            checkBox1.Checked = false;
                            checkBox2.Checked = false;
                            checkBox3.Checked = false;
                            comboBox1.SelectedIndex = -1;
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                            comboBox3.Enabled = false;
                            numericUpDown1.Enabled = false;
                            numericUpDown2.Enabled = false;
                            numericUpDown3.Enabled = false;
                            numericUpDown1.Value = 0;
                            numericUpDown2.Value = 0;
                            numericUpDown3.Value = 0;
        }
       
         private void button3_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown2.Focus();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown3.Focus();
        }
    }
}


