// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Ввведите натуральное число M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите натуральное число N:");
int number2 = Convert.ToInt32(Console.ReadLine());

int FactorialNumbers(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * FactorialNumbers(num1, num2 - 1);
    // return num == 0 ? 1 : num1 * FactorialNumbers(num1, num2 - 1);

    // if (num2 == 0) return 1;
    // else if(num2 % 2 ==0) return FactorialNumbers(num1 * num1, num2 / 2);
    // return num1 * FactorialNumbers(num1, num2 - 1);
}
Console.Write($"{FactorialNumbers(number1, number2)} ");