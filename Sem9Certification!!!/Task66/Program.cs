int SumMbetweenN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMbetweenN(m, n);
        return res;
    }
}

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumMToN(m, n);

void SumMToN(int m, int n)
{
    Console.Write(SumMbetweenN(m - 1, n));
}
