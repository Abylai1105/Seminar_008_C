// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

using System;
using static System.Console;
Console.Clear();

Console.Write("Введите количество строк x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[x, y, z];
Random random1 = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = random1.Next(1, 100);
        }
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine("Строка: " + i + 1);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("------");
}