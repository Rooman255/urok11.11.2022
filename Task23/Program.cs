// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
void cube(int n)
{
    for (int i = 1; i <= n; i++)
    {
         Console.WriteLine($"{i}    {i*i*i}");
    }
}
if (num1 < 0) Console.WriteLine("Неверные данные");
cube(num1);