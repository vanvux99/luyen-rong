double chieuDai = 0;
double chieuRong = 0;
int soSanh;

void timCanh(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int z1, int z2)
{
    double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    double BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
    double CD = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
    double DA = Math.Sqrt(Math.Pow((x1 - x4), 2) + Math.Pow((y1 - y4), 2));

    double ZA = Math.Sqrt(Math.Pow((x1 - z1), 2) + Math.Pow((y1 - z2), 2));
    double ZB = Math.Sqrt(Math.Pow((x2 - z1), 2) + Math.Pow((y2 - z2), 2));
    double ZC = Math.Sqrt(Math.Pow((x3 - z1), 2) + Math.Pow((y3 - z2), 2));
    double ZD = Math.Sqrt(Math.Pow((x4 - z1), 2) + Math.Pow((y4 - z2), 2));

    double ZAB = dienTichTamGiac(ZA, AB, ZB);
    double ZDA = dienTichTamGiac(ZA, DA, ZD);
    double ZBC = dienTichTamGiac(ZC, BC, ZB);
    double ZCD = dienTichTamGiac(ZC, CD, ZD);
    double sum = ZAB + ZDA + ZBC + ZCD;

    if (AB == BC && CD == DA)
    {
        chieuDai = AB;
        chieuRong = CD;
    }
    if (AB == CD && BC == DA)
    {
        chieuDai = AB;
        chieuRong = BC;
    }

    if (sum == dientichHCN(chieuDai, chieuRong))
        soSanh = 0;
    else
        soSanh = 1;
}

double dientichHCN(double cd, double cr)
{
    return cd * cr;
}

double dienTichTamGiac(double a, double b, double c)
{
    double perimeter = a + b + c;
    double p = perimeter / 2;

    return Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
}

string result()
{
    if (soSanh == 0)
        return "not outside";
    else
        return "outside";
}

timCanh(1, 2, 3, 2, 3, 4, 1, 4, 3, 3);
Console.WriteLine(result());