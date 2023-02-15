// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int InputInt(string massage)
{
    System.Console.Write($"{massage}");
    return int.Parse(Console.ReadLine());
}

void SumNumber(int start, int finish, int sum)
{
    if (start > finish)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return ;
    }
    sum = sum + (start++);
    SumNumber(start, finish, sum);
}
int firstNum = InputInt("Введите число M: ");
int secondNum = InputInt("Введите число N: ");
SumNumber(firstNum, secondNum, 0);
