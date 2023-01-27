//  Két dobókockás szimuláció
// Szimulálja a két dobókockával való gurítást és az eredményeből előfordulást számol
// Az eredméények eloszlása gauss görbét kell kiadjon


/*
int d2 = 0;
int d3 = 0;
int d4 = 0;
int d5 = 0;
int d6 = 0;
int d7 = 0;
int d8 = 0;
int d9 = 0;
int d10 = 0;
int d11 = 0;
int d12 = 0;

int i = 0;

Console.WriteLine("Hányszor fusson le a szimuláció?");
string line = Console.ReadLine();
int j = int.Parse(line);

while (i < j){

    Random rnd = new Random();
    int dice1 = rnd.Next(1, 7);

    Random rnd2 = new Random();
    int dice2 = rnd2.Next(1, 7);

    int result = dice1 + dice2;

    if (result == 7) { d7++; }
    else if (result == 8) { d8++; }
    else if (result == 6) { d6++; }
    else if (result == 9) { d9++; }
    else if (result == 5) { d5++; }
    else if (result == 10) { d10++; }
    else if (result == 4) { d4++; }
    else if (result == 11) { d11++; }
    else if (result == 3) { d3++; }
    else if (result == 12) { d12++; }
    else if (result == 2) { d2++; }
    else { Console.WriteLine("Error: Something went wrong!"); }
    i++;
}

Console.WriteLine("Szimuláció eredményei:");

Console.WriteLine("02: " + d2 + " | Valószínűség: " + (((float)d2*100)/(j)) + " %" );
Console.WriteLine("03: " + d3 + " | Valószínűség: " + (((float)d3 * 100) / (j)) + " %" );
Console.WriteLine("04: " + d4 + " | Valószínűség: " + (((float)d4 * 100) / (j)) + " %" );
Console.WriteLine("05: " + d5 + " | Valószínűség: " + (((float)d5 * 100) / (j)) + " %");
Console.WriteLine("06: " + d6 + " | Valószínűség: " + (((float)d6 * 100) / (j)) + " %");
Console.WriteLine("07: " + d7 + " | Valószínűség: " + (((float)d7 * 100) / (j)) + " %");
Console.WriteLine("08: " + d8 + " | Valószínűség: " + (((float)d8 * 100) / (j)) + " %");
Console.WriteLine("09: " + d9 + " | Valószínűség: " + (((float)d9 * 100) / (j)) + " %");
Console.WriteLine("10: " + d10 + " | Valószínűség: " + (((float)d10 * 100) / (j)) + " %");
Console.WriteLine("11: " + d11 + " | Valószínűség: " + (((float)d11 * 100) / (j)) + " %");
Console.WriteLine("12: " + d12 + " | Valószínűség: " + (((float)d12 * 100) / (j)) + " %");
*/ 