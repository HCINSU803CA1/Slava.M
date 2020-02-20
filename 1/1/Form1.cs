using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double[] Array;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string first = textBox1.Text;
          

            if ((!textBox1.Text.Equals("")) && (!textBox1.Text.Equals("=")))
            {
                Array = new double[2];
                first.Replace(" ", "");

                string[] s = first.Split('+');
                string[] k = first.Split('*');
                string[] g = first.Split('/');
                string[] h = first.Split('-');
                if (first.Contains('+'))
                {
                    foreach (var text in s)
                    {
                        if (text != "")
                        {
                            var number = double.Parse(text.Replace("=", ""));

                            if (Array[0] == 0)
                            {
                                Array[0] = number;
                            }
                            else
                            {
                                Array[1] = number;
                            }
                            Console.WriteLine(Array[0]);
                        }
                    }

                    if (first.EndsWith("="))
                    {
                        Console.WriteLine(Array[0] + Array[1]);
                    }
                }
                else if (first.Contains('*'))
                {
                    foreach (var text in k)
                    {
                        if (text != "")
                        {
                            var number = double.Parse(text.Replace("=", ""));

                            if (Array[0] == 0)
                            {
                                Array[0] = number;
                            }
                            else
                            {
                                Array[1] = number;
                            }
                            Console.WriteLine(Array[0]);
                        }
                        if (first.EndsWith("="))
                        {
                            Console.WriteLine(Array[0] * Array[1]);
                        }
                    }
                }
                else if (first.Contains('/'))
                {
                    foreach (var text in g)
                    {
                        if (text != "")
                        {
                            var number = double.Parse(text.Replace("=", ""));

                            if (Array[0] == 0)
                            {
                                Array[0] = number;
                            }
                            else
                            {
                                Array[1] = number;
                            }
                            Console.WriteLine(Array[0]);
                        }
                        if (first.EndsWith("="))
                        {
                            Console.WriteLine(Array[0] / Array[1]);
                        }
                    }
                }
                else
                {
                    foreach (var text in h)
                    {
                        if (text != "")
                        {
                            var number = double.Parse(text.Replace("=", ""));

                            if (Array[0] == 0)
                            {
                                Array[0] = number;
                            }
                            else
                            {
                                Array[1] = number;
                            }
                            Console.WriteLine(Array[0]);
                        }
                        if (first.EndsWith("="))
                        {
                            Console.WriteLine(Array[0] - Array[1]);
                        }
                    }
                }
                



            }

        }
    }
}
