//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.


Console.Write("Введите номер дня недели: ");
String stringValue = Console.ReadLine();
int day = Convert.ToInt32(stringValue);
while(day < 8 && day > 0)
{
    string[] week = new string[]{"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
    Console.WriteLine($"{week[day - 1]}");
    if(day == 6 || day == 7)
    {
        Console.WriteLine("Этот день является выходным");
    }
    else
    {
        Console.WriteLine("Этот день является рабочим");
    }
    break;
}
