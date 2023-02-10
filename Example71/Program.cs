// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

double[,] matrix = new double[3, 4];

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(double[, ] matr) 
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for( int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i, j] =  new Random().Next(-99, 100) / 10.0; 
        }
    }
}


FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);
