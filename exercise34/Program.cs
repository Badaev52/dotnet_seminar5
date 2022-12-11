// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int min = 100;
int max = 999;
int len = 100;

int[] array = GenerateArray(min, max, len);

int[] GenerateArray(int min, int max, int length){

    int[] arr = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++){

        arr[i] = rnd.Next(min, max + 1);

    }


    return arr;
}



