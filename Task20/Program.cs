// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A: ");
Console.Write("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int xb, int yb)
{
    double xc = (xa - xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double result = Math.Sqrt(xc+ yc);
    return result;
}
double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);