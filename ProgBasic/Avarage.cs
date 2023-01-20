using System.Diagnostics.CodeAnalysis;
/*
int n1 = 5; 
int n2 = 6;
int n3 = 7;
int n4 = 8;
int n5 = 9;

int sum = n1 + n2 + n3 + n4 + n5;

int counter = 5;

int avarage = sum/counter;

Console.WriteLine(avarage);
*/

/*


// Avarage

string text1 = "Mennyi szám átlagát szeretnéd kiszámolni?";
string text2 = "Add meg az első számot!";
string text3 = "Add meg a következő számot!";
string text4 = "Az általad megadott ";
string text5 = " szám átlaga: ";
string text6 = "A számok összege: ";
string text7 = "Mit vagy hülye? A semminek nincs átlaga!";
string text8 = "Ne baszakodj velem! Nem adhatsz meg negatív értéket, ezt te is tudod!";
int n = 0;

// Asks for the number of numbers (n)

while (n <= 0)
{
    Console.WriteLine(text1);
    string line = Console.ReadLine();
    n = int.Parse(line);

    if (n == 0)
    {
        Console.WriteLine(text7);
    }

    else if (n < 0)
    {
        Console.WriteLine(text8);
    }
}

// Asks for the first number 
Console.WriteLine(text2);
string line2 = Console.ReadLine();
int n1 = int.Parse(line2);
int i = 2;

int sum = n1;

// Asks for the other numbers 
while (i <= n)
{

    Console.WriteLine(text3);
    string line3 = Console.ReadLine();
    int nn = int.Parse(line3);
    sum = sum + nn;

    i++;
}

//Result

float avarage = (float)sum / n;

//Print result

Console.WriteLine(text4 + n + text5 + avarage);

// Console.WriteLine(text6 + sum);


*/



/*
int n1 = 5;
int n2 = 6;
int n3 = 7;
int n4 = 8;
int n5 = 9000;

int sum = n1 + n2 + n3 + n4 + n5;

int counter = 5;

int avarage = sum / counter;

Console.WriteLine(avarage);
*/