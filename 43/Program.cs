// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите точки первой прямой: ");
System.Console.WriteLine("Введите точку 1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите точку 2: ");
int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите точки второй прямой: ");
System.Console.WriteLine("Введите точку 1: ");
int b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите точку 2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

// double y = k1 * x + b1;
// double y = k2 * x + b2;
// double x = (y-b1)/k1;
// double x = (y-b2)/k2;
double y = 0;
double x = 0;
while (y == k1 * x + b1)
{
    y = k2 * x + b2;
}

System.Console.WriteLine($"({x},{y})");


