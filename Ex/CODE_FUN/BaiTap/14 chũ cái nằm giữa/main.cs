int inSo(char A, char B)
{
    int codeDEC_A = chuyenDoi(A);
    int codeDEC_B = chuyenDoi(B);

    return codeDEC_B - (codeDEC_A + 1);
}

byte chuyenDoi(char A)
{
    byte keycode = (byte)(A);

    return keycode;
}

Console.WriteLine(inSo('a', 'd'));