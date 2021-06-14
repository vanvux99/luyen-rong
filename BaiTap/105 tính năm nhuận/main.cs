int namNhuan(int nam)
{
    if (nam % 4 == 0)
        return 1;
    else
        return 0;
}

void result(int nam)
{
    if (nam > 0 && nam < 1000000)
        Console.WriteLine(namNhuan(nam));
}

result(2016);