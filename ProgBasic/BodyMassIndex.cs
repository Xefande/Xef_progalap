// Írjunk programot, mely a testsúly és a testmagasság alapján meghatározza a testtömegindexet, és kiírja,
// hogy milyen testsúly osztályba tartozik az adott illető. a testtömeg osztályokat meghatározhatjuk tetszőlegesen,
// de alapul vehetünk létező osztályozásokat is. 

/*

using System.ComponentModel;

float m = 0; //tömeg
float h = 0; //magasság 
float bodyMassIndex = 0; // bMI = m/(h^2)

bool mValid = false;
bool hValid = false;

Console.WriteLine("Szeva, én vagyok a bunkó kalkulátor!");
Console.WriteLine("A testtömegindexed kiszámításához kérlek szükség lesz a magasságodra és a testömegedre.");

while (hValid == false)
{
    Console.WriteLine("Add meg a magasságodat centiméterbenben:");
    string line = Console.ReadLine();
    float cm = float.Parse(line);

    if (cm > 0)
    {
        h = cm / 100;
        hValid = true;
    }
    else
    {
        Console.WriteLine("Ne legyél kaki maki! Nem lehetsz " + cm + " cm. Adj meg pozitív értéket!");
    }

}

while (mValid == false)
{
    Console.WriteLine("Mennyi kilogramm vagy?");
    string line2 = Console.ReadLine();
    m = float.Parse(line2);

    if (m > 0)
    {
        mValid = true;
    }
    else
    {
        Console.WriteLine("Be légy butus, nem lehet " + m + " kg, nem vagy te antianyag. Adj meg pozitív értéket!");
    }
}

bodyMassIndex= m/(h*h);

if (bodyMassIndex < 5) // megszűntél
    {
    Console.WriteLine("Megszűntél létezni! Testtömegindexed: " + bodyMassIndex);
    }

else if (5 <= bodyMassIndex && bodyMassIndex < 7.5) // menj el orvoshoz
    {
    Console.WriteLine("Menj el orvoshoz! Sürgősen híznos kell! Testtömegindexed: " + bodyMassIndex);
    }

else if (7.5 <= bodyMassIndex && bodyMassIndex < 15) // kór
    {
    Console.WriteLine("Kórosan sovány vagy! Testtömegindexed: " + bodyMassIndex);
    }


else if (15 <= bodyMassIndex && bodyMassIndex < 18.5 ) //sov
    {
    Console.WriteLine("Megszűntél létezni! Testtömegindexed: " + bodyMassIndex);
    }

else if (18.5 <= bodyMassIndex && bodyMassIndex < 25 ) //normal
    {
    Console.WriteLine("Ez egész jó! Úgy tűnik rendben van a súlyod! Testtömegindexed: " + bodyMassIndex);
    }

else if (25 <= bodyMassIndex && bodyMassIndex < 30) // túlsúly
    {
    Console.WriteLine("Túlsúlyos vagy! Ideje lenne foglalkozni vele! Testtömegindexed: " + bodyMassIndex);
    }

else if (30 <= bodyMassIndex && bodyMassIndex < 35) // elhízott
    {
    Console.WriteLine("Elhízott vagy! Ideje lenne fogyózni, ha még élni akarsz pár évet! Testtömegindexed: " + bodyMassIndex);
    }

else if (35 <= bodyMassIndex && bodyMassIndex < 40) // baszott kövér
    {
    Console.WriteLine("Baszott kövér vagy! Menj orvoshoz! Testtömegindexed: " + bodyMassIndex);
    }

else if (40 <= bodyMassIndex && bodyMassIndex < 45) // zsírdisznó
    {
    Console.WriteLine("Gurulj el orvoshoz, te zsírdisznó! Testtömegindexed: " + bodyMassIndex);
    }

else if (45 <= bodyMassIndex && bodyMassIndex < 60) // gecikövér
    {
    Console.WriteLine("Geci kövér vagy! Hívt a mentőket! Testtömegindexed: " + bodyMassIndex);
    }

else if (60 <= bodyMassIndex)
    {
    Console.WriteLine("Gratulálunk! Te egy feketelyuk vagy! Testtömegindexed: " + bodyMassIndex);
    }

else
    {
    Console.WriteLine("Something went wrong!");
    }
*/