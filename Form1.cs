using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<listheader>Hlavní stránka</listheader>
/// <summary>
/// Hlavní formulář kalkulačky
/// Obsahuje logiku pro zadávání čísel, provádění všech funkcí
/// </summary>


/** @author Filip Bilek
 *  @author Alex Oľšavský
 *  @author Martin Hora
 *  @author Jaroslav Vančura
 */
namespace IVS_proj2
{

    
    public partial class Form1 : Form
    {
        /// <summary>
        /// Inicializace komponent formuláře
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Nastaví vlastnosti formuláře po načtení
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.MinimumSize = new Size(350, 490);
            this.MaximumSize = new Size(350, 490);
            

        }

        
        /// <summary>
        /// Určuje, jestli bylo stisknuto tlačítko
        /// </summary>
        bool operation_button_clicked = false;

        /// <summary>
        /// Aktuální operace
        /// </summary>
        char operation = ' ';

        /// <summary>
        ///Má na starosti kliknutí na tlačítko čísla
        ///Přidá číslo do textBox1
        /// </summary>
        /// <param name="tlačítko, které bylo stlačeno"></param>
        /// <param name="Data o kliknutí na tlačítko"></param>
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = btn.Text;
                operation_button_clicked = false;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        /// <summary>
        /// tlačítko, které po stlačení přidá číslici "1" do textbox1
        /// </summary>
        /// <param name="tlačítko, které bylo stlačeno"></param>
        /// <param name="Data o kliknutí na tlačítko"></param>
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

