using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] cuvinte= new string[26][];
            if (args.Length == 0)
                Console.Write("Linia de comanda nu contine argumente");
            else
            {
                for(int i=0;i<cuvinte.GetLength(0);i++)
                {
                    cuvinte[i] = new string[1];
                }
                // afisarea numarului de argumente
                Console.WriteLine("Numarul de argumente este: {0}", args.Length);
                // afisarea argumentelor liniei de comanda
                foreach (string param in args)
                    Console.WriteLine(param);
                foreach (string cuvant in args)
                {
                    try
                    {
                        int firstLetter = Convert.ToInt32(cuvant[0] - 'a');
                        cuvinte[firstLetter][0] += cuvant + " ";
                    }
                    catch
                    {
                        int firstLetter = Convert.ToInt32(cuvant[0] - 'A');
                        cuvinte[firstLetter][0] += cuvant + " ";
                    }
                }
                for (int i=0; i<cuvinte.Length;i++)
                {
                    if (cuvinte[i][0] != null)
                        Console.Write("\n" + (char)('A' + i) + ": ");
                    for (int j=0; j< cuvinte[i].Length;j++)
                    {
                        if( cuvinte [i][j] != null)
                        {
                            Console.Write(cuvinte[i][j]);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
