using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
            double num1, num2;

            while (true)
            {
                Console.Write("Введіть перше число: ");
                if (double.TryParse(Console.ReadLine(), out num1))
                    break;
                else
                    Console.WriteLine("Помилка");
            }
            while (true)
            {
                Console.Write("Введіть друге число: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                    break;
                else
                    Console.WriteLine("Помилка: Введено некоректне число.");
            }

            double sum = num1 + num2;
            Console.WriteLine($"Сума чиселє: {sum}");
            Console.ReadLine();
        }
    }
}