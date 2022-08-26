/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
using System;
class Program
{
static void PrintArray(int [] array)
{ 
	int count = array.Length;
	Console.Write("[ ");
	for(int i=0; i < count-1; i++)
	{
		Console.Write($"{array[i]}, ");
	}
	Console.Write($"{array[count-1]} ]");
}
static void Main(string[] args)
{
	Console.Write("Введите количество чисел m в массиве  = ");
	int m = Convert.ToInt32(Console.ReadLine());
	int [] array = new int[m];
	for(int i = 0; i < m; i++)
	{
		Console.Write("Введите  {0}-й элемент массива = ", i+1);
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	int count = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if(array[i] > 0) count += 1;
	}
	PrintArray(array);
	Console.WriteLine("\nКоличество чисел больше 0, которые ввёл пользователь = {0}", count + ".");
	}
}




