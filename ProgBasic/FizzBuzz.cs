// Írj programot, ami ebegér egy egész számot `number` néven.
// 
// A programot kiírja a számokat a konzolra 1-től “number”-ig, de…

// - Ha a szám 3 többszöröse, a szám helyett: „fizz”-t írjon!
// - Ha a szám 5 többszöröse, akkor „buzz”-t írjon!
// - Ha a szám 3 és 5 többszöröse is, akkor „fizzbuzz”-t írjon!
// - Minden egyéb esetben a számot magát írja ki!
/*

// Bekéri a határértéket és tájékoztat, hogy ki fogja írni az ereményeket
Console.WriteLine("Add meg meddig írjuk ki a Fizz-t meg a Buzzt");
string line = Console.ReadLine();
int n = int.Parse(line);
Console.WriteLine("Eredmények:");

int i = 1; // Ezzel a számmal kezdjük a sorozatot

// Megvizsgáljuk a számokat egyesével és kiírjuk amit kell

while (i <= n) // Végigmeggyünk a számokon amíg el nem érjük a bekért határértéket
{

    float fizz = i % 3; // Megvizsgáka mennyi a maradék ha hárommal elosztjuk a számot
    float buzz = i % 5; // Megvizsgáka mennyi a maradék ha öttel elosztjuk a számot


    if (fizz == 0 && buzz == 0) // Ha osztható öttel és hárommal is 
    {
        Console.WriteLine("FizzBuzz"); // Kiírja FizzBuzz
    }
    else if(fizz == 0) // Ha az előző feltétel nem teljesül, de hárommal osztható
    {
        Console.WriteLine("Fizz"); // Kiírja Fizz
    }
    else if(buzz == 0) // Ha az előző feltételek nem teljesülnek, de öttel osztható
    {
        Console.WriteLine("Buzz"); // Kiírja Buzz
    }
    else // Ha egyik korábbi feltétel sem teljesül
    {
        Console.WriteLine(i); // Kiírja magát a számot
    }

    i++; // Növeljük a számot egyel, hogy a ciklus megvizsgálja a következő számot is
}

*/