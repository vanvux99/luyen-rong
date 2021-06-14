float result(int number)
{
    if (number == 0 || number == 1)
        return 1;
    else
        return 2 * result(number - 1) - result(number - 2);
}

Console.WriteLine(result(3));