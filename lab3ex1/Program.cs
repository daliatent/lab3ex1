//Scrieti o functie care va calcula suma cifrelor unui numar.
Console.WriteLine("Introduceti numarul: ");
int n = int.Parse(Console.ReadLine());
var suma = Suma(n);
Console.WriteLine(suma);

static int Suma(int n)
{
    int s = 0;
    while(n!=0)
    {
        s = s + n % 10;
        n = n / 10;
    }
    return s;
}
