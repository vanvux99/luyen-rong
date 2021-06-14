float result(int n)
{
    float sum = 0;

    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }

    return sum;
}

Console.WriteLine(result(3));