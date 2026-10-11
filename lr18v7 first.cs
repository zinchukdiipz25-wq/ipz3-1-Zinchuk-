
using System;
using System.Text;

class Program
{
    // Введення та перевірка числа
    static double InputDouble(string message)
    {
        double value;

        while (true)
        {
            Console.Write(message);

            if (double.TryParse(Console.ReadLine(), out value) &&
                !double.IsNaN(value) &&
                !double.IsInfinity(value))
            {
                return value;
            }

            Console.WriteLine("Помилка! Введіть коректне число.");
        }
    }

    // Обчислення висоти м'яча
    static double CalculateHeight(double y0, double v0, double g, double t)
    {
        return y0 + v0 * t - g * t * t / 2;
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Варіант 7. Рух м'яча вертикально вгору");
        Console.WriteLine();

        double y0 = InputDouble("Початкова висота y0 (м) = ");
        double v0 = InputDouble("Початкова швидкість v0 (м/с) = ");
        double g = InputDouble("Прискорення вільного падіння g (м/с^2) = ");

        if (g <= 0)
        {
            Console.WriteLine("Помилка: g має бути більшим за нуль.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Результати обчислень:");

        for (int t = 1; t <= 3; t++)
        {
            double y = CalculateHeight(y0, v0, g, t);
            Console.WriteLine($"Через {t} с: y = {y:F2} м");
        }
    }
}
