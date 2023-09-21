/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел (M): ");
        int M = int.Parse(Console.ReadLine());

        int countPositive = 0;

        for (int i = 0; i < M; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                countPositive++;
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {countPositive}");
    }
}
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значения k1, b1, k2 и b2 для уравнений y = k1 * x + b1 и y = k2 * x + b2:");

        Console.Write("k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("k2: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.Write("b2: ");
        double b2 = double.Parse(Console.ReadLine());

        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны и не имеют точки пересечения.");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine($"Точка пересечения: x = {x}, y = {y}");
        }
    }
}
