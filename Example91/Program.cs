// Задайте значения M и N. Напишите программу, которая выведет
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputInt(string massage)
{
    System.Console.Write($"{massage}");
    return int.Parse(Console.ReadLine());
}

void ShowNumber(int start, int finish)
{
    if (start <= finish)
    {
        if (start % 2 == 0 & start != 0)
        {
            System.Console.Write(start + " ");
        }
        ShowNumber(start + 1, finish);
    }
    return;
}
int firstNum = InputInt("Введите число M: ");
int secondNum = InputInt("Введите число N: ");
ShowNumber(firstNum, secondNum);
System.Console.WriteLine();