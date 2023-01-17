Console.Write("Введите первое число >");
String numberA = Console.ReadLine();
int a = Convert.ToInt32(numberA);
Console.Write("Введите второе число >");
String numberB = Console.ReadLine();
int b = Convert.ToInt32(numberB);
if(a > b)
{
     Console.WriteLine($"число {a} = max, число {b} = min");
}else
{
     Console.WriteLine($"число {a} = min, число {b} = max");
}
