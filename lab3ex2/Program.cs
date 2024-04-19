//Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul
Console.WriteLine("introduceti numarul ");
var n =int.Parse(Console.ReadLine());
if(PatratPerfect(n))
{
    Console.WriteLine(n+ " este patrat perfect");
}
else Console.WriteLine(n+ " nu este patrat perfect");


static bool PatratPerfect(int n)
{
    /*int sum = 0;
    for(int i = 1; i < n; i++)
    {
        if(n%i==0)
        {
            sum+=i;
        }
    }*/
    double radacina = Math.Sqrt(n);

    return radacina == (int)radacina;
}
