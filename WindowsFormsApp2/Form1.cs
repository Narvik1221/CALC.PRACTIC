using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
   
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// лишний код
        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double DivisionOne(double a)
        {
            return (1 / a);
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double FuncPow(double a, double b=2)
        {
            return Math.Pow(a, b); 
        }

        public double FuncSqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public double FuncSqrtn(double a, double b)
        {
            return Math.Pow(a, (1 / b));
        }

        public double FuncTan(double a)
        {
            return Math.Tan(a);
        }

        public double FuncAtan(double a)
        {
            return Math.Atan(a);
        }

        public double FuncSin(double a)
        {
            return Math.Sin(a);
        }
        public double FuncLog(double a)
        {
            return Math.Log(a);
        }
        public double FuncCos(double a)
        {
            return Math.Cos(a);
        }

        public double SredZnach(double a,double b)
        {
            return (a + b) / 2;
        }
        /// конец лишний код




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

        private void Form1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Click_2(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void Form1_Click_3(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            string Calc_name;
            res = 0;

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
                res = calculator.Calculate(dn1, dn2);
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

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;
            
            dn = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Sqrt");
            res = calculator.Calculate(dn);
            textBox1.Text = res.ToString();
        }

        private void Form1_Click_4(object sender, EventArgs e)
        {
            double dn, res;
            
            dn = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Pow2");
            res = calculator.Calculate(dn);
            textBox1.Text = res.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn, res;
            
            dn = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("OneDiv");
            res = calculator.Calculate(dn);
            textBox1.Text = res.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Cos");
            res = calculator.Calculate(dn);
            textBox1.Text = res.ToString();
            
        }
        ///
        private void button16_Click(object sender, EventArgs e)
        {
            double dn, res;
           
            dn = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Ln");
            res = calculator.Calculate(dn);
            textBox1.Text = res.ToString();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Sin");
            res = calculator.Calculate(dn);
            textBox1.Text = res.ToString();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("Tan");
            res = calculator.Calculate(dn);
            textBox1.Text = res.ToString();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;

        }

        private void button28_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgFactory.CreateCalculator("ATan");
            res = calculator.Calculate(dn);
            textBox1.Text = res.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
