//  Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//  чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int length, int minValue, int maxValue)        //Функция герерирования нового массива
{
    int[] result = new int[length];                                     //Создание массива длинной length
    Random rnd = new Random();                                          //Создание генератора случайный чисел

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

// Вывод массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Функция поиска положительных чисел
int FindPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}
int size = 10;
int minValue = 100;
int maxValue = 999;
int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine($"Количество четных чисел = {FindPositiveNumbers(myArray)}");