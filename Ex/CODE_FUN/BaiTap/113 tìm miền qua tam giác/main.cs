bool check(int x)
{
    if (x <= 10000 && x >= -10000)
        return true;
    return false;
}

int xacDinhDiem(int x, int y)
{
    if (x > 0)
    {
        if (y > 0)
            return 1;
        else if (y < 0)
            return 2;
    }
    else if (x < 0)
    {
        if (y > 0)
            return 4;
        else if (y < 0)
            return 3;
    }

    return 0;
}

bool diemThangHang(int x1, int y1, int x2, int y2)
{
    double OA = Math.Sqrt(Math.Pow((x1), 2) + Math.Pow((y1), 2));
    double OB = Math.Sqrt(Math.Pow((x2), 2) + Math.Pow((y2), 2));
    double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

void result(int x1, int y1, int x2, int y2, int x3, int y3)
{
    int dinhA = 0;
    int dinhB = 0;
    int dinhC = 0;

    if (check(x1) == true && check(y1) == true)
        dinhA = xacDinhDiem(x1, y1);
    if (check(x2) == true && check(y2) == true)
        dinhB = xacDinhDiem(x2, y2);
    if (check(x3) == true && check(y3) == true)
        dinhC = xacDinhDiem(x3, y3);

    if (dinhA == dinhB && dinhA == dinhC)
        Console.WriteLine(dinhA);
    else if (dinhA == dinhB || dinhA == dinhC)
        Console.WriteLine(dinhA + " " + dinhC);
    else
        if (diemThangHang)
        System.Console.WriteLine();

}


check(0);