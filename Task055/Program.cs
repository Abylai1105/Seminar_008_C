// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

double [,] newArray = GetMirrorArray(array);
PrintArray(newArray);
    

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
            matrix[rows, columns] = new Random().Next(1,11);
        }
        Console.WriteLine();
    }
}

double[,] GetMirrorArray(double[,] array)
{
    double[,] newArray = new double[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j, i] = array[i, j];
        }
    }
    return newArray;
}