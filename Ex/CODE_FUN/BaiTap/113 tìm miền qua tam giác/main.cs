List<float> area = new List<float>();

// kiểm tra điều kiện đề bài
bool checkValid(int x)
{
    if (x <= 10000 && x >= -10000)
        return true;
    return false;
}

// tìm miền dựa trên tọa độ x, y của điểm
float determineThePoint(float x, float y)
{
    if (x > 0)
    {
        if (y > 0)
            return 1;
        else if (y < 0)
            return 4;
    }
    else if (x < 0)
    {
        if (y > 0)
            return 2;
        else if (y < 0)
            return 3;
    }

    return 0;
}

// phương trình đường thẳng dựa trên 2 điểm cho trước
float equationOfTheLine(int x1, int y1, int x2, int y2, float x)
{
    return (-((y1 - y2) * (x - x1)) / (x2 - x1)) + y1;
}

// tìm ra miền chứa đường thẳng có phương trình y = ax + b dựa trên 2 điểm cho trước
List<float> areaOfLine(int x1, int y1, int x2, int y2)
{
    List<float> areaList = new List<float>();
    int x_min = 0;
    int x_max = 0;
    float y = 0.0f;
    int y_min = 0;
    int y_max = 0;

    if (x1 > x2)
    {
        x_max = x1;
        x_min = x2;
    }
    else
    {
        x_min = x1;
        x_max = x2;
    }

    if (y1 > y2)
    {
        y_max = y1;
        y_min = y2;
    }
    else
    {
        y_min = y1;
        y_max = y2;
    }


    for (float i = x_min; i <= x_max; i += 0.1f)
    {
        y = equationOfTheLine(x1, y1, x2, y2, i);
        if (y >= y_min && y <= y_max)
            areaList.Add(determineThePoint(i, y));
    }

    return areaList;
}

// loại bỏ các phần tử có giá trị trùng nhau trong mảng
List<float> onlyItem(List<float> array)
{
    int area1 = 0;
    int area2 = 0;
    int area3 = 0;
    int area4 = 0;
    List<float> mienList = new List<float>();

    foreach (float item in array)
    {
        if (item == 1)
        {
            area1++;
            if (area1 == 1)
                mienList.Add(item);
        }
        else if (item == 2)
        {
            area2++;
            if (area2 == 1)
                mienList.Add(item);
        }
        else if (item == 3)
        {
            area3++;
            if (area3 == 1)
                mienList.Add(item);
        }
        else if (item == 4)
        {
            area4++;
            if (area4 == 1)
                mienList.Add(item);
        }
    }

    return mienList;
}


// tìm các miền mà 3 cạnh của tam giác đi qua
List<float> areaContainingTheTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
{
    List<float> mien = new List<float>();

    foreach (float item in onlyItem(areaOfLine(x1, y1, x2, y2)))
        mien.Add(item);

    foreach (float item in onlyItem(areaOfLine(x1, y1, x3, y3)))
        mien.Add(item);

    foreach (float item in onlyItem(areaOfLine(x3, y3, x2, y2)))
        mien.Add(item);

    return onlyItem(mien);
}

// kết quả
void result(int x1, int y1, int x2, int y2, int x3, int y3)
{
    float dinhA = 0;
    float dinhB = 0;
    float dinhC = 0;

    if (checkValid(x1) == true && checkValid(y1) == true)
        dinhA = determineThePoint(x1, y1);
    if (checkValid(x2) == true && checkValid(y2) == true)
        dinhB = determineThePoint(x2, y2);
    if (checkValid(x3) == true && checkValid(y3) == true)
        dinhC = determineThePoint(x3, y3);

    if (dinhA == dinhB && dinhA == dinhC)
        Console.WriteLine(dinhA);
    else if (dinhA == dinhB || dinhA == dinhC)
        Console.WriteLine(dinhA + " " + dinhC);
    else
        area = areaContainingTheTriangle(x1, y1, x2, y2, x3, y3);
    foreach (float item in area)
        Console.Write(item + " ");
}


result(-2, 3, -3, -2, 0, -2);