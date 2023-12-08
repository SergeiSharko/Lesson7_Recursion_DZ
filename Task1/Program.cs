// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write($"Введите промежуток для натуральных чисел через пробел -> ");
string[]? input = Console.ReadLine()?.Split(' ');
int valueM = Convert.ToInt32(input![0]),
    valueN = Convert.ToInt32(input![1]);

Console.Write($"M = {valueM}; N = {valueN} -> \"");
PrintNumberFromRange(valueM, valueN, ", ");
Console.Write("\"");

void PrintNumberFromRange(int leftValue, int rightValue, string separator)
{
    if (leftValue < rightValue) 
    {
        Console.Write($"{leftValue}");
        if (leftValue == rightValue) return;
        Console.Write(separator);
        PrintNumberFromRange(++leftValue, rightValue, separator);
    }
    else
    {
        Console.Write($"{leftValue}");
        if (leftValue == rightValue) return;
        Console.Write(separator);
        PrintNumberFromRange(--leftValue, rightValue, separator);
    }
}