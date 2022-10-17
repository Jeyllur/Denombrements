using System;


namespace Denombrements
{
    class Program
    {
      static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                try
                {
                    c = int.Parse(Console.ReadLine());
                    if (c != 0)
                    {
                        
                        switch (c)
                        {
                            case 1:
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                int n = int.Parse(Console.ReadLine()); // saisir le nombre                                                                     
                                long r = 1;
                                for (int k = 1; k <= n; k++)
                                    r *= k;
                                Console.WriteLine(n + "! = " + r);
                                break;
                         case 2:
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                int t = int.Parse(Console.ReadLine()); // saisir le nombre
                                Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                                n = int.Parse(Console.ReadLine()); // saisir le nombre                                                                  
                                r = 1;
                                for (int k = (t - n + 1); k <= t; k++)
                                {
                                    r *= k;
                                }
                                //Console.WriteLine("résultat = " + (r1 / r2));
                                Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                                break;
                         case 3:
                                Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                                t = int.Parse(Console.ReadLine()); // saisir le nombre
                                Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                                n = int.Parse(Console.ReadLine()); // saisir le nombre                                                                 
                                long r1 = 1;
                                for (int k = (t - n + 1); k <= t; k++)
                                    r1 *= k;
                                // calcul de r2
                                long r2 = 1;
                                for (int k = 1; k <= n; k++)
                                    r2 *= k;                             
                                //Console.WriteLine("résultat = " + (r1 / r2));
                                Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                                break;

                         default:
                                Console.WriteLine("Entrez le nombre de 0 à 3, s'il vous plaît");
                                break;

                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                catch
                {
                    Console.WriteLine("Il faut saisir un chiifre de 0 à 3!");
                }
            }
            Console.ReadLine();
        }
    }
}
