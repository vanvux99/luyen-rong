bool checkEdgeTriangular(float Edge_A, float Edge_B, float Edge_C)
{
    if (Edge_A + Edge_B >= Edge_C || Edge_A + Edge_C >= Edge_B || Edge_C + Edge_B >= Edge_A)
    {
        return true;
    }

    return false;
}

bool rightAngledTriangle(float Edge_A, float Edge_B, float Edge_C)
{
    return (Edge_A * Edge_A == Edge_B * Edge_B + Edge_C * Edge_C || Edge_B * Edge_B == Edge_A * Edge_A + Edge_C * Edge_C || Edge_C * Edge_C == Edge_B * Edge_B + Edge_A * Edge_A) ? true : false;
}

bool equiangularTriangle(float Edge_A, float Edge_B, float Edge_C)
{
    return (Edge_A == Edge_B && Edge_C == Edge_B) ? true : false;
}

bool isoscelesTriangle(float Edge_A, float Edge_B, float Edge_C)
{
    return (Edge_A == Edge_B || Edge_C == Edge_B || Edge_C == Edge_A) ? true : false;
}

bool obtuseTriangle(float Edge_A, float Edge_B, float Edge_C)
{
    return (Edge_A * Edge_A > Edge_B * Edge_B + Edge_C * Edge_C || Edge_B * Edge_B > Edge_A * Edge_A + Edge_C * Edge_C || Edge_C * Edge_C > Edge_B * Edge_B + Edge_A * Edge_A) ? true : false;
}


void result(float Edge_A, float Edge_B, float Edge_C)
{
    if (Edge_A > 0 && Edge_B > 0 && Edge_C > 0)
    {
        if (checkEdgeTriangular(Edge_A, Edge_B, Edge_C) == true)
        {
            if (rightAngledTriangle(Edge_A, Edge_B, Edge_C) == true)
                Console.WriteLine("Tam giác vuông");
            else if (equiangularTriangle(Edge_A, Edge_B, Edge_C) == true)
                Console.WriteLine("Tam giác đều");
            else if (isoscelesTriangle(Edge_A, Edge_B, Edge_C) == true)
                Console.WriteLine("Tam giác cân");
            else if (obtuseTriangle(Edge_A, Edge_B, Edge_C) == true)
                Console.WriteLine("Tam giác tù");
            else
                Console.WriteLine("Tam giác nhọn");
        }
        else
            Console.WriteLine("Không phải tam giác");
    }
    else
        Console.WriteLine("Không phải tam giác");
}

result(3, 4, 5);