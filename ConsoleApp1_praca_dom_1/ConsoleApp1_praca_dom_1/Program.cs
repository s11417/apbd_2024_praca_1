// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
string opis1 = "pojazd sprawny";
string opis2 = "pojazd do sprawdzenia";
string opis3 = "pojazd czasowo wyłaczony z użycia";
int tablica []={1,2,3,4,5,5,56};
 public static int averageFeature(int [] tablica)
    {
   int average=0;
   foreach (int item in tablica)
        {
    //pętla zliczajaca
            Console.WriteLine("Element [{0}] wynosi: {1}", i, item);
            i++;
    average=+item;
    
        }
    Console.WriteLine(average/tablica.Length);
    }
public static int element maksymalny(int[] tablica)
{
    int maxE = tablica[0];
    for (int index = 1; index < tablica.Length; index++)
    {
        if (tablica[index] > maxE)
            maxE = tablica[index];
    }
    return maxE;
}