        private void button_decimal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_button_clicked)
            {
                textBox1.Text = "0,";
                operation_button_clicked = false;
            }
            else if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        /// <summary>
        /// tlačítko které vymaže výsledek a nastaví nulu do výpočtu
        /// </summary>
        /// <param name="stlačené tlačítko"></param>
        /// <param name="Data o kliknutí na tlačítko"></param>
        private void button_Clear_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            textBox2.Text = "";

        }
        private void button_Clear_Entry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

       /// <summary>
       /// Nastaví operaci sčítání
       /// </summary>
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 || textBox2.Text.Contains("="))
            {
                textBox2.Text = textBox1.Text + "+"; 
                operation = '+';
                operation_button_clicked = true;
                return;
            }

            if (textBox2.Text.Length > 0)
            {
                string first_num;
                double first_number;
                if (operation == 'a' || operation == '√')
                {
                    first_num = textBox1.Text.Substring(0, textBox1.Text.Length);
                    first_number = Convert.ToDouble(first_num);
                }
                else
                {
                    first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    first_number = Convert.ToDouble(first_num);
                }    
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
            if (textBox2.Text.Length == 0 || textBox2.Text.Contains("="))
            {
                textBox2.Text = textBox1.Text + "-";
                operation = '-';
                operation_button_clicked = true;
                return;
            }

            if (textBox2.Text.Length > 0)
            {
                string first_num;
                double first_number;
                if (operation == 'a' || operation == '√')
                {
                    first_num = textBox1.Text.Substring(0, textBox1.Text.Length);
                    first_number = Convert.ToDouble(first_num);
                }
                else
                {
                    first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    first_number = Convert.ToDouble(first_num);
                }
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
            if (textBox2.Text.Length == 0 || textBox2.Text.Contains("="))
            {
                textBox2.Text = textBox1.Text + "*";
                operation = '*';
                operation_button_clicked = true;
                return;
            }

            if (textBox2.Text.Length > 0)
            {
                string first_num;
                double first_number;
                if (operation == 'a' || operation == '√')
                {
                    first_num = textBox1.Text.Substring(0, textBox1.Text.Length);
                    first_number = Convert.ToDouble(first_num);
                }
                else
                {
                    first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    first_number = Convert.ToDouble(first_num);
                }
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
            if (textBox2.Text.Length == 0 || textBox2.Text.Contains("="))
            {
                textBox2.Text = textBox1.Text + "÷";
                operation = '÷';
                operation_button_clicked = true;
                return;
            }

            if (textBox2.Text.Length > 0)
            {
                string first_num;
                double first_number;
                if (operation == 'a' || operation == '√')
                {
                    first_num = textBox1.Text.Substring(0, textBox1.Text.Length);
                    first_number = Convert.ToDouble(first_num);
                }
                else
                {
                    first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                    first_number = Convert.ToDouble(first_num);
                }
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
        /// <summary>
        /// Počítá faktoríál a výsledek zobrazuje na textoboxu 1
        /// </summary>
        /// <param name="tlačítko faktoriálu"></param>
        /// <param name="Data o kliknutí na tlačítko"></param>
        private void button_Factorial_Click(object sender, EventArgs e)
        {
            int number;
            bool isValid = int.TryParse(textBox1.Text, out number);

            if (!isValid || number < 0)
            {
                return;
            }

            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            textBox2.Text = number + "!";
            textBox1.Text = result.ToString();
        }

        private void button_Power_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + "^";
            operation_button_clicked = true;
            operation = '^';
        }

        private void button_Square_Root_Click(object sender, EventArgs e)
        {
            textBox2.Text = "√" + "(" + textBox1.Text + ")";
            double value = Convert.ToDouble(textBox1.Text);
            double sq_ro_value = Math.Sqrt(value);
            textBox1.Text = sq_ro_value.ToString();
            operation_button_clicked = true;
            operation = '√';
        }

        private void button_Absolute_Click(object sender, EventArgs e)
        {
            textBox2.Text = "|" + textBox1.Text + "|";
            double value = Convert.ToDouble(textBox1.Text);
            double abs_value = Math.Abs(value);
            textBox1.Text = abs_value.ToString();
            operation_button_clicked = true;
            operation = 'a';
        }
        /// <summary>
        /// Vypočítá výsledek
        /// </summary>
       
        private void button_Result_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 2)
            {
                textBox2.Text = textBox1.Text + "=";   
            }
            double second_number = Convert.ToDouble(textBox1.Text);
            double first_number = 0;
            if (operation != '=')
            {
                string first_num = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                first_number = Convert.ToDouble(first_num); ///ANI PIČU TO NENI FIXLE hahaha
            }
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
            else if (operation == '^')
            {
                double result = Math.Pow(first_number, second_number);
                textBox1.Text = result.ToString();
                textBox2.Text = first_number + "^" + second_number + "=";
            }
            else if (operation == '=')
            {
                textBox1.Text = second_number.ToString();
                textBox2.Text = second_number + "=";
            }
            operation_button_clicked = true;
            operation = '=';
        }

        /// <summary>
        /// Metoda pro registraci vstupu pomocí klávesnice
        /// </summary>
        /// <param name="klávesnice"></param>
        /// <param name="konkrétní klávesa"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                button_0_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                button_1_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                button_2_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                button_3_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                button_4_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                button_5_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                button_6_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                button_7_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                button_8_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                button_9_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.Add || (e.Shift && e.KeyCode == Keys.Oemplus))
                button_Add_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                button_Substract_Click(null, EventArgs.Empty);

            /////////////NEFUNGUJE NASOBENI///////////////
            else if (e.KeyCode == Keys.Multiply || (e.Shift && e.KeyCode == Keys.D8))
                button_Multiply_Click(null, EventArgs.Empty); 


            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion || e.KeyCode == Keys.Oem5)
                button_Divide_Click(null, EventArgs.Empty);


            else if ((e.KeyCode == Keys.Oemplus && !e.Shift) || e.KeyCode == Keys.Enter)
                button_Result_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.Back)
                button_Clear_Entry_Click(null, EventArgs.Empty);


            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Oemcomma)
                button_decimal_Click(null, EventArgs.Empty);


        }
    } 



}
           
