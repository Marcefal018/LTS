// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

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
int[,] ProductTwoMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}
int[,] firstMatrix = GenerateArray(3, 5);
PrintArray(firstMatrix);
System.Console.WriteLine();
int[,] secondMatrix = GenerateArray(5, 4);
PrintArray(secondMatrix);
System.Console.WriteLine();
int[,] resultMatrix = ProductTwoMatrices(firstMatrix, secondMatrix);
PrintArray(resultMatrix);