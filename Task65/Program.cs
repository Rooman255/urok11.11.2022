// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Ввведите натуральное число M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите натуральное число N:");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 -1, num2);
    }
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    if (num1 == num2)
        Console.Write($"{num1} ");
}
