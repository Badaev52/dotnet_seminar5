// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int min = 100;
// int max = 999;
// int len = 25;

int[] array = GenerateArray(100, 999, 10);
PrintArray(array);
Console.WriteLine($"Количество четных элементов в массиве {NumberEvenNumbers(array)}");


int NumberEvenNumbers(int[] arr){

    int res = 0;
    for(int i = 0; i < arr.Length; i++){

        if(arr[i] % 2 == 0){
            res++;
        }

    }
    return res;
}


int[] GenerateArray(int min, int max, int length){

    int[] arr = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++){

        arr[i] = rnd.Next(min, max + 1);

    }


    return arr;
}

void PrintArray(int[] arr){

    Console.Write("[");
    for(int i = 0; i < arr.Length; i++){

        Console.Write(arr[i]);
        if(i == arr.Length - 1) break;
        Console.Write(", ");
    }
    
    Console.WriteLine("]");
}

