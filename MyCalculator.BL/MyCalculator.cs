using System;

namespace MyCalculator.BL
{
    public class MyCalculator
    {
        public int RoundDigits { get; }
        public MyCalculator(int roundDigits) // конструктор?
        // public MyCalculator(int roundDigits = 7) лайфхак от Сереги
        {
            RoundDigits = roundDigits;
        }

        public double Summ(double left, double right)
        {
            return Math.Round(left + right, RoundDigits);
        }
        public double Minus(double left, double right)
        {
            return left - right;
        }
        public double Dividirses(double left, double right)
        {
            return Math.Round(left / right, RoundDigits);
        }

        public double Multiplicacions(double left, double right)
        {
            return left * right;
        }
        public double Sqrt(double value)
        {
            return Math.Round( Math.Sqrt(value), RoundDigits);
        }
    }
}
