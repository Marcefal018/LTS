// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int InputInt(string massage)
{
    System.Console.Write($"{massage}");
    return int.Parse(Console.ReadLine());
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else
    {
        return (AckermanFunction(m - 1, AckermanFunction(m, n - 1)));
    }
}
int firstNum = InputInt("Введите число M: ");
int secondNum = InputInt("Введите число N: ");
int result = AckermanFunction(firstNum, secondNum);
System.Console.WriteLine($"A(m,n) = {result}");
