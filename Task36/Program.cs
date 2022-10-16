/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int arraySize)
{
    int[] arr = new int[arraySize];
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
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum += arr[i];
    }
    Console.WriteLine($" -> {sum}");
}

Console.Write("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arr = GetArray(arraySize);
PrintArray(arr);
GetSumOddPosition(arr);





