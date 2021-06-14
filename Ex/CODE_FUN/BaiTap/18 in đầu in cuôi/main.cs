Console.OutputEncoding = Encoding.UTF8;

void printNumber()
{
    List<float> ListNumber = new List<float>();
    Console.Write("Nhập số muốn nhập: ");
    int num = int.Parse(Console.ReadLine());

    ListNumber = addList(num);

    Console.WriteLine("Số đầu nhập vào: " + ListNumber[0]);
    Console.WriteLine("Số cuối nhập vào: " + ListNumber[num - 1]);
}

bool checkLimited(float num, int numCheck)
{
    switch (numCheck)
    {
        case 1:
            if (num > 1000)
                return false;
            break;
        case 2:
            if (num > 1000000)
                return false;
            break;
    }

    return true;
}

List<float> addList(int num)
{
    List<float> list = new List<float>();

    for (int i = 0; i < num; i++)
    {
        Console.Write("Nhập số: ");
        float temp = float.Parse(Console.ReadLine());

        if (i == 0)
        {
            if (checkLimited(temp, 1) == true)
                list.Add(temp);
        }
        else
        {
            if (checkLimited(temp, 2) == true)
                list.Add(temp);
        }
    }

    return list;
}

printNumber();