using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Class1 MathClass = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            res = 0;

            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res= MathClass.Addition(dn1,dn2);
            }
            else if (D == "-")
            {
                res = MathClass.Subtraction(dn1, dn2);
            }
            else if (D == "*")
            {
                res = MathClass.Multiplication(dn1, dn2);
            }
            else if (D == "/")
            {
                res = MathClass.Division(dn1, dn2);
            }
            else if (D == "Xcp.")
            {
                res = MathClass.SredZnach(dn1,dn2);
            }
            else if (D == "x^y")
            {
                res = MathClass.FuncPow(dn1,dn2);
            }
            else if (D == "x^(1/y)")
            {
                
                res = MathClass.FuncSqrtn(dn1,dn2);
            }

            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double dn, res;
            
            dn = Convert.ToDouble(textBox1.Text);
            res = MathClass.FuncSqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void Form1_Click_4(object sender, EventArgs e)
        {
            double dn, res;
            
            dn = Convert.ToDouble(textBox1.Text);
            res = MathClass.FuncPow(dn);
            textBox1.Text = res.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn, res;
            
            dn = Convert.ToDouble(textBox1.Text);
            res = MathClass.DivisionOne(dn);
            textBox1.Text = res.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = MathClass.FuncCos(dn);
            textBox1.Text = res.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double dn, res;
           
            dn = Convert.ToDouble(textBox1.Text);
           
            res = MathClass.FuncLog(dn);
            textBox1.Text = res.ToString();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);

            res = MathClass.FuncSin(dn);
            textBox1.Text = res.ToString();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);

            res = MathClass.FuncTan(dn);
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


            res = MathClass.FuncAtan(dn);
            textBox1.Text = res.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
