void veTamGiac(int canh)
{
    for (int i = 0; i < canh; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

veTamGiac(5);