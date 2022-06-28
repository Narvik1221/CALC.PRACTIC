using System;
namespace WindowsFormsApp2
{
    /// <summary>
    /// Описание интерфейса для фабрики с одним аргументом
    /// </summary>
    public interface ITwoArgumentsCalculator
    {
        double Calculate(double argumentOne, double argumentTwo);


    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с двумя аргументами с методом возвращающим вычитание аргументов
    /// </summary>
    public class SubtractionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => firstArg - secondArg;

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с двумя аргументами с методом возвращающим сложение аргументов
    /// </summary>
    public class AdditionalCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => firstArg + secondArg;

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с двумя аргументами с методом возвращающим деление аргументов
    /// </summary>
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => (firstArg / secondArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с двумя аргументами с методом возвращающим умножение аргументов
    /// </summary>
    public class MultiplicationCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => (firstArg * secondArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с двумя аргументами с методом возвращающим ср. арифм
    /// </summary>
    public class SredCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => (firstArg + secondArg) / 2;

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с двумя аргументами с методом возвращающим аргумент в N-ой степени
    /// </summary>
    public class PowCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => Math.Pow(firstArg, secondArg);

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с двумя аргументами с методом возвращающим корень N-ой степени
    /// </summary>
    public class AntiPowCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => Math.Pow(firstArg, (1 / secondArg));

    }
    /// <summary>
    /// класс, реализующий интерфейс для фабрики с двумя аргументами с методом возвращающим 0
    /// </summary>
    public class ZeroCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArg, double secondArg) => 0;

    }
    public static class TwoArgFactory
    {

        public static ITwoArgumentsCalculator CreateCalculator(string Calc_name)
        {

            if (Calc_name == "substract")
            {

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
}
