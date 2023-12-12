using System;

public class Program
{
    static void Main()
    {
        int m = 3;
        int n = 10;

        int result = Ackermann(m, n);
        Console.WriteLine($"Результат функции Аккермана для m = {m}, n = {n}: {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
        {
            throw new ArgumentException("Некорректные значения m и n");
        }
    }
}
