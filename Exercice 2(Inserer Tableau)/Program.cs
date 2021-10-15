using System;

namespace Exercice2_tableau
{
    class Tableau
    {
        static void Main(string[] args)
        {

            

            Console.Write(" Entrer le nombre des élements de tableau   :   ");
            int element = Convert.ToInt32(Console.ReadLine());

            int[] t = new int[element];
            int i;
            Console.WriteLine();
            for (i = 0; i < element; i++)
            {
                Console.Write("Veuillez entrez l'élement " + (i + 1) + " =   ");
                t[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(t);
            Console.Write("\n Le tableau est trié  !  \n");
            for (i = 0; i < element; i++)
            {
                
                Console.WriteLine("l'élement [{0}] : {1}", (i + 1), t[i]);
            }
            Array.Resize(ref t, t.Length + 1);

            Console.Write("\n\n Veuillez entrer la valeur à insérer: ");
            int nbr = Convert.ToInt32(Console.ReadLine());
            t[i] = nbr;
            inserer(t);
            Console.ReadKey();
        }


        public static void inserer(int[] t)
        {
            int i;

            for (i = 0; i < t.Length; i++)
            {
                Array.Sort(t);
                Console.WriteLine("l'élement  [{0}] : {1}", (i + 1), t[i]);

            }


            Console.WriteLine();
        }

    }
}