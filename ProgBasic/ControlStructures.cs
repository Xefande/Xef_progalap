using System.Security.Cryptography.X509Certificates;

/*
Console.WriteLine("Hello World");
Console.WriteLine("Hello World");
Console.WriteLine("Hello World");
Console.WriteLine("Hello World");
Console.WriteLine("Hello World");
Console.WriteLine("Hello World");
*/
// ELÁGAZÁSOK

/*
int ammo = 10;
bool isInAir = false;


if (ammo > 0 && !isInAir)
{
    Console.WriteLine("Bumm");
    ammo = ammo - 1;

}

bool canShoo = ammo > 0 && !isInAir;

if (canShoo)
{

    Console.WriteLine("BUMM");
    ammo = ammo - 1;


}
else
{
    Console.WriteLine("KLICK");
}


*/

//------------------------

/*

Console.WriteLine("Írj be egy egész számot");
string line = Console.ReadLine();
int number = int.Parse(line);

// Console.WriteLine("A szám duplája:");




number %= 2;

if (number == 0) { 
Console.WriteLine("páros");
}

if (number == 1)
{
    Console.WriteLine("páratlan");
}

else {
    Console.WriteLine("Ez nem egy egész szám, te gyökér!");
}

*/

/*
Console.WriteLine("Írj be egy egész számot");
string line = Console.ReadLine();
int number = int.Parse(line);

if (number > 0)
{
    Console.WriteLine("Pozitív");
}

else if (number < 0){
    Console.WriteLine("Negatív");
}


else {
    Console.WriteLine("Nulla");
}

*/
/*
 
 
if 
else if
else if
else
 
 
 */
/*
Console.WriteLine("Írj be egy egész számot");
string line = Console.ReadLine();
int number = int.Parse(line);


string text = number % 10 == 0 ? "Kerek" : "Nem kerek";

Console.WriteLine(text);
}
*/
//ciklusok


//while
/*
int i = 1;

while (i <= 100)
{
    Console.WriteLine(i);
    i++;


}
*/

//for ciklus

/*
int x = 3;

for (int j = 1; j <= 10; j++)
{

    Console.WriteLine(x);
    x = x + 3;


} */

//első n olyan számot, ami osztható ottal, de nem osztható 7-el



/*


int n = 20;
int x = 5;
int y = 0;



for (int j = 1; j <= n+y; j++)
{



    if (x % 7 != 0)
    {

        Console.WriteLine(x);

    }
    else {
        y++;
    
    }

    x = x + 5;
}

*/



// szorszótbla 
// 1 * 1 = 1 
// 1 * 2 = 2


/*
int a = 1;
int b = 1;


while (a <= 10) { 


    while (b <= 10)
    {
        Console.WriteLine(a + "*" + b + "=" + a * b);
        b++;
    }

    a++;

    b = 1;
}

*/

//Metódusok

/*
double f1 = 12.5f;
double f2 = 3;


double power = Math.Pow(f1,f2); //f1^f2
double power = Math.Pow( );
*/



