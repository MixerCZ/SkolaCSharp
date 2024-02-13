using System;

class Program
{
    static void Main()
    {
        //Test();
        //Samohlasky();
        //Pocitadlo();
        //MinMax();
        ZadejDokud();
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
        int c = 0;
        int[] arr = new int[100];
        int i = 0;
        do
        {
            Console.Write("Zadej: ");
            c = int.Parse(Console.ReadLine());
            arr[i] = c;
            i++;
        } while (c != 0);

        avg(arr);
    }

    static void avg(int []arr)
    {
        int sum = 0;
        int c = 0;
        foreach(int i in arr)
        {
            if (i < 10 && i > 0) {
                sum += i;
                c++;
            };
        }

        double avg = (double)sum / (double)c;
        Console.WriteLine("Průměr je " + avg);
        Console.ReadLine();
    }

}

