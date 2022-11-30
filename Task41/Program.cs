// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число:");
int SizeArray = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    size = SizeArray;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите числа:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
}

int PositiveAraay(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) result ++ ;
    }
    return result;
}
int[] createArray = CreateArray(SizeArray);
PrintArray(createArray);
int resultArray = PositiveAraay(createArray);
Console.WriteLine($"-> {resultArray}");