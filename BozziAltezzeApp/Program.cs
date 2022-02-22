using System;

namespace BozziAltezzeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ricerca dei più alti");

            // dichiaro un vettore di 20 elementi
            int[] altezze = new int[20];

            for(int i=0; i<20; i++)
            {
                Console.WriteLine("Inserisci l'altezzza della persona:");
                altezze[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
