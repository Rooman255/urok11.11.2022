// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    Console.Write("Введите строку:");
    int pos1 = Convert.ToInt32(Console.ReadLine()) -1;
    Console.Write("Введите столбец:");
    int pos2 = Convert.ToInt32(Console.ReadLine()) -1;
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    if (pos1 < 0 | pos1 > matrix.GetLength(0) -1 | pos2 < 0 | pos2 > matrix.GetLength(1) -1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine($"Значение элемента массива = {matrix[pos1, pos2]}");
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, -50, 50);
PrintMatrix(array2D);