Console.WriteLine("|    x   |   y    |");
for (double x = -5; x <= 10; x += 0.2)
{
    double y;
    if (x > 12.5) y = Math.Pow(x, 2) - 3 * x + 2.5 * Math.Pow(x, 2);
    else if (0 <= x && x <= 1) y = Math.Pow(Math.E, x) + 5 + Math.Cos(0.001 * x);
    else if (x < 12.5) y = Math.Pow(x, 2);
    else y = 0;
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
}