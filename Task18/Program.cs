// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
string quarter = Console.ReadLine();
string Range(string quarter1)
{
    if (quarter1 == "1") return "x > 0 && y > 0";
    if (quarter1 == "2") return "x < 0 && y > 0";
    if (quarter1 == "3") return "x < 0 && y < 0";
    if (quarter1 == "4") return "x > 0 && y < 0";
    return "Некоректные данные";
}
string range = Range(quarter);
Console.WriteLine(range);