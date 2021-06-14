Console.OutputEncoding = Encoding.UTF8;

void result()
{
    Console.Write("Nhập số: ");
    float number = float.Parse(Console.ReadLine());
    if (number == 19)
        Console.WriteLine(19);
    else
        result();
}

result();