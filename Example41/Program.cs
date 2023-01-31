// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B. Реализовать через функции
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string massage)
{
    Console.Write($"{massage}");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


static int GetPow(int number, int pow)
{
    int result = 1;
    for(int i = 0; i < pow; i++)
    {
        result *= number;
    }
    return result;
}

int numberA = InputInt("Введите первое число >");
int numberB = InputInt("Введите второе число >");
int a = GetPow(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {a}");

