//Írjunk programot, mely bekér egy számot, és eldönti, hogy osztható-e 3-mal, 4-gyel vagy 9-cel. 

/*

Console.WriteLine("Adj meg egy számot:");
string line = Console.ReadLine();
long x = long.Parse(line);

Console.WriteLine(x);

bool d3 = false, d4 = false, d9 = false;


if (x % 4 == 0)
{
    d4 = true;
}


if (x % 9 == 0)
{
    d9 = true;
    d3 = true;
}
else if (x % 3 == 0)
{
    d3 = true;
}

if (d9 == true && d4 == true)
{
    Console.WriteLine( x + " hárommal, néggyel és kilenccel is osztható maradék nélkül.");
}

else if (d9 == false && d3 == true && d4 == true)
{
    Console.WriteLine( x + " hárommal és néggyel osztható, de kilenccel nem osztható maradék nélkül.");
}

else if (d3 == false && d4 == true)
{
    Console.WriteLine( x + " néggyel osztható, de kilenccel és hárommal nem osztható maradék nélkül.");
}

else if (d4 == false && d9 == true)
{
    Console.WriteLine( x + " kilenccel és hárommal is osztható, de nem osztható néggyel.");
}

else if (d4 == false && d9 == false && d3 == true)
{
    Console.WriteLine( x + " hárommal osztható, de nem osztható néggyel és kilenccel maradék nélkül.");
}

else
{
    Console.WriteLine(x + " nem osztható sem hárommal, sem néggyel, sem kilenccel maradék nélkül.");
}
*/