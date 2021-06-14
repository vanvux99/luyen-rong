int giaiThua(int soNguyen)
{
    int tich = 1;
    if (soNguyen <= 10)
    {
        for (int i = 1; i <= soNguyen; i++)
        {
            tich *= i;
        }
    }

    return tich;
}

Console.WriteLine(giaiThua(3));