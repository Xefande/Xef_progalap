/*

// Basic Calculator

string text1 = "Alapműveletek két számmal.";
string text2 = "Add meg az első számot:";
string text3 = "Add meg a második számot:";
string r1 = "A két szám összege: ";
string r2 = "A két szám különbsége: ";
string r3 = "A két szám szorzata: ";
string r4 = "A két szám hányadosa: ";
string text4 = "Az alapműveletek eredményei: ";
string text5 = "Az alapműveletek eredményei, a két szám felcserélése esetén: ";

// Inform the user what is for is this

Console.WriteLine(text1);

// Asking for the first number

Console.WriteLine(text2);
string line = Console.ReadLine();
int a = int.Parse(line);

// Asking for the second number

Console.WriteLine(text3);
string line2 = Console.ReadLine();
int b = int.Parse(line2);

// Print results

Console.WriteLine(text4);

Console.WriteLine(r1 + (a+b) +" ("+ a +"+"+ b +")");
Console.WriteLine(r2 + (a-b) + " (" + a + "-" + b + ")");
Console.WriteLine(r3 + (a*b) + " (" + a + "×" + b + ")");
Console.WriteLine(r4 + ((float)a/b) + " (" + a + "/" + b + ")");

// Inverse results

// Invert variables

int c = a;
a = b;
b = c;

// Pront inverse results (reciprocal)

Console.WriteLine(text5);

Console.WriteLine(r1 + (a + b) + " (" + a + "+" + b + ")");
Console.WriteLine(r2 + (a - b) + " (" + a + "-" + b + ")");
Console.WriteLine(r3 + (a * b) + " (" + a + "×" + b + ")");
Console.WriteLine(r4 + ((float)a / b) + " (" + a + "/" + b + ")");




*/