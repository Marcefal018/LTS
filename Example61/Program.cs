// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int InputInt(string massage)
{
    System.Console.WriteLine($"{massage}");
    return int.Parse(Console.ReadLine());   
}

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i + 1} > ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
int SumNumber(int[] array )
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

int number = InputInt("Введите количество чисел >");
int[] array = GenerateArray(number);
PrintArray(array);
System.Console.WriteLine($"Количество положительный чисел = {SumNumber(array)}");