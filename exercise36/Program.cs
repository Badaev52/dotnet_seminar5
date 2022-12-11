// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GenerateArray(100, 999, 10);
PrintArray(array);
Console.WriteLine($"Сумма элементов по нечетным индексам в массиве {SumOfOddIndices(array)}");


int SumOfOddIndices(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i++)
    {

        if (i % 2 != 0)
        {
            res += array[i];
        }

    }
    return res;
}

int[] GenerateArray(int min, int max, int length)
{

    int[] arr = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {

        arr[i] = rnd.Next(min, max + 1);

    }


    return arr;
}

void PrintArray(int[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write(arr[i]);
        if (i == arr.Length - 1) break;
        Console.Write(", ");
    }

    Console.WriteLine("]");
}
