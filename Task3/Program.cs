//  Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

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

//Функция поиска максимального числа 
int FindMax(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

//Функция поиска минимального числа 
int FindMin(int[] array)
{
    int min = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}
int size = 6;
int minValue = 0;
int maxValue = 20;
int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine($"Максимальное число в массиве = {FindMax(myArray)}");
Console.WriteLine($"Минимальное число в массиве = {FindMin(myArray)}");
Console.WriteLine($"Разница между максимальным и минимальным числом в массиве = {FindMax(myArray) - FindMin(myArray)}");