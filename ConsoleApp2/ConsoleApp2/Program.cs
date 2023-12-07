using System;

static void Main()
{
    Console.WriteLine("Двойной факториал числа.");
    Console.WriteLine(Fact1(6));
}

static int Fact2(int n)
{
    int result = 1;
    for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
        result *= i;

    return result;
}

static int Fact1(int n)
{
    if (n == 1)
        return 1;
    else
        return n * Fact1(n - 2);
}

