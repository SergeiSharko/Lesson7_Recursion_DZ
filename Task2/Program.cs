// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Пример
// m = 3, n = 2 -> A(m,n) = 29

Console.Write($"Введите два неотрицательных числа m и n через пробел (желательно из промежутка (0,3)) -> ");
string[]? input = Console.ReadLine()?.Split(' ');
uint valueM = Convert.ToUInt32(input?[0]);
uint valueN = Convert.ToUInt32(input?[1]);

Console.Write($"m = {valueM}, n = {valueN} -> A({valueM},{valueN}) = {FuncAccerman(valueM, valueN)}");

uint FuncAccerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else if ((m > 0) && (n == 0))
        return FuncAccerman(m - 1, 1);
    else
        return FuncAccerman(m - 1, FuncAccerman(m, n - 1));
}