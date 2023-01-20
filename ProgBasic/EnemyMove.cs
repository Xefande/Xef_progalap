/*
using System.ComponentModel; // Ez a sor nem tudom mikor, hogyan, minek került ide. Egyszer csak itt lett és nem merem bántani :S

// 
// Feladat:
// Írj programot, ami kiírja, hogy mennyi ideig tart egy ellenfélnek, hogy elérjen hozzánk.
//


// Játékos pozíciójának bekérése

Console.WriteLine("Add meg a játékos X koordinátáját méterben: "); //Player X to line 
string line = Console.ReadLine(); 

Console.WriteLine("Add meg a játékos Y koordinátáját méterben: "); // Player Y to line2
string line2 = Console.ReadLine();


// Ellenfél pozíciójának bekérése

Console.WriteLine("Add meg az ellenfél X koordinátáját méterben: "); // Enemy X to line3
string line3 = Console.ReadLine();

Console.WriteLine("Add meg az ellenfél Y koordinátáját méterben: "); // Enemy Y to line4
string line4 = Console.ReadLine();


// Koordináta adatok átalakítása számmá

float xPlayer = float.Parse(line);
float yPlayer = float.Parse(line2);
float xEnemy = float.Parse(line3);
float yEnemy = float.Parse(line4);


// Játékos és ellenfél egymástól való távolságának kiszámítása x és y tengelyen.

float dx = Math.Abs(xPlayer - xEnemy); // Ennyire van az ellenfél a játékostól X tengelyen (m)
float dy = Math.Abs(yPlayer - yEnemy); // Ennyire van az ellenfél a játékostól Y tengelyen (m)


// Ha ugyanott van a játékos és az ellenfél
if (dx == 0 && dy == 0) { Console.WriteLine("Baszdki mán késő! Elkapott a ganyé!"); }


// Ha a játékos és az ellenfél nem egy helyen tartózkodnak
else
{
    Console.WriteLine("Add meg az ellenfél sebességét a játékoshoz képes m/s-ban:"); // Ellenfél sebességének bekérése
    string line5 = Console.ReadLine();
    float enemySpeed = float.Parse(line5); // Ellenfél sebessége (m/s)

    // Ha nem mozdul az ellenfél
    if (enemySpeed == 0) { Console.WriteLine("Mindketten be vagytok szarva. Álltok mint fasz a lakadalomba és nézitek egymást, hogy most mi a fasz van!"); }

    // Ha távolodik az ellenfél
    else if (enemySpeed < 0) { Console.WriteLine("Menekül a gané! Fuss utánna, szökni akar!"); } 

    // Ha közeledik az ellenfél
    else
    {
        Console.WriteLine("x táv: " + dx);
        Console.WriteLine("y táv: " + dy);

        //
        // s = ? játékos és ellenfél közti távolság
        // t = ? ennyi idő alatt ér oda az ellenfél a játékoshoz
        //
 
        //
        // s^2 = dx^2 + dy^2  => s = √(dx^2 + dy^2)
        // enemySpeed = s / t  =>  t = s / enemySpeed
        // t = (√(dx^2 + dy^2)) / enemySpeed  
        //

        //
        // Feltételezzük, hogy:
        // - a játékos egy helyben áll
        // - az ellenfél sebességvektora pedig a játékos irányába mutat
        // - és egyenletes mozgást végez.
        //

        double t = Math.Sqrt(dx * dx + dy * dy) / enemySpeed; // Találkozás t idő múlva

        Console.WriteLine("Itt van a szarházi " + (Math.Sqrt(dx * dx + dy * dy)) + " méter távolságra.");
        Console.WriteLine("A helyedben menekülnék. " + t + " másodperc múlva ideér!");
    }
}

*/