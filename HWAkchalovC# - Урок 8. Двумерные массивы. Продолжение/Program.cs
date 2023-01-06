// Урок 8. Двумерные массивы. Продолжение.

// Задача 54.
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
            Console.Write($"{array[i,j]} ({i},{j})  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1); k++)
            {
                if(array[i,j] > array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SortArray(myArray);
Show2dArray(myArray);
*/

// Задача 56.
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void NumMinRow(int[,] array)
{
    int numMinRow = 0;
    int minSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];      

        if (i == 0) minSum = sum;

        if (sum < minSum)
        {
            minSum = sum;
            numMinRow = i;
        }
    }
    Console.WriteLine($"Row number is {numMinRow + 1}, with sum of elemets equal to {minSum}.");         
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
NumMinRow(myArray);
*/

// Задача 58.
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
/*
void ProductOfMatrices(int[,] myArray1, int[,] myArray2, int[,] prodArray)
{
    if (myArray1.GetLength(0) == myArray2.GetLength(1))
    {
        for (int i = 0; i < prodArray.GetLength(0); i++)
            for (int j = 0; j < prodArray.GetLength(1); j++)
            {
                prodArray[i,j] = 0;
                for (int k = 0; k < myArray1.GetLength(1); k++)
                    prodArray[i, j] = prodArray[i, j] + myArray1[i, k] * myArray2[k, j];// Складываем произведение элементов строки на столбец заданных матриц. Кол-во строк 1ой матр. = кол-ву столбцов 2ой матрицы.
            }
    }
    else Console.WriteLine("Product is impossible.");
}

int[,] myArray1 = CreateRandom2dArray();
Console.WriteLine();
int[,] myArray2 = CreateRandom2dArray();
Console.WriteLine();
int[,] prodArray = new int[myArray1.GetLength(0),myArray2.GetLength(1)];

ProductOfMatrices(myArray1, myArray2, prodArray);
Console.WriteLine();

Show2dArray(myArray1);
Show2dArray(myArray2);
Show2dArray(prodArray);
*/

// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray()
{
    Console.Write("Input X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
     Console.Write("Input Z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[x, y, z];

    for(int i = 0; i < x; i++)
        for(int j = 0; j < y; j++)
            for(int k = 0; k < z; k++)
                array[i,j,k] = new Random().Next(minValue, maxValue);// Решение с неповторяющимися числами пока не сообразил.
                
    return array;
}

void Show3dArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] myArray = CreateRandom3dArray();
Console.WriteLine();
Show3dArray(myArray);
*/

// Задача 62.
// Напишите программу, которая заполнит спирально массив 4 на 4.

// Приветствую, Павел!
// Над 62 задачей буду думать...так же как и над решением 60 задачи.
// Это действительно инетересно, однако времени в обрез, т.к. болел грипом конец декабря и начало января.
// Сейчас, стараюсь решить задачи на "скорую руку" - 
// т.е. не хочется быть отстающим и вовремя проходить уже новый материал.
// К сожалению решения даются мне "непросто", но надеюсь с опытом будет легче.
// "Ученье - Свет!" 