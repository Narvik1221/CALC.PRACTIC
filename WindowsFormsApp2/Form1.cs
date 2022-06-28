﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
   
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        /// <summary>
        /// базовый метод для поддержки конструктора
        /// </summary>
        public Form1()
        {
            
            InitializeComponent();
        }
        /// <summary>
        /// метод, присваивающий 0 в дисплей калькулятора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        /// <summary>
        /// метод, реализующий проверку типов данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool StringIsDigits(string s)
        {
            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                    return false; 
            }
            return true; 
        }





        /// <summary>
        /// нопка, реализующая набор цифер 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";

            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }
        /// <summary>
        /// кнопка, реализующая очистку textBox'а
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        /// <summary>
        /// кнопка, выполняющая арифметические операции (+,-,*,/)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click_2(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }
        /// <summary>
        /// нопка, реализующая знак '=' для двух аргументов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click_3(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            string Calc_name;
            res = 0;

            
            if (StringIsDigits(N1) && StringIsDigits(textBox1.Text))
            {
               
                    dn1 = Convert.ToDouble(N1);
                    dn2 = Convert.ToDouble(textBox1.Text);
                
              

                if (D == "+")
                {
                    Calc_name = "Addition";
                    ITwoArgumentsCalculator calculator = TwoArgFactory.CreateCalculator(Calc_name);
                    res = calculator.Calculate(dn1, dn2);
                }
                else if (D == "-")
                {
                    Calc_name = "substract";
                    ITwoArgumentsCalculator calculator = TwoArgFactory.CreateCalculator(Calc_name);
                    res = calculator.Calculate(dn1, dn2);

                }
                else if (D == "*")
                {
                    Calc_name = "Multiplic";
                    ITwoArgumentsCalculator calculator = TwoArgFactory.CreateCalculator(Calc_name);
                    res = calculator.Calculate(dn1, dn2);
                }
                else if (D == "/")
                {
                    
                    Calc_name = "Division";

                    ITwoArgumentsCalculator calculator = TwoArgFactory.CreateCalculator(Calc_name);
                    try
                    {
                        res = calculator.Calculate(dn1, dn2);
                        if (dn2==0)
                        {
                            throw new Exception("Деление на 0");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                    finally
                    {
                        res = 0;
                    }
                    
                }
                else if (D == "Xcp.")
                {
                    Calc_name = "Sred";
                    ITwoArgumentsCalculator calculator = TwoArgFactory.CreateCalculator(Calc_name);
                    res = calculator.Calculate(dn1, dn2);
                }
                else if (D == "x^y")
                {
                    Calc_name = "Pow";
                    ITwoArgumentsCalculator calculator = TwoArgFactory.CreateCalculator(Calc_name);
                    res = calculator.Calculate(dn1, dn2);
                }
                else if (D == "x^(1/y)")
                {

                    Calc_name = "AntiPow";
                    ITwoArgumentsCalculator calculator = TwoArgFactory.CreateCalculator(Calc_name);
                    res = calculator.Calculate(dn1, dn2);
                }
                D = "=";
                n2 = true;
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "ошибка ввода";
            }

          
        }
        /// <summary>
        /// нопка, реализующая взятие корня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;
            if (StringIsDigits(textBox1.Text))
            {
                dn = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Sqrt");
                res = calculator.Calculate(dn);
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "ошибка ввода";
            }

        }
        /// <summary>
        /// кнопка обрабатывающая исключение при пустом textBox'е
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click_4(object sender, EventArgs e)
        {
            double dn, res=0;
            if (StringIsDigits(textBox1.Text))
            {
                try
                {   
                    if (textBox1.Text=="")
                    {
                        throw new Exception("Отсутствует значение");
                    }
                    dn = Convert.ToDouble(textBox1.Text);
                    
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                finally
                {
                    dn = 0;
                   
                    textBox1.Text = res.ToString();
                }



                
            }

            else
            {
                textBox1.Text = "ошибка ввода";
            }
        }
        /// <summary>
        /// Кнопка, реализующая возведение в (-1)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            double dn, res;
            if (StringIsDigits(textBox1.Text))
            {
                dn = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("OneDiv");
                res = calculator.Calculate(dn);
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "ошибка ввода";
            }
        }
        /// <summary>
        /// Кнопка, реализующая взятие косинуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            double dn, res;
            if (StringIsDigits(textBox1.Text))
            {
                dn = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Cos");
                res = calculator.Calculate(dn);
                textBox1.Text = res.ToString();
            }
            else {
                textBox1.Text = "ошибка ввода";
                    }
            
        }
        /// <summary>
        /// Кнопка, реализующая взятие логарифма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            double dn, res;
            if (StringIsDigits(textBox1.Text))
            {
                dn = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Ln");
                res = calculator.Calculate(dn);
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "ошибка ввода";
            }

        }
        /// <summary>
        /// Кнопка, реализующая взятие синуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click(object sender, EventArgs e)
        {
            double dn, res;
            if (StringIsDigits(textBox1.Text))
            {
                dn = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Sin");
                res = calculator.Calculate(dn);
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "ошибка ввода";
            }
        }
        /// <summary>
        /// Кнопка, реализующая взятие косинуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button27_Click(object sender, EventArgs e)
        {
            double dn, res;
            if (StringIsDigits(textBox1.Text))
            {
                dn = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Tan");
                res = calculator.Calculate(dn);
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "ошибка ввода";
            }

        }
        /// <summary>
        /// Кнопка, реализующая взятие кореня N-ой степени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button26_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button28_Click(object sender, EventArgs e)
        {
            double dn, res;
            if (StringIsDigits(textBox1.Text))
            {
                dn = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("ATan");
                res = calculator.Calculate(dn);
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "ошибка ввода";
            }

        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            double dn, res;
            if (StringIsDigits(textBox1.Text))
            {
                dn = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Pow2");
                res = calculator.Calculate(dn);
                textBox1.Text = res.ToString();
            }
            else
            {
                textBox1.Text = "ошибка ввода";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
            
               

            textBox1.Text = textBox1.Text.Replace(',', '.'); /// Постоянно заменяет в текстбоксе , на .

            
        }

      

        
    }
}
