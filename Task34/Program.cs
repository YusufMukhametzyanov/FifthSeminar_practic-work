/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
//инициализация массива
int[] GetArray(int arraySize)
{
    int[] arr = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}
//вывод на печать массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

//определение количества чётных чисел
void GetCountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count++;
    }
    Console.WriteLine($"в массиве {count} чётных чисел(а)");
}

Console.Write("Введите размерность массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arr = GetArray(arraySize);
PrintArray(arr);
GetCountEvenNumbers(arr);