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
    public partial class Form4 : Form
    {
        public static int q1 = 0;
        public static int q2 = 0;
        public static int q3 = 0;
        public static int q4 = 0;
        public static int q5 = 0;
        public static int mark = 0;
        public static int total = 0;
        public Form4()
        {
            InitializeComponent();
            button2.Enabled = false;
            if (Form3.easy == 1)
            {
                button1.Visible = true;
                q1 += 1;
                label2.Text = "1. IN WHICH DIRECTION DOES THE SUNRISE?";
                radioButton1.Text = "EAST";
                radioButton2.Text = "WEST";
                radioButton3.Text = "NORTH";
            }
            if (Form3.med == 1)
            {
                button4.Visible = true;
                q1 += 1;
                label2.Text = "1. HOW MANY EQUAL SIDES AN ISOCHELES TRIANGLE HAVE?";
                radioButton1.Text = "3";
                radioButton2.Text = "2";
                radioButton3.Text = "1";
            }
            if (Form3.hard == 1)
            {
                button5.Visible = true;
                q1 += 1;
                label2.Text = "1. WHO IS THE FOUNDER OF MICROSOFT?";
                radioButton1.Text = "STEVE HARVEY";
                radioButton2.Text = "PAUL ALTEN";
                radioButton3.Text = "BILL GATES";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
                Form3.easy += 1;
                if (Form3.easy == 2)
                {
                    q2 += 1;
                    label2.Text = "2. HOW MANY ZEROS ARE THERE IN THOUSAND?";
                    radioButton1.Text = "THREE";
                    radioButton2.Text = "FIVE";
                    radioButton3.Text = "SIX";
                }
                if (Form3.easy == 3)
                {
                    q3 += 1;
                    label2.Text = "3. HOW MANY HOURS ARE THERE IN TWO DAYS?";
                    radioButton1.Text = "42";
                    radioButton2.Text = "48";
                    radioButton3.Text = "44";
                }
                 if(Form3.easy == 4)
                {
                    q4 += 1;
                    label2.Text = "4. HOW MANY MONTH OF THE YEAR HAVE 31 DAYS?";
                    radioButton1.Text = "EIGHT";
                    radioButton2.Text = "SEVEN";
                    radioButton3.Text = "SIX";
                }
                 if (Form3.easy == 5)
                 {
                     q5 += 1;
                     label2.Text = "5. WHO WAS THE MAN TO WALK ON THE MOON FIRST?";
                     radioButton1.Text = "ARNOLD";
                     radioButton2.Text = "NEIL ARMSTRONG";
                     radioButton3.Text = "JOHN WIKKY";
                     button1.Enabled = false;
                 }
            if (Form3.easy == 2 && q1 == 1)
            {
                if (radioButton1.Checked)
                {
                    mark += 2;
                    total = mark;
                }
            }
            if (Form3.easy == 3 && q2 == 1)
            {
                if (radioButton1.Checked)
                {
                    mark += 2;
                    total = mark;
                }
            }
            if (Form3.easy == 4 && q3 == 1)
            {
                if (radioButton2.Checked)
                {
                    mark += 2;
                    total = mark;
                }
            }
            if (Form3.easy == 5 && q4 == 1)
            {
                if (radioButton2.Checked)
                {
                    mark += 2;
                    total = mark;
                }
            }
            if (Form3.easy == 6 && q5 == 1)
            {
                if (radioButton2.Checked)
                {
                    mark += 2;
                    total = mark;
                }
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            q1 = 0;
            q2 = 0;
            q3 = 0;
            q4 = 0;
            q5 = 0;
            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            Form3.easy -= 1;
            if (Form3.easy == 1)
            {
                q1 += 1;
                label2.Text = "1. IN WHICH DIRECTION DOES THE SUNRISE?";
                radioButton1.Text = "EAST";
                radioButton2.Text = "WEST";
                radioButton3.Text = "NORTH";
                button2.Enabled = false;
            }
            if (Form3.easy == 2)
            {
                q2 += 1;
                label2.Text = "2. HOW MANY ZEROS ARE THERE IN THOUSAND?";
                radioButton1.Text = "THREE";
                radioButton2.Text = "FIVE";
                radioButton3.Text = "SIX";
            }
            if (Form3.easy == 3)
            {
                q3 += 1;
                label2.Text = "3. HOW MANY HOURS ARE THERE IN TWO DAYS?";
                radioButton1.Text = "42";
                radioButton2.Text = "48";
                radioButton3.Text = "44";
            }
            if (Form3.easy == 4)
            {
                q4 += 1;
                label2.Text = "4. HOW MANY MONTH OF THE YEAR HAVE 31 DAYS?";
                radioButton1.Text = "EIGHT";
                radioButton2.Text = "SEVEN";
                radioButton3.Text = "SIX";
            }
            if (Form3.easy == 5)
            {
                q5 += 1;
                label2.Text = "5. WHO WAS THE MAN TO WALK ON THE MOON FIRST?";
                radioButton1.Text = "ARNOLD";
                radioButton2.Text = "NEIL ARMSTRONG";
                radioButton3.Text = "JOHN WIKKY";
                button1.Enabled = true;
            }
            Form3.med -= 1;
            if (Form3.med == 1)
            {
                q1 += 1;
                label2.Text = "1. HOW MANY EQUAL SIDES AN ISOCHELES TRIANGLE HAVE?";
                radioButton1.Text = "3";
                radioButton2.Text = "2";
                radioButton3.Text = "1";
                button2.Enabled = false;
            }
            if (Form3.med == 2)
            {
                q2 += 1;
                label2.Text = "2. WHICH IS THE COLDEST LOCATION IN EARTH?";
                radioButton1.Text = "EAST ANTARTICA";
                radioButton2.Text = "AFRICA";
                radioButton3.Text = "NETHERLAND";
            }
            if (Form3.med == 3)
            {
                q3 += 1;
                label2.Text = "3. WHO DISCOVERED ELECTRICITY?";
                radioButton1.Text = "ABHRAHAM";
                radioButton2.Text = "FRANKLIN";
                radioButton3.Text = "EINSTEIN";
            }
            if (Form3.med == 4)
            {
                q4 += 1;
                label2.Text = "4. THE LARGEST DEMOCRACY IN THE WORLD?";
                radioButton1.Text = "CHINA";
                radioButton2.Text = "RUSSIA";
                radioButton3.Text = "INDIA";
            }
            if (Form3.med == 5)
            {
                q5 += 1;
                label2.Text = "5. WHAT COLOR SYMBOLIZES PEACE?";
                radioButton1.Text = "BLACK";
                radioButton2.Text = "PINK";
                radioButton3.Text = "WHITE";
                button4.Enabled = true;
                button2.Enabled = false;
            }
            Form3.hard -= 1;
            if (Form3.hard == 1)
            {
                q1 += 1;
                label2.Text = "1. WHO IS THE FOUNDER OF MICROSOFT?";
                radioButton1.Text = "STEVE HARVEY";
                radioButton2.Text = "PAUL ALTEN";
                radioButton3.Text = "BILL GATES";
                button2.Enabled = false;
            }
            if (Form3.hard == 2)
            {
                q2 += 1;
                label2.Text = "2. WHICH INSTRUMENT IS USED FOR MEASURING WING?";
                radioButton1.Text = "ALCHOMETER";
                radioButton2.Text = "ACTINOMETER";
                radioButton3.Text = "ANEMOMETER";
            }
            if (Form3.hard == 3)
            {
                q3 += 1;
                label2.Text = "3. WHO DISCOVERED ELECTRICITY?";
                radioButton1.Text = "ABHRAHAM";
                radioButton2.Text = "FRANKLIN";
                radioButton3.Text = "EINSTEIN";
            }
            if (Form3.hard == 4)
            {
                q4 += 1;
                label2.Text = "4. EDEN GARDEN CRICKET STADIUM IS IN?";
                radioButton1.Text = "DELHI";
                radioButton2.Text = "CALCUTTA";
                radioButton3.Text = "ASSAM";
            }
            if (Form3.hard == 5)
            {
                q5 += 1;
                label2.Text = "5. WHICH COUNTRY WILL HOST CRICKET WORLD CUP 2019?";
                radioButton1.Text = "SOUTH AFRICA";
                radioButton2.Text = "INDIA";
                radioButton3.Text = "ENGLAND";
                button5.Enabled = true;
            }
        }
         private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Form3.hard += 1;
            if (Form3.hard == 6 && q5 == 1)
            {
                if (radioButton3.Checked)
                {
                    mark += 2;
                    total = mark;
                }
            } Form3.med += 1;
            if (Form3.med == 6 && q5 == 1)
            {
                if (radioButton3.Checked)
                {
                    mark += 2;
                    total = mark;
                }
            }
            Form3.easy += 1;
            if (Form3.easy == 6 && q5 == 1)
            {
                if (radioButton2.Checked)
                {
                    mark += 2;
                    total = mark;
                }
            }
            Form5 arg = new Form5();
            arg.ShowDialog();
        }

         private void button4_Click(object sender, EventArgs e)
         {
             button2.Enabled = true;
             Form3.med += 1;
             if (Form3.med == 2)
             {
                 q2 += 1;
                 label2.Text = "2. WHICH IS THE COLDEST LOCATION IN EARTH?";
                 radioButton1.Text = "EAST ANTARTICA";
                 radioButton2.Text = "AFRICA";
                 radioButton3.Text = "NETHERLAND";
             }
             if (Form3.med == 3)
             {
                 q3 += 1;
                 label2.Text = "3. WHO DISCOVERED ELECTRICITY?";
                 radioButton1.Text = "ABHRAHAM";
                 radioButton2.Text = "FRANKLIN";
                 radioButton3.Text = "EINSTEIN";
             }
             if (Form3.med == 4)
             {
                 q4 += 1;
                 label2.Text = "4. THE LARGEST DEMOCRACY IN THE WORLD?";
                 radioButton1.Text = "CHINA";
                 radioButton2.Text = "RUSSIA";
                 radioButton3.Text = "INDIA";
             }
             if (Form3.med == 5)
             {
                 q5 += 1;
                 label2.Text = "5. WHAT COLOR SYMBOLIZES PEACE?";
                 radioButton1.Text = "BLACK";
                 radioButton2.Text = "PINK";
                 radioButton3.Text = "WHITE";
                 button4.Enabled = false;
             }
             if (Form3.med == 2 && q1 == 1)
             {
                 if (radioButton2.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             if (Form3.med == 3 && q2 == 1)
             {
                 if (radioButton1.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             if (Form3.med == 4 && q3 == 1)
             {
                 if (radioButton2.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             if (Form3.med == 5 && q4 == 1)
             {
                 if (radioButton3.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             if (Form3.med == 6 && q5 == 1)
             {
                 if (radioButton3.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             radioButton1.Checked = false;
             radioButton2.Checked = false;
             radioButton3.Checked = false;
         }

         private void button5_Click(object sender, EventArgs e)
         {
             button2.Enabled = true;
             Form3.hard += 1;
             if (Form3.hard == 2)
             {
                 q2 += 1;
                 label2.Text = "2. WHICH INSTRUMENT IS USED FOR MEASURING WIND?";
                 radioButton1.Text = "ALCHOMETER";
                 radioButton2.Text = "ACTINOMETER";
                 radioButton3.Text = "ANEMOMETER";
             }
             if (Form3.hard == 3)
             {
                 q3 += 1;
                 label2.Text = "3. WHO DISCOVERED ELECTRICITY?";
                 radioButton1.Text = "ABHRAHAM";
                 radioButton2.Text = "FRANKLIN";
                 radioButton3.Text = "EINSTEIN";
             }
             if (Form3.hard == 4)
             {
                 q4 += 1;
                 label2.Text = "4. EDEN GARDEN CRICKET STADIUM IS IN?";
                 radioButton1.Text = "DELHI";
                 radioButton2.Text = "CALCUTTA";
                 radioButton3.Text = "ASSAM";
             }
             if (Form3.hard == 5)
             {
                 button5.Enabled = false;
                 q5 += 1;
                 label2.Text = "5. WHICH COUNTRY WILL HOST CRICKET WORLD CUP 2019?";
                 radioButton1.Text = "SOUTH AFRICA";
                 radioButton2.Text = "INDIA";
                 radioButton3.Text = "ENGLAND";
                
             }
             if (Form3.hard == 2 && q1 == 1)
             {
                 if (radioButton3.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             if (Form3.hard == 3 && q2 == 1)
             {
                 if (radioButton3.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             if (Form3.hard == 4 && q3 == 1)
             {
                 if (radioButton2.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             if (Form3.hard == 5 && q4 == 1)
             {
                 if (radioButton2.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             if (Form3.hard == 6 && q5 == 1)
             {
                 if (radioButton2.Checked)
                 {
                     mark += 2;
                     total = mark;
                 }
             }
             radioButton1.Checked= false;
             radioButton2.Checked = false;
             radioButton3.Checked = false;
         }
         private void Form4_Load(object sender, EventArgs e)
         {
         }
    }
}
