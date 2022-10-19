/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] GetArray(int array)
{
    int[] arr = new int[array];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 10);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}

void GetSumOddPosition(int[] arr)
{
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= max) max = arr[i];
        else if (arr[i] <= min) min = arr[i];
    }
    int result = max - min;
    Console.WriteLine($" Разница между максимальным и минимальным элементом массива = {result}");
}

Console.Write("Введите размер массива: ");
int array = int.Parse(Console.ReadLine());
int[] arr = GetArray(array);
PrintArray(arr);
GetSumOddPosition(arr);