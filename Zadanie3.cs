// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


public class Program
{
    public static void Main(string[] args)
    {
        int[] array = {1, 3, 9, 5, 2, 0, 7};

        ReWorkArray(array, array.Length - 1);
    }

    public static void ReWorkArray(int[] array, int index)
    {
        if(index < 0)
        {
            return;
        }
        Console.Write(array[index]);
        ReWorkArray(array, index - 1);
    }
}