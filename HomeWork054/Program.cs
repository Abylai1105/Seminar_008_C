// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++);
    {
        for (int k = 0; k < array.GetLength(1) - j - 1; k++)
        {
            if (array[i, k] > array[i, k + 1])
            {
                double f = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = f;
            }
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++);
    {
        Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
return 0;

void PrintArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(0); columns++)
        {
            Console.Write($" {matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(0); columns++)
        {
            matrix[rows, columns] = new Random().Next(1,10);
        }
        Console.WriteLine();
    }
}