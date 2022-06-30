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
            switch (Calc_name)
            {
                case "substract":
                    return new SubtractionCalculator();
                case "Multiplic":
                    return new MultiplicationCalculator();
                case "Division":
                    return new DivisionCalculator();
                case "Addition":
                    return new AdditionalCalculator();
                case "Pow":
                    return new PowCalculator();
                case "AntiPow":
                    return new AntiPowCalculator();
                case "Sred":
                    return new SredCalculator();
                default:
                    return new ZeroCalculator();
            }

            
            

        }
    }
}
