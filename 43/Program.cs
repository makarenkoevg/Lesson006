// Задача 43: Напишите программу, которая найдёт точку пересечения двух
//  прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
using static System.Console;

Clear();

WriteLine("Вычисление точки пересечения двух прямых, заданных уравнениями");
WriteLine("y = k1 * x + b1, y = k2 * x + b2 ");
WriteLine();

Write("Введите k1: ");
double k1 = double.Parse(ReadLine());

Write("Введите b1: ");
double b1 = double.Parse(ReadLine());

Write("Введите k2: ");
double k2 = double.Parse(ReadLine());

Write("Введите b2: ");
double b2 = double.Parse(ReadLine());
double[] cross = Cross(k1,b1,k2,b2);
Write($"Точка пересечения прямых: [{cross[0]:f2},{cross[1]:f2}]");

double[] Cross(double k1, double b1, double k2, double b2)
{
    double[] cross = new double[2];
    cross[0] = (b1-b2)/(k2-k1);
    cross[1] = (k2*b1-b2*k1)/(k2-k1);
    return cross;
}
