// Программа, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] ArrayRandom(int size)
{
    int[] array = new int[8];
    int index = 0;
    Random rnd = new Random();

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 33);
        index++;
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
            if (i == 0) Console.Write("[");
            if (i <  arr.Length - 1) Console.Write(arr[i] + ",");
            else Console.Write(arr[i] + "]");
    }
}
int[] resArray = ArrayRandom(8);
PrintArray(resArray);