/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
using System;
class Program
{
	static void Main(string[] args)
{
	double y = 0;
	double x = 0;
		
	Console.Write("Введите значение числа b1  = ");
	double b1 = Convert.ToInt64(Console.ReadLine());
	Console.Write("Введите значение числа k1  = ");
	double k1 = Convert.ToInt64(Console.ReadLine());
	Console.Write("Введите значение числа b2  = ");
	double b2 = Convert.ToInt64(Console.ReadLine());
	Console.Write("Введите значение числа k2  = ");
	double k2 = Convert.ToInt64(Console.ReadLine());
	y = (k1 * x + b1) - (k2 * x + b2); 
	x = (b1-b2)/(k2-k1);
	y = ((k1 * x) + b1);
	double [] array = new double[2];
	array[0] = x;
	array[1] = y;
	Console.Write("Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 = ( ");
	for(int i = 0; i < array.Length-1; i++)
	{
		Console.Write($"{array[i]}; ");
	}
	Console.Write($"{array[array.Length-1]} ).");
	}
}


