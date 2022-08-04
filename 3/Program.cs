// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Mассив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}

int Difference(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        else if (min > array[i])
            min = array[i];
    }
    int result = max - min;
    return result;
}

int[] array = GetArray(5, 1, 30);
Console.WriteLine(Difference(array));