// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;
using static System.Console;
Console.Clear();

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[rows, colomns];
Random random1 = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colomns; j++)
    {
        array1[i, j] = random1.Next(1, 100);
        Console.Write($"{array1[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] array2 = new int[rows, colomns];
Random random2 = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colomns; j++)
    {
        array2[i, j] = random2.Next(1, 100);
        Console.Write($"{array2[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] array3 = new int[rows, colomns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colomns; j++)
    {
        array3[i, j] = array1[i, j] * array2[i, j];
        Console.Write($"{array3[i, j]} ");
    }
    Console.WriteLine();
}