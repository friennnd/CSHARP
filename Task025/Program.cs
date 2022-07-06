//Цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

Console.WriteLine("Программа возводит число в степень.");
Console.Write("Введите число которое будет возводиться в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа в которую будет возводиться: ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num, int degree)
{
    int result = num;

    for (int i = 1; i < degree; i++)
    {
        result = result * num;
    }
    return result;

}

int multiplication = Exponentiation(a, b);
Console.Write(multiplication);