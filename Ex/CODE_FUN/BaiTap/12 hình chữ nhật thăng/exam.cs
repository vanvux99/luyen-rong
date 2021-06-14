void hinhChuNhat(int hang, int cot)
{
    for (int i = 0; i < hang; i++)
    {
        Console.Write("*");
        for (int j = 0; j < cot; j++)
        {
            Console.Write("*");
            if (j == (cot - 1))
            {
                Console.WriteLine();
            }
        }
    }
}

hinhChuNhat(2, 3);