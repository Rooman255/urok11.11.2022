// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void MinElemMatrix(int[,] matrix, out int indexRows, out int indexColumns)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int min = matrix[0, 0];
    indexRows = 0;
    indexColumns = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(matrix[i, j] < min) 
            {
                min = matrix[i, j];
                indexRows = i;
                indexColumns = j;
            }
        }
    }
}

int[,] RemoveRowsColumns(int[,] matrix, int indexRows, int indexColumns)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrix2 = new int[rows - 1, columns - 1];
    int m = 0;
    for (int i = 0; i < rows-1; i++)
    {
        int n = 0;
        if(m == indexRows) m++;
        for (int j = 0; j < columns -1; j++)
        {
            if(n == indexColumns) n++;
            matrix2[i, j] = matrix[m, n];
            n++;
        }
        m++;
    }
    return matrix2;
}
int[,] matrix = CreateMatrixRndInt(3, 4, 1, 20);
PrintMatrix(matrix);
Console.WriteLine();
int indexRows1, indexColumns1;
MinElemMatrix(matrix, out indexRows1, out indexColumns1);
int[,] matrix3 = RemoveRowsColumns(matrix, indexRows1, indexColumns1);
PrintMatrix(matrix3);
