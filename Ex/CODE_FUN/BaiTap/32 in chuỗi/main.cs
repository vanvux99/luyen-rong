void str(string stri)
{
    string temp = "";
    for (int i = 1; i <= stri.Length; i++)
    {
        temp = stri.Substring(0, i);
        Console.WriteLine(temp);
    }

    for (int i = stri.Length; i > 0; i--)
    {
        temp = stri.Substring(0, i);
        Console.WriteLine(temp);
    }
}

str("string");