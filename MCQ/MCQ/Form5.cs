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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add("             THANKS FOR YOUR KINDLY ANSWERS");
            //listBox1.Items.Add("");
            //listBox1.Items.Add(" TOTAL NUMBER OF QUESTIONS ASKED : 5");
            //listBox1.Items.Add(" NUMBER OF QUESTIONS ANSWERED : "+Form4.answer);
            listBox1.Items.Add(" YOU SCORED :" + Form4.total+ "/10");
            //StreamWriter fox = new StreamWriter("F:\\MCQ\\" + Form1.name + ".txt");
            //string ans=Form4.answer.ToString();
            //string mark=Form4.mark.ToString();
            ////string[] ar = new string[listBox1.Items.Count];
            ////for (int i = 0; i < listBox1.Items.Count; i++)
            ////{
            ////    ar[i] = listBox1.Items[i].ToString();
            ////}
            ////fox.Write(ar);
            //fox.Write("                   R E P O R T");
            //fox.WriteLine(" ");
            //fox.WriteLine("______________________________________________ ");
            //fox.WriteLine("     NUMBER OF QUESTIOS ASKED : 5");
            //fox.WriteLine("     NUMBER OF QUESTION ANSWERED : "+ans);
            //fox.WriteLine("     YOU SCORED : " + mark+"/10");
            //fox.Close(); 
            //Form4.answer = 0;
            //Form4.mark = 0;
            Form4.total = 0;
        }


    }
}
