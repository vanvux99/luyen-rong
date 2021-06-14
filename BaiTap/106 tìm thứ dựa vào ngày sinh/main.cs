Console.OutputEncoding = Encoding.UTF8;

int namNhuan(int nam)
{
    if (nam % 4 == 0)
        return 1;
    else
        return 0;
}

int soNamNhuan(int namKhoiDau, int namKetThuc)
{
    int temp = 0;
    for (int i = namKhoiDau; i < namKetThuc; i++)
    {
        if (namNhuan(i) == 1)
            temp++;
    }

    return temp;
}

int soNgayTuDauNam(int ngay, int thang, int nam)
{
    DateTime ngayNhap = new DateTime(nam, thang, ngay);
    DateTime ngayTuDauNam = new DateTime(nam, 1, 1);
    TimeSpan temp = ngayNhap - ngayTuDauNam;
    int soNgay = temp.Days;

    return soNgay;
}

int soNgay(int ngay, int thang, int nam, int namKhoiDau, int namKetThuc)
{
    int namNhuan = soNamNhuan(namKhoiDau, namKetThuc);
    int ngayTrongNamNhuan = 366 * namNhuan;
    int ngayTrongNamThuong = 365 * (namKetThuc - namKhoiDau - namNhuan);
    int ngayTuDauNam = soNgayTuDauNam(ngay, thang, nam);

    return (ngayTrongNamNhuan + ngayTrongNamThuong + ngayTuDauNam);
}

void result(int ngay, int thang, int nam, int namKhoiDau, int namKetThuc)
{
    int thu = soNgay(ngay, thang, nam, namKhoiDau, namKetThuc) % 7;
    switch (thu)
    {
        case 0:
            Console.WriteLine("thứ 2");
            break;
        case 1:
            Console.WriteLine("thứ 3");
            break;
        case 2:
            Console.WriteLine("thứ 4");
            break;
        case 3:
            Console.WriteLine("thứ 5");
            break;
        case 4:
            Console.WriteLine("thứ 6");
            break;
        case 5:
            Console.WriteLine("thứ 7");
            break;
        case 6:
            Console.WriteLine("chủ nhật");
            break;
    }
}

result(11, 6, 2015, 2015, 2021);