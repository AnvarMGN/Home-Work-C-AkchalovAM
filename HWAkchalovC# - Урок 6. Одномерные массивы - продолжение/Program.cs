 //Урок 6. Одномерные массивы - продолжение

 //Задача 41. 
 //Пользователь вводит с клавиатуры M чисел. 
 //Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
double InpNum(int numOfNum) // использовал double чтобы можно было вводить дробные числа.
{
    int numMoreO = 0;

    for (int i = 0; i != numOfNum; i++)
    {
        Console.Write("Input some number: ");
        double numM = Convert.ToDouble(Console.ReadLine());

        if(numM > 0)
        {
            numMoreO++;
        }
    }

    Console.WriteLine();
    return numMoreO;
}

Console.Write("How many numbers are you going to enter? Input this number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double result = InpNum(num);
Console.WriteLine($"The number of numbers greater than zero is {result}.");
*/

//Задача 43.
//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями: 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
/*
void IntersectionOfLine(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;

    if(k1 != k2 || b1 != b2)
    {
        x = Math.Round(((b2 - b1) / (k1 - k2)),3);// чтобы получить значение X из первого уравнения вычтем второе.
        y = Math.Round((k2 * x + b2), 3);
    }
    else
    {
        Console.WriteLine("The lines coincide or are parallel (b1 is not equal to b2).");
    }
    Console.WriteLine();
    Console.WriteLine($"The point of intersection of the lines is ({x};{y}).");
}

Console.Write("Input angular coefficient k1: ");
double numK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input some number b1: ");
double numB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input angular coefficient k2: ");
double numK2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input some number b2: ");
double numB2 = Convert.ToDouble(Console.ReadLine());

IntersectionOfLine(numK1, numB1, numK2, numB2);
*/