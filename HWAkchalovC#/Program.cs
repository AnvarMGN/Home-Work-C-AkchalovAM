// HOMEWORK FROM 04.12.2022

// Task 10.  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ModMethod(int num)
{
    int des = num / 10;
    int ed = des % 10;
// return ed    
    int secNum = ed; 
    return secNum;
}

Console.Write("Write a three-digit number: ");
int thdNum = Convert.ToInt32(Console.ReadLine());

if(thdNum >= 100 && thdNum < 1000)
{
    int result = ModMethod(thdNum);
    // Console.WriteLine(result);
    Console.WriteLine("The second digit is " + result);
}
else
{
    Console.WriteLine("Try again: Write a three-digit number.");
}
*/

// Task 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Lim(int num)
{
    int sot = num;

    if(sot > 99) sot = num;
    else sot = -1;

    int result = sot;

    return result;
}

int ModNumber(int num)
{
    int thousand = num;
    int counter = 0;

    while(thousand >= 1000)
    {
        thousand = thousand / 10;
        counter++;
    }

    int result = thousand % 10;

    return result;
}

Console.Write("Inter your number: ");
int randNum = Convert.ToInt32(Console.ReadLine()); // Число которое хотим задать мы.
// int randNum = new Random().Next(1,99999999); // Произвольное число из отрезка от 1 до 99999999.
int check = Lim(randNum); // Проверка перед поиском 3-го числа. По ветке "да" проходят числа больше 99.
int number = ModNumber(check); // Каждый раз делим число на 10, до тех пор пока оно не станет 3х значным. 
// Затем находим остаток от деления на 10.
Console.WriteLine("Its third digit is " + number);
// Console.WriteLine($"The specified number is {check}. Its third digit is {number}.");
*/

// Task 15. 
/*
bool WeekDay(int num)
{
    if(num >= 6 && num <= 7) 
        return true;
    else 
        return false;
}

Console.Write("Inter a number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool resalt = WeekDay(number);

Console.WriteLine(resalt);
*/

//HOME WORK FROM 30.11.2022
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
/*
Console.Write("Inter some number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
int Lim = Num1; // Задаём лимитатор-ограничитель.
int Num2 = Num1 - (Num1 - 1); // Переворачиваем(как в массивах) вводное значение, чтобы вывод был по порядку(2, 4, 6, ..).
int current = 1;

while(current <= Lim)
{ 
    if(Num2 % 2 == 0)
    {
        Console.Write(Num2 + ", ");
        Num2 = Num2 + 1;
    }
    else
    {
        Num2 = Num2 + 1;
    }
    current++;
}
*/

/* 
Задача решена, но на последние числа в конце вывыодит запятую.
Пытался от неё избавиться. 
Получилось только с последним чётным числом.
Но когда последнее число нечётное, хочется применить двойное условие.
И это вроде возможно в цикле for. Но я пока туда не лез;) 
Да, на втором решении при вводе нечётного числа, терминал подвисает:)
С чётным всё ОК.
*/

/*
Console.Write("Inter some number: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
int Lim = Num1; // Задаём лимитатор-ограничитель.
int Num2 = Num1 - (Num1 - 1); // Переворачиваем(как в массивах) вводное значение, чтобы вывод был по порядку(2, 4, 6, ..).
int current = 1;

while(current <= Lim)
{   if(current == Lim)
    {
        if(Num2 % 2 == 0)
        {
            Console.Write(Num2 + " ");
            Num2 = Num2 + 1;
            current += 1;
        }
    }
    else
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
}
*/