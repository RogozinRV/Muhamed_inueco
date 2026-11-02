using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calc;

namespace calc;

public static class Class1
{
    public static void Main(string[] args)
    {
        Start();
    }

    public static void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nГлавное меню:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Остаток от деления");
            Console.WriteLine("6. Минимум");
            Console.WriteLine("7. Максимум");
            Console.WriteLine("8. Перевод в проценты");
            Console.WriteLine("9. Из процентов");
            Console.WriteLine("10. Квадрат");
            Console.WriteLine("11. Куб");
            Console.WriteLine("12. Квадратный корень");
            Console.WriteLine("13. Кубический корень");
            Console.WriteLine("0. Выход");

            Console.Write("\nВыбор: ");
            string choice = Console.ReadLine() ?? string.Empty;
            Console.WriteLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        double[] addNums = ReadArray("Числа через пробел: ");
                        Console.WriteLine($"= {Operations.Add(addNums)}");
                        break;

                    case "2":
                        double aSub = ReadDouble("Первое число: ");
                        double bSub = ReadDouble("Второе число: ");
                        Console.WriteLine($"= {Operations.Subtract(aSub, bSub)}");
                        break;

                    case "3":
                    case "III":
                        double[] multNums = ReadArray("Числа через пробел: ");
                        Console.WriteLine($"= {Operations.Multiply(multNums)}");
                        break;

                    case "4":
                        double aDiv = ReadDouble("Делимое: ");
                        double bDiv = ReadDouble("Делитель: ");
                        Console.WriteLine($"= {Operations.Divide(aDiv, bDiv)}");
                        break;

                    case "5":
                        double aMod = ReadDouble("Первое число: ");
                        double bMod = ReadDouble("Второе число: ");
                        Console.WriteLine($"= {Operations.Modulo(aMod, bMod)}");
                        break;

                    case "6":
                        double[] minNums = ReadArray("Числа через пробел: ");
                        Console.WriteLine($"= {Operations.Minimum(minNums)}");
                        break;

                    case "7":
                        double[] maxNums = ReadArray("Числа через пробел: ");
                        Console.WriteLine($"= {Operations.Maximum(maxNums)}");
                        break;

                    case "8":
                        double pTo = ReadDouble("Число: ");
                        Console.WriteLine($"= {Operations.ToPercent(pTo)}");
                        break;

                    case "9":
                        double pFrom = ReadDouble("Число: ");
                        Console.WriteLine($"= {Operations.FromPercent(pFrom)}");
                        break;

                    case "10":
                        double sqVal = ReadDouble("Число: ");
                        Console.WriteLine($"= {Operations.Square(sqVal)}");
                        break;

                    case "11":
                        double cubeVal = ReadDouble("Число: ");
                        Console.WriteLine($"= {Operations.Cube(cubeVal)}");
                        break;

                    case "12":
                        double sqrtVal = ReadDouble("Число: ");
                        Console.WriteLine($"= {Operations.SquareRoot(sqrtVal)}");
                        break;

                    case "13":
                        double cbrtVal = ReadDouble("Число: ");
                        Console.WriteLine($"= {Operations.CubeRoot(cbrtVal)}");
                        break;

                    case "0":
                        running = false;
                        Console.WriteLine("Выход.");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            if (running)
            {
                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }

    private static double[] ReadArray(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrEmpty(input))
        {
            return new double[0];
        }

        return input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
    }

    private static double ReadDouble(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("Введено пустое значение.");
        }

        return double.Parse(input);
    }
}