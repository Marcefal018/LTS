// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-99, 100);
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
int SumNumber(int[] array) 
{
    int sum = 0;
    for(int i = 1;i < array.Length; i += 2)
    {
        sum = sum + array[i] ;
    }
    return sum;
}


int[] array = GenerateArray(6);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов = {SumNumber(array)}");