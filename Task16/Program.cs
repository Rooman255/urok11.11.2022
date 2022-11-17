// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
bool square(int number1, int number2)
{
    return (number1 == number2 * number2) || (number2 == number1 * number1); 
}
bool result = square(num1, num2);
Console.WriteLine(result ? "да" : "нет");