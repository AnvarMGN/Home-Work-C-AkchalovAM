//Задача 47.
//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
/*
double[,] Random2dArray()
{
    Console.Write("Input rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, colums];

    for (int i = 0; i < rows; i++)

        for(int j = 0; j < colums; j++)

            array[i,j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()),3);

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = Random2dArray();
Show2dArray(myArray);
*/

//Задача 50.
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}({i};{j})  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CheckArray(int [,] array, int m, int n)
{
    if(m <= array.GetLength(0) && n <= array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
                if(m == i && n == j) Console.WriteLine($"{array[i,j]}({i};{j})");
    }
    else Console.WriteLine("There is no such element.");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write("Input m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

CheckArray(myArray, numM,numN);
*/
