Console.OutputEncoding = Encoding.UTF8;

int ngayTrongThang(int thang, int nam)
{
    int result = 0;
    switch (thang)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            result = 31;
            break;

        case 4:
        case 6:
        case 9:
        case 11:
            result = 30;
            break;

        case 2:
            if (timNamNhuan(nam) == true)
                result = 29;
            else
                result = 28;
            break;
    }

    return result;
}

bool ngayDep(int so)
{
    int bien_dem = 0;
    for (int i = 1; i <= so; i++)
    {
        if (so % i == 0)
            bien_dem++;
    }
    if (bien_dem == 2)
        return true;

    return false;
}

bool timNamNhuan(int nam)
{
    if (nam % 4 == 0)
        return true;

    return false;
}

int soNgayDepTrongThang(int thang, int nam)
{
    int bien_dem = 0;
    for (int i = 2; i <= ngayTrongThang(thang, nam); i++)
    {
        if (ngayDep(i) == true)
            bien_dem++;
    }

    return bien_dem;
}

// ngày phải nhỏ hơn số ngày trong tháng, năm
int ngayDepTheoThang(int ngay)
{
    int bien_dem = 0;
    for (int i = 2; i <= ngay; i++)
    {
        if (ngayDep(i) == true)
            bien_dem++;
    }

    return bien_dem;
}

void result(int ngay, int thang, int nam)
{
    int sum_ngayDepTheoThang = 0;
    for (int i = 1; i <= thang - 1; i++)
    {
        sum_ngayDepTheoThang += soNgayDepTrongThang(i, nam);
        Console.WriteLine(" " + i + " ", sum_ngayDepTheoThang);
    }

    sum_ngayDepTheoThang += ngayDepTheoThang(ngay);

    Console.WriteLine("Từ đầu năm tới ngày {0} tháng {1} năm {2} có {3} ngày đẹp", ngay, thang, nam, sum_ngayDepTheoThang);
}

result(1, 2, 2021);
Console.ReadKey();