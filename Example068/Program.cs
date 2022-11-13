// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
Console.WriteLine("Введите начальное число A:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число B:");
int numberB = int.Parse(Console.ReadLine());

// Метод вычисления функции Аккермана:
int AckermannFunction(int numberA, int numberB)
{
    if (numberA == 0) return numberB + 1;
    else if (numberA != 0 && numberB == 0) return AckermannFunction(numberA - 1, 1);
    else if (numberA > 0 && numberB > 0) return AckermannFunction(numberA - 1, AckermannFunction(numberA, numberB - 1));
    return AckermannFunction(numberA, numberB);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberA},{numberB}) = {AckermannFunction(numberA, numberB)}");
