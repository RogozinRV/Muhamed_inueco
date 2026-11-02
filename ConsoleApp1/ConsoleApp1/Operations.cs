using System;
using System.Linq;

namespace calc;
public static class Operations
{
    public static double Add(double[] numbers)
    {
        double sum = 0;
        foreach (var n in numbers)
        { sum += n; }
        return sum;
    }

    public static double Subtract(double a, double b)
    {
        return (a - b);
    }

    public static double Multiply(double[] numbers)
    {
        double mult = 1;
        foreach (var n in numbers)
        { mult *= n; }
        return mult;
    }
    public static double Divide(double a, double b)
        { return (a / b); }
    public static double Modulo(double a, double b)
    { return (a % b); }

    public static double Minimum(double[] numbers)
    { return numbers.Min(); }

    public static double Maximum(double[] numbers)
    { return numbers.Max(); }

    public static double ToPercent(double value)
        { return value / 100.0; }
    
    public static double FromPercent(double value)
    { return value * 100.0; }

    public static double Square(double value)
    { return Math.Sqrt(value); }

    public static double Cube(double value)
    { return Math.Pow(value, 3); }

    public static double SquareRoot(double value)
        { return Math.Sqrt(value); }
    
    public static double CubeRoot(double value)
    { return Math.Cbrt(value); }
}