// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Result(int num)
{
    if (num > 100 && num < 1000)
    {
        num = num / 10;
    }
    return (num % 10);
}
if (num > 1000 || num < 100) Console.WriteLine("Error");
else Console.WriteLine(Result(num));