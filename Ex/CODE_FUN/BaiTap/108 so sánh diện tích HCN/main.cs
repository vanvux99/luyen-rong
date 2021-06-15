double chieuDai = 0;
double chieuRong = 0;

void timCanh(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
{
    double AB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    double BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
    double CD = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
    double DA = Math.Sqrt(Math.Pow((x1 - x4), 2) + Math.Pow((y1 - y4), 2));

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
}

double dientichHCN(double cd, double cr)
{
    return cd * cr;
}

double dtHCNTrongHinhBanNguyet(float r)
{
    double y = 0.0;
    double S = 0.0;
    double Smax = S;
    for (int x = 0; x <= r; x++)
    {
        y = Math.Sqrt((Math.Pow(r, 2)) - (Math.Pow(x, 2)));
        S = x * y;
        if (S > Smax)
            Smax = S;
    }

    return Smax;
}

string soSanh(double a, double b)
{
    if (a > b)
        return "lớn hơn";
    else if (a < b)
        return "nhỏ hơn";
    else
        return "bằng";
}

timCanh(1, 2, 3, 2, 1, 4, 3, 4);
Console.WriteLine("Diện tích hình chữ nhật " + soSanh(dientichHCN(chieuDai, chieuRong), dtHCNTrongHinhBanNguyet(1.4f)) + " diện tích hình chữ nhật lớn nhất trong hình bán nguyệt");