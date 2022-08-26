/*
Задача №35. Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значение которых лежат
в отрезке [10, 99].
Пример для массива из 5, а не из 123 элементов.
В своем решении сделайте для 123:
[5, 18, 123, 6, 2] - 1.
[1, 2, 3, 6, 2] - 0.
[10, 11, 12, 13, 14] - 5.
*/

using System;
class Program
{
static void FillArray(int []collection)
{
	for(int i = 0; i < collection.Length; i++)
	{
		collection[i]= new Random().Next(0, 500);
	}
}
static void PrintArray(int [] array)
{
	int index = array.Length;
	Console.Write("[");
	for(int i = 0; i < index; i++)
	{
		Console.Write($"{array[i]}, ");
	}
	Console.Write($"{array[index-1]}]");
}

static void Main(string[] args)
	{
		int [] array  = new int [123];
		FillArray(array);
		int count = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if(array[i] >= 10 && array[i]<= 99) count += 1;
		}
		PrintArray(array);
		Console.WriteLine();
		Console.Write("Количество элементов массива, значение которых лежат в отрезке [10, 99] = {0}", count + ".");
	}
}






