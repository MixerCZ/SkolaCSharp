using System;

class Program
{
    static void Main()
    {
        int cislo;
        int counter = 0, max = 0, sum = 0, min = 2100000000;
        double avg = 0;
        
        do
        {
            Console.Write($"Zadej {counter+1}. číslo: ");
            cislo = int.Parse(Console.ReadLine());
            if (cislo != 0)
            {
                if(cislo < min)
                    min = cislo;

                if (cislo > max)
                    max = cislo;

                sum += cislo;
                counter++;
                avg = sum / (double) counter;
            }
            
        } while (cislo != 0);

        Console.WriteLine($"Minimum je {min}, maximum je {max}, průměr je {avg}. Zadal si {counter} čísel.");
        Console.ReadKey();
    }
}

