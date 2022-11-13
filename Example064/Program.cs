// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int printNumber(int n)
{
    if (n == 1)
    {
        return 1;
    }
    Console.Write($"{n} ");
    return printNumber(n - 1);
}
Console.WriteLine($"{printNumber(number)}");
