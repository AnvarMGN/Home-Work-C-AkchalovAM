// Задача 64.
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}   

Console.Write("Input a natural number: ");
int natNum = Convert.ToInt32(Console.ReadLine());

ShowNums(natNum);
*/

// Задача 66.
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNatNums(int m, int n)
{
    if(m < n) return SumOfNatNums(m, n - 1) + n;
    if(m > n) return SumOfNatNums(m - 1, n) + m;
    else return n;
}

Console.Write("Input M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int result = SumOfNatNums(numM,numN);
Console.WriteLine(result);

//Console.WriteLine(1,15);
*/

// Задача 68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// В 1935 году Рожа Петер предложила более простое построение функции Аккермана.

// A(0,m) = m + 1
// A(n + 1, 0) = A(n, 1)
// A(n + 1, m + 1) = A(n, A(n + 1, m))
/*
int RecursiveFunctionA(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return RecursiveFunctionA(m - 1, 1);
    if(m > 0 && n > 0) return RecursiveFunctionA(m - 1, RecursiveFunctionA(m, n - 1));
    else return 0;
}

Console.Write("Input M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int result = RecursiveFunctionA(numM,numN);
Console.WriteLine(result);
*/