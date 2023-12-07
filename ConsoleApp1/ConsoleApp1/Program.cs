static void Main()
{
    Console.WriteLine("Сумма квадратов натуральных чисел.");
    Console.WriteLine(foo(10));

}
static int foo(int n)
{
    if (n <= 1)
        return n;
    else
    {
        int result = 0;
        for (int i = 1; i <= n; i++)
            result += Convert.ToInt32(Math.Pow(i, 2));
        return result;
    }
}