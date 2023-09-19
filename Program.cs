/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        // Создаем объект Random для генерации случайных чисел.
        Random random = new Random();

        // Задаем размер массива.
        int arraySize = 10; // Можете изменить размер массива по вашему выбору.

        // Создаем массив случайных трёхзначных чисел.
        int[] numbers = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            // Генерируем случайное трёхзначное число.
            numbers[i] = random.Next(100, 1000);
        }

        // Подсчитываем количество чётных чисел в массиве.
        int evenCount = 0;

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат.
        Console.WriteLine("Сгенерированный массив:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nКоличество чётных чисел в массиве: " + evenCount);

        Console.ReadKey(); // Чтобы консольное окно не закрывалось сразу после выполнения программы.
    }
}

*/


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


using System;

class Program
{
    static void Main()
    {
        // Создаем объект Random для генерации случайных чисел.
        Random random = new Random();

        // Задаем размер массива.
        int arraySize = 10; // Можете изменить размер массива по вашему выбору.

        // Создаем массив случайных чисел.
        int[] numbers = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            // Генерируем случайное число.
            numbers[i] = random.Next(1, 101); // Генерируем числа от 1 до 100, можно изменить диапазон.
        }

        // Вычисляем сумму элементов на нечётных позициях.
        int sum = 0;

        for (int i = 1; i < arraySize; i += 2) // Начинаем с 1, так как в массивах в C# индексы начинаются с 0.
        {
            sum += numbers[i];
        }

        // Выводим результат.
        Console.WriteLine("Сгенерированный массив:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nСумма элементов на нечётных позициях: " + sum);

        Console.ReadKey(); // Чтобы консольное окно не закрывалось сразу после выполнения программы.
    }
}

*/

*/ Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
using System;

class Program
{
    static void Main()
    {
        // Задаем массив вещественных чисел.
        double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

        // Инициализируем переменные для хранения минимального и максимального значений.
        double min = numbers[0]; // Предполагаем, что первый элемент массива - минимальный.
        double max = numbers[0]; // Предполагаем, что первый элемент массива - максимальный.

        // Находим минимальное и максимальное значения в массиве.
        foreach (double number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        // Находим разницу между максимальным и минимальным значениями.
        double difference = max - min;

        // Выводим результат в желаемом формате.
        Console.WriteLine("Массив вещественных чисел:");
        foreach (double number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine($"\n{max} - {min} = {difference}");

        Console.ReadKey(); // Чтобы консольное окно не закрывалось сразу после выполнения программы.
    }
}
