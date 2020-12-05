using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace transformare
{
    public partial class Form1 : Form
    {

        string convert(int i, string A, string B, string C)
        {
            string tor = "";
            switch (i)
            {
                case 1: tor += A; break;
                case 2: tor += A + A; break;
                case 3: tor += A + A + A; break;
                case 4: tor += A + B; break;
                case 5: tor += B; break;
                case 6: tor += B + A; break;
                case 7: tor += B + A + A; break;
                case 8: tor += B + A + A + A; break;
                case 9: tor += A + C; break;
            }
            return tor;
        }

        string convert_numeral(int a)
        {
            int[] v = new int[5];
            int i = 0;
            while (a != 0)
            {
                v[i] = a % 10;
                a /= 10;
                i++;
            }

            string tor = "";
            tor += convert(v[4], "[X]", "NULL", "NULL");
            tor += convert(v[3], "M", "[V]", "[X]");
            tor += convert(v[2], "C", "D", "M");
            tor += convert(v[1], "X", "L", "C");
            tor += convert(v[0], "I", "V", "X");
            return tor;
        }

        int dd = -1;
        int mm = -1;
        int yy = -1;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            try { mm = (int)numericUpDown1.Value; }
                catch{}
            try { dd = int.Parse(textBox3.Text); }
                catch { }
            try { yy = int.Parse(textBox2.Text); }
                catch { }

            if (dd == -1 && mm == -1 && yy == -1)
            {
                listBox1.Items.Add("Answer");
                listBox1.Items.Add("Enter at least one value for month, day or year.");
            }
            else 
            {

                
                bool ddok = false;
                bool mmok = false;
                bool yyok = false;

                if (dd >= 1 && dd <= 31)
                    ddok = true;
                if (mm >= 1 && mm <= 12)
                    mmok = true;
                if (yy >= 1 && yy <= 39999)
                    yyok = true;

                if (ddok && mmok && yyok)
                {
                    string output = "";
                    string separator = "";
                    string dd_ = convert_numeral(dd);
                    string mm_ = convert_numeral(mm);
                    string yy_ = convert_numeral(yy);


                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            separator = ".";
                            break;
                        case 1:
                            separator = "/";
                            break;

                    }

                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            output = mm_ + separator + dd_ + separator + yy_;
                            break;
                        case 1:
                            output = dd_ + separator + mm_ + separator + yy_;
                            break;
                        case 2:
                            output = yy_ + separator + mm_ + separator + dd_;
                            break;
                    }

                    listBox1.Items.Add("Answer : ");
                    listBox1.Items.Add("\t" + output);

                    
                }
                else 
                {
                    if (!mmok)
                        listBox1.Items.Add("Enter a valid month from 1 to 12");
                    if (!ddok)
                        listBox1.Items.Add("Enter a valid day from 1 to 31");
                    if (!yyok)
                        listBox1.Items.Add("Enter a valid year from 1 to 3999");
                }


            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Font = new System.Drawing.Font("Courier New", 12, FontStyle.Regular);

            comboBox1.Items.Add("MM.DD.YYYY (US)");
            comboBox1.Items.Add("DD.MM.YYYY (Europe)");
            comboBox1.Items.Add("YYYY.MM.DD (ISO)");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add(". (dot)");
            comboBox2.Items.Add("/ (slash)");
            comboBox2.SelectedIndex = 0;

            numericUpDown1.Maximum = 12;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = 1;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
