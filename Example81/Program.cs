// Задайте двумерный массив. Напишите программу, которая упорядочивает
// по убыванию элементы каждой строки двумерного массива.

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
void OrderingElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] matrix = GenerateArray(5, 6);
PrintArray(matrix);
System.Console.WriteLine();
OrderingElement(matrix);
PrintArray(matrix);