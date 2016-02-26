using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proteinSequence
{
    public partial class Form1 : Form
    {
        string[,] a = new string[,]
            {
                {"A","ACGILMFPSV"},
                {"R","REQHK"},
                {"N","NDCEQHMPST"},
                {"D","NDEQH"},
                {"C","ANCLMFS"},
                {"E","RNDEQHK"},
                {"Q","RNDEQHKMS"},
                {"G","AGLMPSV"},
                {"H","RNDEQHKWY"},
                {"I","AILMFPV"},
                {"L","ACGILMFPV"},
                {"K","REQHK"},
                {"M","ANCGILMFPWV"},
                {"F","ACILMFPWYV"},
                {"P","ANGILMFPWV"},
                {"S","ANCQGSTY"},
                {"T","NST"},
                {"W","HMFWY"},
                {"Y","HFSWY"},
                {"V","AGILMFPV"}
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;

                String outputStr1 = System.Text.RegularExpressions.Regex.Replace(textBox1.Text, @"[^a-zA-Z//]", "").ToUpperInvariant();
                String outputStr2 = System.Text.RegularExpressions.Regex.Replace(textBox2.Text, @"[^a-zA-Z//]", "").ToUpperInvariant();

                char[] ch1 = (outputStr1).ToCharArray();
                char[] ch2 = (outputStr2).ToCharArray();

            //char[] ch1 = (textBox1.Text).ToCharArray();
            //char[] ch2 = (textBox2.Text).ToCharArray();

            if (ch1.Length == ch2.Length)
            {
               
                for (int i = 0; i < ch1.Length; i++)
                {
                    if(ch1[i] == ch2[i])
                    {
                        flag ++;
                    }

                    else 
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                if (ch1[i] == Convert.ToChar(a[j, 0]))
                                { 
                                char[] ch3 = a[j,1].ToCharArray();
                                for (int k = 0; k < ch3.Length; k++)
                                { 
                                if(ch2[i] == ch3[k])
                                {
                                    flag++;
                                }
                                }
                                }
                            }
                        }

                }
                if (flag == ch1.Length)
                {
                    MessageBox.Show("true");
                    //MessageBox.Show(Convert.ToString(a.Length));
                }
                else
                {
                    MessageBox.Show("false");
                }
            }
            else
            {
                MessageBox.Show("enter equal length protein sequences!");
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
