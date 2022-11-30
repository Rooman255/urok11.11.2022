// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int C = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
Console.WriteLine(Triangle(A, B, C) ? "да" : "нет");
