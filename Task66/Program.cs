// /Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Ввведите натуральное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите натуральное число N:");
int N = Convert.ToInt32(Console.ReadLine());

SummNumbers(M, N);

int SummNumbers(int num1, int num2)
{
    if (num2 == num1) return num1;
    return num1 + SummNumbers((num1 < num2) ? (num1 + 1) : (num1 - 1), num2);
}
Console.Write($"{SummNumbers(M, N)} ");