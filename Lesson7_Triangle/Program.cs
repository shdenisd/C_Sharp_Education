Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.Write("*");

int xa = 50, ya = 1,
    xb = 1, yb = 30,
    xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.Write("*");
Console.SetCursorPosition(xb, yb);
Console.Write("*");
Console.SetCursorPosition(xc, yc);
Console.Write("*");


int x = xa, y = ya;

int Counter = 0;

while (Counter < 10000)
{
    int Random_value = new Random().Next(0, 3); // [0, 2]
    if (Random_value == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (Random_value == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (Random_value == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.Write("*");
    Counter++;
}

