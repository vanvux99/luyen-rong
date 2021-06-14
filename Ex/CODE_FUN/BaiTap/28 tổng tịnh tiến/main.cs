float result(int n, int k)
{
    float sum = 0;

    for (int i = 1; i <= n; i++)
    {
        sum += i * (i + k);
    }

    return sum;
}

Console.WriteLine(result(2, 2));