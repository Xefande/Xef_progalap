
//
// Írj programot, ami egy bemeneti egész számról eldönti és kiírja, hogy prím-e.
//

/*
// Bekéri a számot
Console.WriteLine("Írd be a vizsgálni kívánt számot és eldöntöm prím szám-e!");
string line = Console.ReadLine();
float x = float.Parse(line);

// Deklarálja a használni kívánt változókat
float maradek = 0f;
int osztokSzama = 0;
int i = 2;

// Végig megy a számokon és osztható-e maradék nélkül. Ha osztót talál, növeli az osztók számát. 
while (i < x) 

{
    maradek = x % i;
    
    if (maradek == 0) 
    { 
        osztokSzama++; 
 //     Console.WriteLine("Van osztója");    
    }
 // else { Console.WriteLine(i); }

    i++;
}

// Ha nem talált osztót, kiírja hogy prím.
if (osztokSzama == 0)
{
    Console.WriteLine("A megadott szám prím!");
}
// Ha van talált osztót, kiírja, hogy nem prím és az osztók számát.
else {
    Console.WriteLine("A megadott szám gecire nem NEM prím, mer' van neki " + osztokSzama + " osztója");
}

*/