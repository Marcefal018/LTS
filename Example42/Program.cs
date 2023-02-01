// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputInt(string massage)
{
    Console.WriteLine($"{massage}");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int NumberSum(int a)  
{
    int sum = 0;
    while (a != 0)
    {
        sum = sum + a % 10;
        a/= 10;
    }
    return sum;
}

int x = InputInt("Введите число >");
int b = NumberSum(x);
System.Console.WriteLine($"{b}");