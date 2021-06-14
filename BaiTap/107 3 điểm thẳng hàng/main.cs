// chứng minh 3 điểm thẳng hàng
// khoảng cách 2 thằng bé nhất bằng thằng còn lại.

double khoangCachHaiDiem(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}

int result(int x1, int y1, int x2, int y2, int x3, int y3)
{
    double diemAB = khoangCachHaiDiem(x1, y1, x2, y2);
    double diemBC = khoangCachHaiDiem(x2, y2, x3, y3);
    double diemAC = khoangCachHaiDiem(x1, y1, x3, y3);

    if (diemAB + diemBC == diemAC)
        return 1;
    else
        return 0;
}

Console.WriteLine(result(1, 1, 2, 2, 3, 3));