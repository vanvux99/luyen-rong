void veTamGiac(int canh)
{
    for (int i = 0; i < canh; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j < 1 || i == canh - 1 || j == i)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}

veTamGiac(9);

// cách 2


for (int i = 0; i < 10; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || i == 9 || j == i)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine("");
}