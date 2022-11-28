// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max )
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
}
return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MinElements(double[] arr)
{
    double min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxElements(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
double[] array = CreateArrayRndDouble(10, -1000, 1000);
PrintArray(array);
double resultelenemts = MaxElements(array) - MinElements(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(resultelenemts, 1)}");

