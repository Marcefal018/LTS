// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void ArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        result /= array.GetLength(0);
        System.Console.Write($"{(result) + " "}");
    }
}

int[,] matrix = GenerateArray(3, 4);
PrintArray(matrix);
ArithmeticMean(matrix);