// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int count = 0;
    while (num > 0)
    {
        count = count + num % 10;
        num = num / 10;
    }
    return count;
}
if(number < 0) number = -number;
int numLenght = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе = {numLenght}");