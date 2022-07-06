//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int DigitsCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

int res = DigitsCount(a); 
while (res > 9)
{
    res = DigitsCount(res);
}
System.Console.WriteLine(res);