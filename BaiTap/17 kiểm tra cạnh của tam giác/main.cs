bool checkEdgeTriangular(float Edge_A, float Edge_B, float Edge_C)
{
    if (Edge_A + Edge_B >= Edge_C || Edge_A + Edge_C >= Edge_B || Edge_C + Edge_B >= Edge_A)
    {
        return true;
    }

    return false;
}

void result(float Edge_A, float Edge_B, float Edge_C)
{
    if (Edge_A > 0 && Edge_B > 0 && Edge_C > 0)
    {
        if (checkEdgeTriangular(Edge_A, Edge_B, Edge_C) == true)
        {
            Console.WriteLine("Yes");
        }
    }
    else
        Console.WriteLine("No");
}

result(3, 4, 5);