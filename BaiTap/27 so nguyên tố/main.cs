int primeNumber(int num)
{
    int temp = 0;

    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
            temp++;
    }
    return temp;

}

string result(int num)
{
    if (num == 2)
        return "yes";
    if (num > 2)
    {
        if (primeNumber(num) >= 2)
        {
            return "no";
        }
    }

    return "yes";
}

Console.WriteLine(result(227));