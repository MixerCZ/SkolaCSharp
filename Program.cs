using System;

class Program
{
    static void Main()
    {
        //Test();
        Samohlasky();
        //Pocitadlo();
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

    static void Samohlasky()
    {
        Console.Write("Napiš slovo: ");
        string str = Console.ReadLine();
        int samo = 0;
        str = str.ToLower();
        for(int i = 0; i < str.Length; i++)
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'y') samo++;
        Console.WriteLine("V tomto slově je " + samo + " samohlásek");
        Console.ReadLine();
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
}

