using System;
namespace WindowsFormsApp2 {


    public interface IOneArgumentsCalculator
    {
        double Calculate(double argumentOne);


    }


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
        public double Calculate(double firstArg) => Math.Pow(firstArg, 2);

    }
    public class OneDivisCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => (1 / firstArg);

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

  
}
