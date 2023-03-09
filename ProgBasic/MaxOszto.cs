﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;






// int x = GreCoDiv(6666676625, 10);
// Console.WriteLine(x);

// Console.WriteLine(SumDigits(0));







/*
string line = Console.ReadLine();
int x = int.Parse(line);

if (IsPerfect(x))
    Console.WriteLine("Tökéletes");
else
    Console.WriteLine("Tökéletlen");

int bin = 1010252101;
Console.WriteLine(BinToDec(bin));
*/



// Írj függvényt, ami egy paraméterben kapott 2-es számrendszer béli (bináris) számot
// átalakít 10-es számrendszer béli (decimális) alakjára.

// Ha a bemenet nem bináris szám (más számjegyet is tartalmaz mint 0 és 1), a kimenet legyen 0.





int BinToDec(int bin)
{
    int dec = 0;
    int i = 1;
    int remain = 0;
    int isNegative = 1;

    if (bin < 0)
    {
        isNegative = -1;
        bin= -bin;
    }


    while (bin > 0)
    {
        remain = bin % 10;
        if (remain > 1)
        {
            return 0;
        }

        dec = dec + remain * i;
        i = i * 2;
        bin = bin / 10;
    }

    dec = dec * isNegative;
    return dec;
}

// Írj függvényt, ami egy paraméterben kapott egy egész számról eldönti, hogy Tökéletes szám-e.
// A számelméletben **tökéletes számnak** nevezzük azokat a természetes számokat, amelyek megegyeznek
// az önmaguknál kisebb osztóik összegével.

// Pl.: 6 egy tökéletes szám, mert az osztói : 1, 2, 3 és ezek összege 6
// 28 egy tökéletes szám, mert az osztói : 1, 2, 4, 7, 14 és ezek összege 28



bool IsPerfect(int n)
{
    int x = n / 2;
    int sum = 0;
    for (int i = 1; i <= x; i++)
    {
        if (n % i == 0)
        {
            sum = sum + i;
        }
    }
    if (sum == n)
    {
        return true;
    }
    else
    {
        return false;
    }
}



// Írj metódust, ami kiírja az első “n” olyan számot, amiben a számjegyek összege “n”!
// “n”-t paraméterben kapja meg a függvény.

// NxN(11);
void NxN(int n) //11
{
    int i = 0;
    int j = 0;
    while (i < n) //0<111
    {
        if (SumDigits(j) == n)
        {
            Console.WriteLine(j);
            i++;
        }
        j++;
    }
}

// Írj függvényt, ami visszaadja egy szám számjegyeinek összegét!
int SumDigits(int a)
{
    int sum = 0;

    while (a != 0)
    {
        int y = a % 10; // 2
        sum = sum + y; // 0+2
        a = a / 10; // 123
    }
    return sum;
}

// Írj függvényt, ami két paraméterben kapott egész számnak kiszámolja a legnagyobb közös osztóját és visszatér vele!
// Legnagyobb közös osztó függvény
int GreCoDiv(int a, int b)
{

    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else // if (b > a)
        {
            b = b - a;
        }
    }
    return a;
}


int GreCoDiv2(int a, int b)
{
    if (a < b)
    {
        b = b - a;
    }
    if (a != b)
    {
        a = GreCoDiv2(b, a);
    }
    return a;
}
