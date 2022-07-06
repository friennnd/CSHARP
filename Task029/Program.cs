//Пограмма, которая задаёт массив из 8 элементов и выводит их на экран.

int[] FillArray()
{
    Console.Write("Введите количество элементов массива: ");
    int elementcount = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[elementcount];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int[] array = FillArray();
PrintArray(array);