// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}


int[] array = GetArray(7, 100, 999);

int Count(int[] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        count++;
    }
    return count;
}

Console.WriteLine(Count(array));