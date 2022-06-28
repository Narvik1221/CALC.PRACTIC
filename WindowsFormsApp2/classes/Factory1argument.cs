using System;
namespace WindowsFormsApp2 {

    /// <summary>
    /// Описание интерфейса для фабрики с одним аргументом
    /// </summary>
    public interface IOneArgumentsCalculator
    {
        double Calculate(double argumentOne);


    }

    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим косинус аргумента
    /// </summary>
    public class CosCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Cos(firstArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим логарифм аргумента
    /// </summary>
    public class LnCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Log(firstArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим корень аргумента
    /// </summary>
    public class SqrtCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Sqrt(firstArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим квадрат аргумента
    /// </summary>
    public class PowTwoCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Pow(firstArg, 2);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим степень (-1) аргумента
    /// </summary>
    public class OneDivisCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => (1 / firstArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим арктангенс аргумента
    /// </summary>
    public class ATanCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Atan(firstArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим тангенс аргумента
    /// </summary>
    public class TanCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Tan(firstArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим тангенс аргумента
    /// </summary>
    public class SinCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => Math.Sin(firstArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с одним аргументом с методом возвращающим тангенс аргумента
    /// </summary>
    public class ZeroOneCalculator : IOneArgumentsCalculator
    {
        public double Calculate(double firstArg) => 0;

    }
    /// <summary>
    /// фабрика, реализующая классы 
    /// </summary>
    static class OneArgFactory
    {
        /// <summary>
        /// создание классов в фабрике
        /// </summary>
        /// <param name="Calc_name"></param>
        /// <returns></returns>
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
