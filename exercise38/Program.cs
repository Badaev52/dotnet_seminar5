// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива. 
// Не использовать готовые методы Min и Max
// [3 7 22 2 78] -> 76

double[] array = GenerateArray(100.0, 999.0, 10);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным числами в массиве {DifferenceMaxMin(array)}");


double DifferenceMaxMin(double[] arr){

    double res = 0;
    double min = arr[0];
    double max = arr[0];
    for(int i = 1; i < arr.Length; i++){

        if(arr[i] > max){
            max = arr[i];
        }
        if(arr[i] < min){
            min = arr[i];
        }

    }
    Console.WriteLine($"Минимальное число {min}, максимальное число {max}");
    res = max - min;

    return res;
}

double[] GenerateArray(double min, double max, int length){

    double[] arr = new double[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++){

        arr[i] = min + (rnd.NextDouble() * (max - min));

    }


    return arr;
}

void PrintArray(double[] arr){

    Console.Write("[");
    for(int i = 0; i < arr.Length; i++){

        Console.Write(arr[i]);
        if(i == arr.Length - 1) break;
        Console.Write(", ");
    }
    
    Console.WriteLine("]");
}
