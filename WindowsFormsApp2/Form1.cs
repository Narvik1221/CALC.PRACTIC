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


        /// Интерфейсы

        public interface ITwoArgumentsCalculator
        {
            double Calculate(double argumentOne, double argumentTwo);
            

        }

        public interface IOneArgumentsCalculator
        {
            double Calculate(double argumentOne);


        }

        ///Конец  Интерфейсов


        ///Калькуляторы
        
        /// 2 аргументов
        public class SubtractionCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => firstArg - secondArg;

        }

        public class AdditionalCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => firstArg + secondArg;

        }

        public class DivisionCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => (firstArg / secondArg);

        }

        public class MultiplicationCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => (firstArg * secondArg);

        }

        public class SredCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => (firstArg + secondArg) / 2;

        }

        public class PowCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => Math.Pow(firstArg, secondArg);

        }
        public class AntiPowCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => Math.Pow(firstArg, (1 / secondArg));

        }
        public class ZeroCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double firstArg, double secondArg) => 0;

        }


        /// 1 аргумента
        public class CosCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => Math.Cos(firstArg);

        }
        public class LnCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => Math.Log(firstArg);

        }
        public class SqrtCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => Math.Sqrt(firstArg);

        }
        public class PowTwoCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => Math.Pow(firstArg,2);

        }
        public class OneDivisCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => (1/firstArg);

        }
        public class ATanCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => Math.Atan(firstArg);

        }
        public class TanCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => Math.Tan(firstArg);

        }
        public class SinCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => Math.Sin(firstArg);

        }
        public class ZeroOneCalculator : IOneArgumentsCalculator
        {
            public double Calculate(double firstArg) => 0;

        }
        ///Конец калькуляторов



        ///Фабрики
        static class TwoArgFactory
        {

            internal static ITwoArgumentsCalculator CreateCalculator(string Calc_name)
            {

                if (Calc_name == "substract") {

                    return new SubtractionCalculator();

                }
                else if (Calc_name == "Multiplic")
                {
                    return new MultiplicationCalculator();
                }
                else if (Calc_name == "Division")
                {
                    return new DivisionCalculator();
                }
                else if (Calc_name == "Addition")
                {
                    return new AdditionalCalculator();
                }
                else if (Calc_name == "Pow")
                {
                    return new PowCalculator();
                }
                else if (Calc_name == "AntiPow")
                {
                    return new AntiPowCalculator();
                }
                else if (Calc_name == "Sred")
                {
                    return new SredCalculator();
                }
                else
                {
                    return new ZeroCalculator();
                }
                
                
            }
        }


        static class OneArgFactory
        {

            internal static IOneArgumentsCalculator CreateCalculator(string Calc_name)
            {

                if (Calc_name == "Cos")
                {

                    return new CosCalculator();

                }
                else if (Calc_name == "Ln")
                {
                    return new LnCalculator();
                }
                else if (Calc_name == "Sqrt")
                {
                    return new SqrtCalculator();
                }
                else if (Calc_name == "Pow2")
                {
                    return new PowTwoCalculator();
                }
                else if (Calc_name == "OneDiv")
                {
                    return new OneDivisCalculator();
                }
                else if (Calc_name == "ATan")
                {
                    return new ATanCalculator();
                }
                else if (Calc_name == "Tan")
                {
                    return new TanCalculator();
                }
                else if (Calc_name == "Sin")
                {
                    return new SinCalculator();
                }
                else
                {
                    return new ZeroOneCalculator();
                }


            }
        }

        ///Конец фабрик







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
