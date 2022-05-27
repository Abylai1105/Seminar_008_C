// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

using System;
using static System.Console;
Console.Clear();

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int colomns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, colomns];

int spiral = 1;
for (int y = 0; y < colomns; y++)
{
    array[0, y] = spiral;
    spiral++;
}
for (int x = 0; x < rows; x++)
{
    array[x, colomns - 1] = spiral;
    spiral++;
}
for (int y = colomns - 2; y >= 0; y--)
{
    array[rows - 1, y] = spiral;
    spiral++;
}
for (int x = rows - 2; x > 0; x--)
{
    array[x, 0] = spiral;
    spiral++;
}

int c = 1; // для заполнения внутр массива
int d = 1; // для заполнения внутр массива
while (spiral < rows * colomns)
{
    while (array[c, d + 1] == 0) // Движение вправо
    {
        array[c, d] = spiral;
        spiral++;
        d++;
    }
    while (array[c + 1, d] == 0) // Движение вниз
    {
        array[c, d] = spiral;
        spiral++;
        c++;
    }
    while (array[c, d - 1] == 0) // Движение влево
    {
        array[c, d] = spiral;
        spiral++;
        d--;
    }
    while (array[c - 1, d] == 0) // Движение вверх
    {
        array[c, d] = spiral;
        spiral++;
        c--;
    }
}

for (int x = 0; x < rows; x++) // цикл для Заполнение центр элемента
{
    for (int y = 0; y < colomns; y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = spiral;
        }
    }
}

for (int x = 0; x < rows; x++) // цикл для вывода строк
{
    for (int y = 0; y < colomns; y++)
    {
        if (array[x, y] < colomns)
        {
            Console.Write(array[x, y] + "  ");
        }
        else
        {
            Console.Write(array[x, y] + " ");
        }
    }
    Console.WriteLine();
}