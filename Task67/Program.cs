// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Ввведите натуральное число M:");
int number = Convert.ToInt32(Console.ReadLine());

int SummNumber(int num)
{
    if (num != 0) return num % 10 + SummNumber(num / 10);
    return 0;
// return num != 0 ? num % 10 + SummNumber(num / 10) : 0;
}
Console.Write($"{SummNumber(number)} ");