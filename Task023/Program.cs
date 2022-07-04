//Программа, которая принимает 
//на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Программа выдает таблицу кубов чисел от 1 до числа введенного пользователем.");
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int cub = 0;
if (num < 0)
{
    while (count >= num)
    {
        cub = count * count * count;
        Console.WriteLine($"{count,3} -> {cub,5}");
        count--;
    }
}
else while (count <= num)
    {
        cub = count * count * count;
        Console.WriteLine($"{count,3} -> {cub,5}");
        count++;
    }