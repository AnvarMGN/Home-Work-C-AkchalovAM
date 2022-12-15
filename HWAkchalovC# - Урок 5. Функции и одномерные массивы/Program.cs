// Функции и одномерные массивы.

// В 34 и 36 задачах массив создан с помощью шаблона.
// В 38 задаче свой код для генерации массива(double).

// ШАБЛОНЫ 
/*
int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i}){array[i]}  ");
    }
}

Console.Write("Input size array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int minValueAr = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxValueAr = Convert.ToInt32(Console.ReadLine());
*/
/////////////////////////////////////////////////////////////

//Задача 34.
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int CountEvenNumbers(int[] array)
{
    int counter = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            counter++;

    return counter;
}

int[] MyArray = CreatRandomArray(sizeArray, minValueAr, maxValueAr);
ShowArray(MyArray);
int result = CountEvenNumbers(MyArray);
Console.WriteLine();
Console.WriteLine("There are " + result + " even numbers in the array." );
*/

//Задача 36. 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumValOddIndex(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] MyArray = CreatRandomArray(sizeArray, minValueAr, maxValueAr);
ShowArray(MyArray);
int result = SumValOddIndex(MyArray);
Console.WriteLine();
Console.WriteLine("The sum of the values with an odd index is " + result );
*/

//Задача 38. 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreatRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = Math.Round((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 3);

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{i}){array[i]}  ");
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }

    double dif = 0;

    if(max > 0 && min < 0) // проверка чисел для расчёта разности("-" / "+").
        dif = min + max;
    else 
        dif = max - min;
    
    return dif;
}

Console.Write("Input size array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int minValueAr = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxValueAr = Convert.ToInt32(Console.ReadLine());

double[] MyArray = CreatRandomArray(sizeArray, minValueAr, maxValueAr);
ShowArray(MyArray);
double result = DiffMaxMin(MyArray);
Console.WriteLine();
Console.WriteLine(result);
*/