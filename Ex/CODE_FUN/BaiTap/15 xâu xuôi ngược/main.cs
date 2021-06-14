void inXau(string xau)
{
    Console.WriteLine(xau + daoNguocXau(xau));
}

string daoNguocXau(string xau)
{
    string result = "";

    for (int i = xau.Length; i > 0; i--)
    {
        result += (xau.Substring(i - 1, 1));
    }

    return result;
}

inXau("abc");