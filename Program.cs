
using System;
using System.Text;

class Program
{
    // Введення та перевірка цілого числа
    static int InputInt(string message)
    {
        int value;

        while (true)
        {
            Console.Write(message);

            if (int.TryParse(Console.ReadLine(), out value))
                return value;

            Console.WriteLine("Помилка! Введіть ціле число.");
        }
    }

    // Рекурсивне обчислення НСД за алгоритмом Евкліда
    static long GCD(long a, long b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        if (b == 0)
            return a;

        return GCD(b, a % b);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Варіант 7. Знаходження НСД");
        Console.WriteLine();

        int a = InputInt("Введіть перше число: ");
        int b = InputInt("Введіть друге число: ");

        long result = GCD(a, b);

        Console.WriteLine();
        Console.WriteLine($"Найбільший спільний дільник: {result}");
    }
}
