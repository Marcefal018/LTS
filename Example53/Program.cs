// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] GenerateArray(int len)
// {
//     int[] array = new int[len];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(1, 100);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         System.Console.Write($"{item}\t");
//     }
//     System.Console.WriteLine();
// }
// int[] array = GenerateArray(6);
// PrintArray(array);

// int max = 0;
// int min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     if (array[i] <= min)
//     {
//         min = array[i];
//     }
// }

double[] array = new double[] { 3.0, 7.1, 22.6, 2.3, 78.4 };
double max = 0.0;
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] <= min)
    {
        min = array[i];
    }
}

System.Console.WriteLine($"Максимум = {max}");
System.Console.WriteLine($"минимум = {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
