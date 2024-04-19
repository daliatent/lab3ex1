/*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la
tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
Dificultate ridicata
• Numerele patrate perfecte din vector
Apelati functiile si afisati-le rezultatele.*/
Console.WriteLine("Introduceti lungimea vectorul");
int n=int.Parse(Console.ReadLine());
int[] vector = new int[n];
for (int i=0; i<vector.Length; i++)
{
    vector[i] = int.Parse(Console.ReadLine());
}

int maxElement=CelMaiMare(vector);
int minElement=CelMaiMic(vector);
int[] nrdivizibil = NumereDivizibileCuTrei(vector);

Console.WriteLine("Cel mai mare element din vector este " +maxElement);
Console.WriteLine("Cel mai mic element din vector este " + minElement);
Console.WriteLine("Numerele divizibile cu 3 " + nrdivizibil);
static int CelMaiMare(int[]vector)
{
    int max = vector[0];
    for(int i=1; i<vector.Length; i++)
    {
        if (vector[i] > max)
        {
            max= vector[i];
        }    
    }
    return max;
}

static int CelMaiMic(int[]vector1)
{
    int min=vector1[0];
    for(int i=1; i<vector1.Length; i++)
    {
        if(vector1[i] < min)
        {
            min= vector1[i];
        }
    }
    return min;
}
static int [] NumereDivizibileCuTrei(int[]vector2)
{
    int count = 0;
    for(int i=0; i<vector2.Length; i++)
    {
        if (vector2[i]%3==0)
        {
            count++;
        }
    }
    int[] rezultat = new int[count];
    int index = 0;
    for(int i=0; i<vector2.Length; i++)
    {
        if (vector2[i] %3==0)
        {
            rezultat[index] = vector2[i];
            index++;
        }
    }
    return rezultat;
   
}
/*static void NumereDivizibileCuTreiSiAfisare(int[]vector3)
{
    for(int i=0; i<vector3.Length; i++)
    {
        if (vector3[i]%3==0)
        {
            Console.WriteLine(vector3[i]+ " ");
        }
    }
    Console.WriteLine();
}*/
