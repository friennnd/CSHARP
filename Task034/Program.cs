//Массив заполненный случайными положительными трёхзначными числами.
//Программа, которая покажет количество чётных чисел в массиве.

int[] CreatArray(int size) 
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

int CountEvenNum(int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

//начало 
Console.WriteLine("Программа показывает количество чётных чисел в массиве");
Console.Write("Задайте длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] resArray = CreatArray(size);
PrintArray(resArray);
System.Console.Write(" -> ");
System.Console.Write(CountEvenNum(resArray));