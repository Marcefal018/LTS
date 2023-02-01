// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, “
// Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

int InputInt(string massage)
{
    Console.WriteLine($"{massage}");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreatArray(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.WriteLine($"{array[j]}");
    }
}

int x = InputInt("Введите число >");
int[] array = CreatArray(x);
ShowArray(array);