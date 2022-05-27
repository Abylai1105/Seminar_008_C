// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int colomns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, colomns];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colomns; j++)
    {
        array[i, j] = random.Next(100);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[] newArray = new int[colomns];
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < colomns; j++)
    {
        sum = sum + newArray[i];
    }
    newArray[i] = sum;
    Console.Write($"{newArray[i]} ");
}
Console.WriteLine();

int index = 0;
for (int i = 0; i < newArray.Length; i++)
{
    int min = newArray[0];
    if (min <= newArray[i])
    {
        continue;
    }
    else
    {
        min = newArray[i];
        index = i;
    }
}
Console.WriteLine(index);


// void PrintArray(double[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matrix.GetLength(0); columns++)
//         {
//             Console.Write($" {matrix[rows, columns]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(double[,] matrix)
// {
//     for (int rows = 0; rows < matrix.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matrix.GetLength(0); columns++)
//         {
//             matrix[rows, columns] = new Random().Next(1,100);
//         }
//         Console.WriteLine();
//     }
// }