/*Scrieti un program care va inversa elementele unui vector
 Lungimea vectorului va fi citita de la tastatura
 Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
 Afisarea vectorului se va face printr-o functie de afisare dedicata*/

Console.WriteLine("Introduceti lungimea vectorul");
int n = int.Parse(Console.ReadLine());
int[] vector = new int[n];
for (int i = 0; i < vector.Length; i++)
{
    vector[i] = int.Parse(Console.ReadLine());
}

int k=0, j=n-1;
while(k<=j)
{
    int aux = vector[k];
    vector[k] = vector[j];
    vector[j] = aux;
    k++;j--;
}
AfisareVector(vector);

static void AfisareVector(int[]vector1)
{
    for(int i = 0; i < vector1.Length; i++)
    {
        Console.WriteLine(vector1[i]);
    }
}