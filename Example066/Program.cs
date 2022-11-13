// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите целое число начала диапазона ");
int numberStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число конца диапазона ");
int numberEnd = Convert.ToInt32(Console.ReadLine());
int printNumberSum(int n, int m)
{
    if (n == m)
    {
        return n;
    }
    return printNumberSum(n, m - 1) + m;
}
Console.WriteLine($"{printNumberSum(numberStart, numberEnd)}");
