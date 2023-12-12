// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

public class Program
{

    static List<int> results = new List<int>();

    static void Main()
    {
        Console.WriteLine ("Ввидете число M:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ($"Ввидете число N:");
        int n = Convert.ToInt32(Console.ReadLine());


        int temp = 0;
        if (n < m)
        {
            temp = n;
            n = m;
            m = temp;
        }

        Numbers(m, n);

        Console.WriteLine($"Числа от {m} до {n}: {string.Join(" ", results)}");
    }


    static void Numbers(int min, int max)
    {
        if (min <= max) 
        {
            results.Add(min);
            Numbers(min + 1, max);
        } 
    }
}
