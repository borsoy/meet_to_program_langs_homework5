//  Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

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

//Функция суммы элементов, стоящих на нечетных позициях 
int SumNegativeIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}
int size = 6;
int minValue = 0;
int maxValue = 20;
int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine($"Cумма элементов, стоящих на нечетных позициях = {SumNegativeIndex(myArray)}");