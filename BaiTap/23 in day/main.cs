float F(int num)
{
    if (num == 0)
        return 1;
    else if (num == 1)
        return 2;
    else
        return 2 * F(num - 1) - F(num - 2);
}

Console.WriteLine(F(2));