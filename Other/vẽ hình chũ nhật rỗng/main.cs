// cách 1: 


int N = 10;
int M = 20;

char drawChar = '*';
char insideChar = ' ';

// Vẽ từ trên xuống
for (int i = 0; i < N; i++)
{
    // Vẽ từ trái sang
    for (int j = 0; j < M; j++)
    {
        /*
         * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
         * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
         * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
         * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
         * thì vẽ ra ký tự của hình chữ nhật
         * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
        */

        if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
        {
            Console.Write(drawChar);    // lúc này là ký tự *
        }
        else
        {
            Console.Write(insideChar);  // lúc này là ký tự rỗng ' '
        }
    }
    //mỗi lần vẽ xong một hàng thì xuống dòng
    Console.WriteLine();
}

// cách 2: 

void veHCN(int chieudai, int chieurong)
{
    for (int i = 0; i < chieurong; i++)
    {
        for (int j = 0; j < chieudai; j++)
        {
            if (i == 0 || i == (chieurong - 1) || j == 0 || j == (chieudai - 1))
                Console.Write("*");
            else
                Console.Write(" ");
        }

        Console.WriteLine();
    }
}

veHCN(6, 4);