/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

System.Console.WriteLine($"даны 2 прямые y = k1 * x + b1 и y = k2 * x + b2");
System.Console.WriteLine($"введите поочереди b1, k1, b2 и k2");
double b1 = Convert.ToDouble(System.Console.ReadLine());
double k1 = Convert.ToDouble(System.Console.ReadLine());
double b2 = Convert.ToDouble(System.Console.ReadLine());
double k2 = Convert.ToDouble(System.Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
System.Console.WriteLine($"координаты точки пересечения: ({x}, {y})");