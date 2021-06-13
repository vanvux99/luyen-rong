double binhphuong(double num)
{
    double result = 0;

    if (num <= Math.Pow(10, 9))
    {
        result = Math.Pow(num, 2);
    }

    return result;
}

Console.WriteLine(binhphuong(25));