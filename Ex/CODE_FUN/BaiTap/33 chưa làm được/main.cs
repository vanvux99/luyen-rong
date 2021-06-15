int result(int n, int k)
{
    int q = n / k;
    int r = n % k;

    return q + r;
}

Console.WriteLine(result(5, 3));