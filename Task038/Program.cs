//Массив вещественных чисел. 
//Найдити разницу между максимальным и минимальным элементов массива.

double[] CreatArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 10;
    }
    return array;
}

void PrintArray(double[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length - 1) Console.Write(Math.Round(array[i], 2) + "; ");
        else System.Console.Write(Math.Round(array[i], 2) + "]");
    }
}

double MaxNum(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinNum(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}


Console.WriteLine("Программа считает разницу максимального и минимального элементов в массиве.");
Console.Write("Задайте длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());


double[] MyArray = CreatArray(size);
PrintArray(MyArray);
double max = MaxNum(MyArray);
double min = MinNum(MyArray);
System.Console.WriteLine(Math.Round(max - min, 2));