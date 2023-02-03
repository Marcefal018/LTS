//  Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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
int EvenNumber(int[] array) // Функция вывода количества четных чисел 
{
    int count = 0;
    for(int i = 0;i < array.Length; i++)
    {
        if( (array[i] % 2) == 0)
        {
            count += 1;
        }
    }
    return count;
}


int[] array = GenerateArray(13);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве = {EvenNumber(array)}");