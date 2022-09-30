Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x = xa, y = xb; //для определённости задаём первую точку

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3] 0,1,2
    if(what == 0)
    {
        x = (x+xa)/2; // в х и у положим середину отрезка
        y = (y+ya)/2;
    }

    if(what == 1)
    {
        x = (x+xb)/2; // в х и у положим середину отрезка
        y = (y+yb)/2;
    }
    if(what == 2)
    {
        x = (x+xc)/2; // в х и у положим середину отрезка
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // так же можно написать count++ или count +=1
}
