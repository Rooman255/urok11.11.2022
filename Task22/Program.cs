// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
void square(int n)
{
    for (int i = 1; i <= n; i++)
    {
         Console.WriteLine($"{i}    {i*i}");
    }
}
if (num1 < 0) Console.WriteLine("Неверные данные");
square(num1);