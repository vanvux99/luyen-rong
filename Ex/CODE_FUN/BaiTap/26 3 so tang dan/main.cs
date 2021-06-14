void result(float num1, float num2, float num3)
{
    float temp;
    if (num1 > num2)
    {
        temp = num1;
        num1 = num2;
        num2 = temp;
    }

    if (num1 > num3)
    {
        temp = num1;
        num1 = num3;
        num3 = temp;
    }

    if (num2 > num3)
    {
        temp = num2;
        num2 = num3;
        num3 = temp;
    }

    Console.WriteLine(num1.ToString() + " " + num2.ToString() + " " + num3.ToString());
}

result(2, 1, 0);