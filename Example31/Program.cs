/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом. Не использовать строки
14212 -> нет
12821 -> да
23432 -> да*/

int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int a = InputInt("Введите число >");
int Reverse(int number)
{
int reverse = 0;
while (number > 0)
{
    reverse = reverse * 10 + number % 10;   
    number /= 10;
}
return reverse;
}
int b = Reverse(a);
if (a == b)
{
    Console.WriteLine(" Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}