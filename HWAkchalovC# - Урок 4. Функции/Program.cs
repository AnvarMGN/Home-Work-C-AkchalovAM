//Задача 25.
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Exponentiation(double numA, double numB)
{
    double newNum = numA;

    while (numB - 1 > 0 ) // numB -1 -> так как в первой итерации число будет возведено во 2ю степень.
    {
        numB -= 1;
        newNum = newNum * numA;
    }
return newNum;
}

Console.Write("Input some number: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input some number: ");
double b = Convert.ToDouble(Console.ReadLine());

double result = Exponentiation(a,b);
Console.WriteLine($"The number {a} raised to the power {b} is {result}.");
*/

// Задача 27. 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigits(int numA)
{
    int remNum = 0;
    int sum = 0;
    
    while(numA != 0)
        {
            remNum = numA % 10;
            numA /= 10;
            sum = sum + remNum;
        }
return sum;
}

Console.Write("Input some number: ");
int somNum = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(somNum);
Console.WriteLine($"The sum of the digits of a given number({somNum}) is {result}.");
*/

// Задача 29. 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
// Заполнение с помощью команды new Random().Next().

int[] CreatRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}

void ShowArray(int[]array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);
*/

// Самостоятельное заполнение.
/*
int[] CreatRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input some number: ");
        int somNum = Convert.ToInt32(Console.ReadLine());
        array[i] = somNum;
    }
    return array;
}

void ShowArray(int[]array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size);
ShowArray(myArray);
*/