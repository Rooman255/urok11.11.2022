// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A: ");
Console.Write("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("ZA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("ZB: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double xc = (x1 - x2) * (x1 - x2);
    double yc = (y1 - y2) * (y1 - y2);
    double zc = (z1 - z2) * (z1 - z2);
    double result = Math.Sqrt(xc+ yc + zc);
    return result;
}
double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);