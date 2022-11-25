// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int MultyDigits(int num)
{
    int multiply = 1;
    for (int i = 1; i <= num; i++)
    {
        multiply = multiply * i;
    }
    return multiply;
}
if(number > 0)
{
int resultDigits = MultyDigits(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {resultDigits}");
}
else Console.WriteLine("Требуется ввести натуральное число");