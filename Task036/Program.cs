//Одномерный массив, заполненный случайными числами.
//Нахождение суммы элементов, стоящих на нечётных позициях.

int[] CreatArray(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else System.Console.Write(array[i] + "]");
    }
}

int SumOddElement(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

//начало программы
Console.WriteLine("Программа считает сумму элементов стоящих на нечетных позициях в массиве");
Console.Write("Задайте длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте требуемый диапазон чисел.");
Console.Write("Нижняя граница диапазона: ");
int begin = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());

int[] array = CreatArray(size, begin, end);
PrintArray(array);
System.Console.Write(" -> ");
System.Console.Write(SumOddElement(array));