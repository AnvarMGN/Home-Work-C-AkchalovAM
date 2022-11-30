// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Inter some number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inter some number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Inter some number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int MaxNum = 0;

if(num1 > num2)
{
    MaxNum = num1;
}
else
{
    MaxNum = num2;
}
if(MaxNum > num3)
{
    Console.WriteLine("Maximum number: " + MaxNum);
}
else
{
    Console.WriteLine("Maximum number: " + num3);
}
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Inter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number is odd");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Inter some number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
int Lim = Num1; // Задаём лимитатор-ограничитель.
int Num2 = Num1 - (Num1 - 1); // Переворачиваем вводное значение, чтобы вывод был по порядку(2, 4, 6, ..).
int current = 1;

while(current <= Lim)
{   
    if(Num2 % 2 == 0)
    {
        Console.Write(Num2 + ", ");
        Num2 = Num2 + 1;
        current += 1;
    }
    else
    {
        Num2 = Num2 + 1;
        current ++;
    }
}
