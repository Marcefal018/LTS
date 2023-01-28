/*Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27. 
5 -> 1, 8, 27, 64, 125*/

int Prompt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int x = Prompt("Введите число >");
Math.Pow(x, 3);
int i = 1;
while(i <= x)
{
    double r = Math.Pow(i, 3);
    System.Console.WriteLine(r);
    i++;
}