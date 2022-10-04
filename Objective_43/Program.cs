// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите значение B1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение K1: ");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите значение B2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение K2: ");
double k2 = double.Parse(Console.ReadLine()!);

double x = (b2-b1)/(k1-k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

if (y1 == y2)
Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> точка пересечения двух прямых ({x};{y1})");
else
Console.WriteLine("При текущих значениях нет точки пересечения двух прямых");