// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt1(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] CreateMatrixRndInt2(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
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

bool CheckMatrix(int[,] matrix, int[,] matrix2)
{
    return (matrix.GetLength(1) == matrix2.GetLength(0));
}

int[,] MultiplyTwoMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] multiplyTwoMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    if (CheckMatrix(matrix, matrix2) == true)
    {
        for (int i = 0; i < multiplyTwoMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiplyTwoMatrix.GetLength(1); j++)
            {
                multiplyTwoMatrix[i, j] = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    multiplyTwoMatrix[i, j] += matrix[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return multiplyTwoMatrix;
}

int[,] matrix = CreateMatrixRndInt1(3, 5, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt2(5, 3, 1, 10);
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine(@CheckMatrix(matrix, matrix2) ? "Результат перемножения матриц"
: "Умножение невозможно");
Console.WriteLine();
int[,] multiplyTwoMatrix = MultiplyTwoMatrix(matrix, matrix2);
PrintMatrix(multiplyTwoMatrix);