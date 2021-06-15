void check(int x, int y)
{
    if (x * y <= Math.Pow(10, 20))
        Console.WriteLine(result(x, y));
}

int result(int x, int y)
{
    int r = 0;
    if (x > 0)
    {
        if (y > 0)
            r = 1;
        else if (y < 0)
            r = 2;
    }
    else if (x < 0)
    {
        if (y > 0)
            r = 4;
        else if (y < 0)
            r = 3;
    }

    return r;
}

check(0, 0);