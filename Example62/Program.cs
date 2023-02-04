// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,  
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputInt(string massage)
{
    Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}
int b1 = InputInt("Введите координату b первой точки");
int k1 = InputInt("Введите координату k первой точки");
int b2 = InputInt("Введите координату b второй точки");
int k2 = InputInt("Введите координату k второй точки");

(double, double) IntersectionPoint(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}
(double x, double y )= IntersectionPoint(b1, b2, k1, k2);
System.Console.WriteLine($"Точка пересечения = ({x}; {y})");