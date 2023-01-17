Console.Write("Введите первое число >");
String numberA = Console.ReadLine();
int a = Convert.ToInt32(numberA);
Console.Write("Введите второе число >");
String numberB = Console.ReadLine();
int b = Convert.ToInt32(numberB);
Console.Write("Введите третье число >");
String numberC = Console.ReadLine();
int c = Convert.ToInt32(numberC);
int max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.WriteLine($"{max}");

    