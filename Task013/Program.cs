﻿//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Программа выдает третью цифру числа введенного пользователем, или пишет что ее нет.");
int number = Convert.ToInt32(Console.ReadLine());

int Third(int num)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}

if (number < 100) Console.Write("Третьей цифры нет");
else Console.Write($"{Third(number)}");