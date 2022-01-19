using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RETEZEC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string text = textBox1.Text;
                text = text.Trim();

                bool x = false;
                int i = 0;
                while (i < text.Length)
                {
                    if (text[i] == ' ')
                    {
                        if (x == true)
                        {
                            text = text.Remove(i, 1);
                        }
                        else
                        {
                            x = true;
                            i++;
                        }
                    }
                    else
                    {
                        x = false;
                        i++;
                    }
                }
                MessageBox.Show("Text bez vice mezer je: " + text);
            }
        }
    }
}
