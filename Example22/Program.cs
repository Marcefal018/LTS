//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Не использовать строки для расчета.


Console.Write("Введите число >");
String numberA = Console.ReadLine();
int a = Convert.ToInt32(numberA);

if(a > 99)
{
    Console.WriteLine("Третья цифра этого числа " + numberA[2]);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}