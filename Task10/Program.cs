// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное трехзначное число {number}");
int RemoveSecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}
Console.WriteLine(RemoveSecondDigit(number));