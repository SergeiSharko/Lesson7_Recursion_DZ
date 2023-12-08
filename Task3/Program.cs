// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

Console.Write($"Введите размер массива -> ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numberArray = new int[sizeArray];
int count = 0;
FillArrayRandomElements(numberArray, 0, 100);
PrintArray(numberArray, ", ");
Console.Write($" => ");
ReversPrintArrayWithRecursion(numberArray, count);

void FillArrayRandomElements(int[] myArray, int minValue, int maxValue)
{
    Random rand = new Random();
    for (int i = 0; i < myArray.Length; i++)
        myArray[i] = rand.Next(minValue, maxValue + 1);
}

void PrintArray(int[] myArray, string separator) =>
    Console.Write($"[{string.Join(separator, myArray)}]");

void ReversPrintArrayWithRecursion(int[] myArray, int count)
{
    if (count > myArray.Length - 1) return;
    Console.Write($"{myArray[myArray.Length - 1 - count]} ");
    ReversPrintArrayWithRecursion(myArray, ++count);
}