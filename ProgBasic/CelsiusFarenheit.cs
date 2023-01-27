//  Készítsünk programot, mely bekér egy hőmérséklet értéket, majd felajánlja, hogy Celsiusból Fahrenheitbe, 
//  vagy Fahrenheitből Celsiusba váltja át.

/*

using System.ComponentModel;
using System.Diagnostics.Metrics;

double K = 0;
double C = 0;
double F = 0;

bool c = false;
bool f = false;
bool k = false;
bool validTemp = false;
bool validMeasurementUnit = false;

Console.WriteLine("Átszámoljuk a hőmérsékletet más mértékegységekbe.");


while (validMeasurementUnit == false)
{
    Console.WriteLine("Miben szeretnéd megadni a hőmérsékletet?");
    Console.WriteLine("F - Fahrenheit");
    Console.WriteLine("C - Celsius");
    Console.WriteLine("K - Kelvin");

    string line = Console.ReadLine();

    if (line == "F" || line == "f")
    {
        f = true;
        Console.WriteLine("Szuper! Át fogjuk számolni a Fahrenheitet Kelvinre és Celsiusra.");
        validMeasurementUnit= true;
    }

    else if (line == "C" || line == "c")
    {
        c = true;
        Console.WriteLine("Szuper! Át fogjuk számolni a Celsiust Kelvinbe és Fahrenheitre.");
        validMeasurementUnit= true;
    }

    else if (line == "K" || line == "k")
    {
        k = true;
        Console.WriteLine("Szuper! Át fogjuk számolni a Kelvint Celsiusra és Fahrenheitre.");
        validMeasurementUnit= true;
    }

    else
    {
        Console.WriteLine("Ilyen mértékegységet nem ismerek.");
    }

}

if (c == true)
{
    while (validTemp == false)
    {
        Console.WriteLine("Kérlek add meg a hőmérsékletet Celsius fokban.");
        string line2 = Console.ReadLine();
        C = double.Parse(line2);
        K = 273.15 + C;

        if (K < 0)
        {
            Console.WriteLine("Ilyen hőmérséklet nem létezik. A legalacsonyabb elérhető hőmérséklet -273,15 °C. Ennél magasabb értéket kell megadnod!");
        }
        else
        {
            validTemp = true;
        }
    }
}

else if (f == true)
{
    while (validTemp == false)
    {
        Console.WriteLine("Kérlek add meg a hőmérsékletet Fahrenheitben.");
        string line2 = Console.ReadLine();
        F = double.Parse(line2);
        K = (459.67 + F) / 1.8;

        if (K < 0)
        {
            Console.WriteLine("Ilyen hőmérséklet nem létezik. A legalacsony elérhető hőmérséklet - 459,67 °F. Ennél magasabb értéket kell megadnod!");
        }
        else
        {
            validTemp = true;
        }
    }
}
else
{
    while (validTemp == false)
    {
        Console.WriteLine("Kérlek add meg a hőmérsékletet Kelvinben.");
        string line2 = Console.ReadLine();
        K = double.Parse(line2);

        if (K < 0)
        {
            Console.WriteLine("Ilyen hőmérséklet nem létezik. A legalacsonyabb elérhető hőmérséklet 0 K. Ennél magasabb értéket kell megadnod!");
        }
        else
        {
            validTemp = true;
        }
    }
}

C = K - 273.15;
F = (1.8 * K) - 459.67;

Console.WriteLine("Celsius: " + C);
Console.WriteLine("Kelvin: " + K);
Console.WriteLine("Fahrenheit: " + F);
*/