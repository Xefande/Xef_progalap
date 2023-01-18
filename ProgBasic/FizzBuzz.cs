/*

Console.WriteLine("Add meg meddig írjuk ki a Fizz-t meg a Buzzt");
string line = Console.ReadLine();
int n = int.Parse(line);
Console.WriteLine("Eredmények:");


int i = 1;
while (i <= n)
{

    float fizz = i % 3;
    float buzz = i % 5;


    if (fizz == 0 && buzz == 0) 
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(fizz == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if(buzz == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }

    i++;
}

*/