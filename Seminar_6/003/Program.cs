// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string Binary(int tenNumber)
{
    string binaryNum = String.Empty;
    while (tenNumber > 0)
    {
        if (tenNumber % 2 == 1)
        {
            binaryNum += "1";
        }
        else 
        {
            binaryNum += "0";
        }
        tenNumber /= 2;
    }
    return binaryNum;
}

string Reverse(string text)
{
    string temp = String.Empty;
    for (int i = text.Length - 1; i >= 0; i--)
    {
        temp += text[i];
    
    }
    return temp;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(Reverse(Binary(num)));