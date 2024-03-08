using System;

class Text
{
    public int pocetSamohlasek(string text)
    {
        text = text.ToLower();
        int samo = 0;
        for (int i = 0; i < text.Length; i++)
            if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u' || text[i] == 'y') samo++;
        return samo;
    }
}

class Program
{
    static void Main()
    {
        //Samohlasky();
        Caesar();
    }
    static void Samohlasky()
    {
        Console.Write("Napiš slovo: ");
        string str = Console.ReadLine();
        Console.WriteLine("V tomto slově je " + new Text().pocetSamohlasek(str) + " samohlásek");
        Console.ReadLine();
    }

     static void Caesar()
     {
         Console.Write("Zadej slovo: ");

         string slovo = Console.ReadLine();

         Console.Write("Zadej posun: ");
         int posun = int.Parse(Console.ReadLine());

         char[] abeceda = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

        char[] noveslovo = new char[20];

        for (int i = 0; i < slovo.Length; i++)
         {
             for(int j = 0; j < 26; j++)
             {
                 if(slovo[i].Equals(abeceda[j]))
                 {
                     int pozice = j;
                     if((j+posun) >= 26) pozice = j-1;
                     noveslovo[i] = abeceda[pozice+posun];
                 }
             }
         }

         Console.Write("Nové slovo je ");
         for(int i = 0; i < noveslovo.Length; i++)
         {
             Console.Write(noveslovo[i]);
         }
         Console.ReadLine();
     }

    static void Test()
    {
        Console.WriteLine("Zadej velikost pole:");
        int[] arr = new int[int.Parse(Console.ReadLine())];
       /* for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if(i != arr.Length - 1)
                Console.Write(", ");
        }*/

        int j = 0;
        foreach(int i in arr)
        {
            Console.Write(i);
            if (j != arr.Length - 1)
                Console.Write(", ");
            j++;
        }
        Console.Read();
    }

    static void Pocitadlo()
    {
        int cislo;
        int counter = 0, max = 0, sum = 0, min = int.MaxValue;
        double avg = 0;

        do
        {
            Console.Write($"Zadej {counter + 1}. číslo: ");
            cislo = int.Parse(Console.ReadLine());
            if (cislo != 0)
            {
                if (cislo < min)
                    min = cislo;

                if (cislo > max)
                    max = cislo;

                sum += cislo;
                counter++;
                avg = sum / (double)counter;
            }

        } while (cislo != 0);

        Console.WriteLine($"Minimum je {min}, maximum je {max}, průměr je {avg}. Zadal si {counter} čísel.");
        Console.ReadKey();
    }

    static void NacteniZnamek()
    {
        Console.Write("Zadej velikost pole: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        int sum = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            do
            {
                Console.Write($"Zadej {i + 1}. hodnotu: ");
                arr[i] = int.Parse(Console.ReadLine());
            } while (arr[i] > 0 && arr[i] <= 5);
            sum += arr[i];
        }

        double avg = (double)sum / (double)arr.Length;
        Console.WriteLine("Průměr známek je " + avg);
    }

    static void MinMax()
    {
        int min = int.MaxValue, max = int.MinValue, sum = 0;
        for(int i = 0; i < 4; i++)
        {
            Console.Write($"Zadej {i + 1}. hodnotu: ");
            int c = int.Parse(Console.ReadLine());

            if (c > max) max = c;
            if (c < min) min = c;
            sum += c;
        }

        Console.WriteLine("Minimum je " + min + ", maximum je " + max + ", součet je " + sum + ".");
        Console.ReadLine();
    }

    static void ZadejDokud()
    {
        int c;
        int i = 0;
        double vysl = 0;
        do
        {
            Console.Write("Zadej: ");
            c = int.Parse(Console.ReadLine());
            if(c != 0) i++;
            vysl = avg(c, i);
        } while (c != 0);
        Console.Write(vysl);
        Console.Read();
    }
    static int sum = 0;

    static double avg(int num, int i)
    {
        sum += num;
        double avg = (double)sum / (double)i;
        return avg;
    }

    static void binConvert()
    {
        Console.Write("Zadej velikost pole: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];

        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(10);
        }

        binDetect(arr);
    }

    static void binDetect(int []arr)
    {
        int tmp = arr.Length - 1;
        int[] bin = new int[arr.Length];

        Console.Write("Vygenerovaná čísla: ");

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            bin[i] = 3;
            Console.Write(arr[i] + ", ");
            if(arr[i] == 0 || arr[i] == 1)
            {
                bin[tmp] = arr[i];
                tmp--;
            }
        }

        Console.Write("Vygenerovaná čísla bin: ");
        int coef = 1, sum = 0;
        for(int i = arr.Length - 1; i >= 0; i--)
        {
            if(bin[i] != 3)
            {
                Console.Write(bin[i] + ", ");
                sum += bin[i] * coef;
                coef *= 2;
            }
        }

        Console.WriteLine("Bin převedeno do dec: " + sum);
        Console.ReadLine();
    }

}
class Trida
{
    public void Metoda()
    {
        Console.WriteLine("Ahoj");
    }
}

