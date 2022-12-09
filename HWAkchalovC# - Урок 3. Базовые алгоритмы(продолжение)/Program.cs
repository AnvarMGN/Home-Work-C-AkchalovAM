// HOMEWORK FROM 08.12.2022
//Задача 19.
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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
