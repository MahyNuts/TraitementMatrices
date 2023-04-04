using System;

namespace TraitementsMatrices
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("Nombres de lignes de la première matrice -> "+L1);
            Console.WriteLine("Nombres de colonnes de la première matrice -> " + C1);
            Console.WriteLine("Nombres de lignes de la deuxième matrice -> " + L2);
            Console.WriteLine("Nombres de colonnes de la deuxième matrice -> " + C2);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            int[,] M2; //Deuxième matrice
            string stringTab1; //Concaténation de la première matrice
            string stringTab2; // Concaténation de la deuxième matrice
            int[,] M1; // Première matrice
            int[,] MR; // Résultat de l'addition
            bool R; // Booléen de vérification de l'addition
            bool verifBool; // Booléen de vérification de la multiplication
            int[,] result; // Résultat de la multiplication
            string stringMR; // Concaténation de l'addition
            string stringResult; // Concaténation de la multiplication
            sousProgrammes sousProgrammes = new sousProgrammes();


            sousProgrammes.RemplissageMatrice(L1, C1, L2, C2, out M1, out M2);
            sousProgrammes.ConcatenationMatrice(M1, M2, L1, C1, L2, C2, out stringTab1, out stringTab2);
            Console.WriteLine("Première matrice :");
            Console.WriteLine(stringTab1);
            Console.WriteLine("");
            Console.WriteLine("Deuxième matrice :");
            Console.WriteLine(stringTab2);
            sousProgrammes.AdditionMatrices(L1, C1, L2, C2, M1, M2,out MR, out R );
            sousProgrammes.MultiplicationMatrices(M1, M2, out verifBool, out result);
            sousProgrammes.ConcatenationResultat(L1, C1, L2, C2, MR, result, out stringMR, out stringResult);
            Console.WriteLine("Addition :");
            if (R == true)
            {
                Console.WriteLine(stringMR);
            }
            else
            {
                Console.WriteLine("Addition impossible.");
            }
            Console.WriteLine("");
            Console.WriteLine("Multiplication :");
            if (verifBool == true)
            {
                Console.WriteLine(stringResult);
            }
            else
            {
                Console.WriteLine("Multiplication impossible.");
            }
        }
    }
}
