using System;

namespace TraitementsMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] M2; //Deuxième matrice
            string stringTab1; //Concaténation de la première matrice
            string stringTab2; // Concaténation de la deuxième matrice
            int[,] M1; // Première matrice
            int[,] MR; // Résultat de l'addition ou multiplication
            bool R; // Booléen de vérification de l'addition
            bool verifBool; // Booléen de vérification de la multiplication
            string stringMR; // Résultat de la oncaténation
            int choixOp; //Choix de l'opération
            int choixFin; //Choix recommencer ou nom
            sousProgrammes sousProgrammes = new sousProgrammes();

            do
            {
                int L1;
                do
                {
                    do Console.WriteLine("Nombre de lignes(entre 1 à 10) de la première matrice. ");
                    while (!int.TryParse(Console.ReadLine(), out L1));
                } while (L1 < 1 || L1 > 10);
                int C1;
                do
                {
                    do Console.WriteLine("Nombre de colonnes(entre 1 à 10) de la première matrice.");
                    while (!int.TryParse(Console.ReadLine(), out C1));
                } while (C1 < 1 || C1 > 10);
                int L2;
                do
                {
                    do Console.WriteLine("Nombre de lignes(entre 1 à 10) de la deuxième matrice.");
                    while (!int.TryParse(Console.ReadLine(), out L2));
                } while (L2 < 1 || L2 > 10);
                int C2;
                do
                {
                    do Console.WriteLine("Nombre de colonnes(entre 1 à 10) de la deuxième matrice.");
                    while (!int.TryParse(Console.ReadLine(), out C2));
                } while (C2 < 1 || C2 > 10);

                Console.WriteLine("\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Nombres de lignes de la première matrice -> " + L1);
                Console.WriteLine("Nombres de colonnes de la première matrice -> " + C1);
                Console.WriteLine("Nombres de lignes de la deuxième matrice -> " + L2);
                Console.WriteLine("Nombres de colonnes de la deuxième matrice -> " + C2);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("");

                sousProgrammes.RemplissageMatrice(L1, C1, L2, C2, out M1, out M2);
                sousProgrammes.ConcatenationMatrice(M1, M2, L1, C1, L2, C2, out stringTab1, out stringTab2);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Première matrice :");
                Console.ResetColor();
                Console.WriteLine(stringTab1);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Deuxième matrice :");
                Console.ResetColor();
                Console.WriteLine(stringTab2, "\n \n");
                do
                {
                    do
                    {
                        Console.WriteLine("\n \n \n \n");
                        Console.WriteLine("1 - Addition");
                        Console.WriteLine("2 - Multiplication \n");
                        Console.WriteLine("Quelle opération voulez-vous faire");
                    } while (!int.TryParse(Console.ReadLine(), out choixOp));

                } while (choixOp != 1 && choixOp != 2);

                Console.WriteLine("\n \n \n \n");
                if (choixOp == 1)
                {
                    sousProgrammes.AdditionMatrices(L1, C1, L2, C2, M1, M2, out MR, out R);
                    sousProgrammes.ConcatenationResultat(L1, C1, L2, C2, MR, out stringMR);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Addition :");
                    Console.ResetColor();
                    if (R == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(stringMR);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Addition impossible.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    sousProgrammes.MultiplicationMatrices(M1, M2, out verifBool, out MR);
                    sousProgrammes.ConcatenationResultat(L1, C1, L2, C2, MR, out stringMR);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Multiplication :");
                    Console.ResetColor();
                    if (verifBool == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(stringMR);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Multiplication impossible.");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine("\n \n");
                do
                {
                    do
                    {
                        Console.WriteLine("Voulez-vous recommencer ?");
                        Console.WriteLine("1 - Oui");
                        Console.WriteLine("2 - Non");
                    } while (!int.TryParse(Console.ReadLine(), out choixFin));

                } while (choixFin != 1 && choixFin != 2);
                Console.WriteLine("\n \n \n \n \n \n");
            } while (choixFin != 2);  
        }
    }
}
