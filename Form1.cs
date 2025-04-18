using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVS_proj2
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


        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        bool operation_button_clicked = false;
        char operation = ' ';

        private void button_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "1";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "2";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "3";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "4";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "5";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)   
            {
                textBox1.Text = "6";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "7";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "8";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "9";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)   
            {
                textBox1.Text = "0";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button_00_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "00";
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "00";
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            textBox2.Text = "";

        }
        private void button_Clear_Entry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                string first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                double first_number = Convert.ToDouble(first_num);
                double second_number = Convert.ToDouble(textBox1.Text);
                if (operation == '+')
                {
                    double result = first_number + second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "+";
                }
                else if (operation == '-')
                {
                    double result = first_number - second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "-";
                }
                else if (operation == '*')
                {
                    double result = first_number * second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "*";
                }
                else if (operation == '÷')
                {
                    double result = first_number / second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "÷";
                }
            }
            textBox2.Text = textBox1.Text + "+";
            operation_button_clicked = true;
            operation = '+';
        }
        private void button_Substract_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                string first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                double first_number = Convert.ToDouble(first_num);
                double second_number = Convert.ToDouble(textBox1.Text);
                if (operation == '+')
                {
                    double result = first_number + second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "+";
                }
                else if (operation == '-')
                {
                    double result = first_number - second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "-";
                }
                else if (operation == '*')
                {
                    double result = first_number * second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "*";
                }
                else if (operation == '÷')
                {
                    double result = first_number / second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "÷";
                }
            }
            textBox2.Text = textBox1.Text + "-";
            operation_button_clicked = true;
            operation = '-';
        }
        private void button_Multiply_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                string first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                double first_number = Convert.ToDouble(first_num);
                double second_number = Convert.ToDouble(textBox1.Text);
                if (operation == '+')
                {
                    double result = first_number + second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "+";
                }
                else if (operation == '-')
                {
                    double result = first_number - second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "-";
                }
                else if (operation == '*')
                {
                    double result = first_number * second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "*";
                }
                else if (operation == '÷')
                {
                    double result = first_number / second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "÷";
                }
            }
            textBox2.Text = textBox1.Text + "*";
            operation_button_clicked = true;
            operation = '*';
        }
        private void button_Divide_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                string first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                double first_number = Convert.ToDouble(first_num);
                double second_number = Convert.ToDouble(textBox1.Text);
                if (operation == '+')
                {
                    double result = first_number + second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "+";
                }
                else if (operation == '-')
                {
                    double result = first_number - second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "-";
                }
                else if (operation == '*')
                {
                    double result = first_number * second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "*";
                }
                else if (operation == '÷')
                {
                    double result = first_number / second_number;
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox1.Text + "÷";
                }
            }
            textBox2.Text = textBox1.Text + "÷";
            operation_button_clicked = true;
            operation = '÷';
        }
        private void button_Factorial_Click(object sender, EventArgs e)
        {

        }

        private void button_Power_Click(object sender, EventArgs e)
        {

        }

        private void button_Square_Root_Click(object sender, EventArgs e)
        {
            textBox2.Text = "√" + "("+textBox1.Text+")";
            double value = Convert.ToDouble(textBox1.Text);
            double sq_ro_value = Math.Sqrt(value);
            textBox1.Text = sq_ro_value.ToString();
        }

        private void button_Absolute_Click(object sender, EventArgs e)
        {
            textBox2.Text = "|" + textBox1.Text + "|";
            double value = Convert.ToDouble(textBox1.Text);
            double abs_value = Math.Abs(value);
            textBox1.Text = abs_value.ToString();
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            string first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            double first_number = Convert.ToDouble(first_num);
            double second_number = Convert.ToDouble(textBox1.Text);
            if (operation == '+')
            {
                double result = first_number + second_number;
                textBox1.Text = result.ToString();
                textBox2.Text = first_number + "+" + second_number + "=";
            }
            else if (operation == '-')
            {
                double result = first_number - second_number;
                textBox1.Text = result.ToString();
                textBox2.Text = first_number + "-" + second_number + "=";
            }
            else if (operation == '*')
            {
                double result = first_number * second_number;
                textBox1.Text = result.ToString();
                textBox2.Text = first_number + "*" + second_number + "=";
            }
            else if (operation == '÷')
            {
                double result = first_number / second_number;
                textBox1.Text = result.ToString();
                textBox2.Text = first_number + "÷" + second_number + "=";
            }
            operation_button_clicked = true;
        }

        
        

    }
}
