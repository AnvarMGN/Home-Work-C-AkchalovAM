// HOMEWORK FROM 08.12.2022

//Задача 19.
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Решил для всех чисел. 
/*
int Inverted(int somNum)
{ 
    int num = somNum;// заданое число - делим на 10 до 0
    int remNum = 0;// переменная для записи остатка от деления на 10
    int newNum = 0;// новое инвертированное число

    while(num != 0)
    {
        remNum = num % 10;
        num = num / 10;
        newNum = newNum * 10 + remNum;// увеличиваем разряд будущего инвертированного числа и прибавляем остаток от деления на 10
    }
    return newNum;
}

bool Check(int randNum, int invNum)
{
    if(randNum == invNum)
    return true;
    else
    return false;
}

Console.Write("Input some number: ");
int randNum = Convert.ToInt32(Console.ReadLine());

int invNum = Inverted(randNum);
bool result = Check(randNum,invNum);

Console.WriteLine($"Some number is {randNum}. Inverted number is {invNum}. Task response: {result}.");
*/

//Задача 21.
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double resalt = Math.Sqrt(Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2));
    return Math.Round(resalt, 1);
}

Console.Write("Input xA: ");
double xApoint = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA: ");
double yApoint = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA: ");
double zApoint = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB: ");
double xBpoint = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB: ");
double yBpoint = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB: ");
double zBpoint = Convert.ToDouble(Console.ReadLine());

double resaltDistsnce = Distance(xApoint, yApoint, zApoint, xBpoint, yBpoint, zBpoint);
Console.WriteLine($"Distanse bitween points A({xApoint};{yApoint};{zApoint}) and B({xBpoint};{yBpoint};{zBpoint}) is equal to {resaltDistsnce}.");
*/