// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4

int InputInt(string message)
{
    System.Console.Write($"{message}>");
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int line, int column)
{
    int[,] matr = new int[line, column];
    Random rnd = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
            matr[i, j] = rnd.Next(1, 10);
    }
    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j] + " "} ");
        }
        System.Console.WriteLine();
    }
}
int line = InputInt("Введите номер строки");
int column = InputInt("Введите номер столбца");
int[,] matrix = GenerateArray(3, 4);
PrintArray(matrix);
System.Console.WriteLine();
int[,] IndexPosition(int[,] matr)
{
    int[,] array = new int[line, column];
    if (line < matrix.GetLength(0) && column < matrix.GetLength(1))
    {
        System.Console.WriteLine(matrix[line, column]);
    }
    else
    {
        System.Console.WriteLine("Такого числа нет");
    }
    return array;
}
IndexPosition(matrix);
