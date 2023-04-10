using System;
using System.Collections.Generic;
using System.Text;

namespace TraitementsMatrices
{
    public struct sousProgrammes
    {
        public void RemplissageMatrice(int L1, int C1, int L2, int C2, out int[,] M1, out int[,] M2)
        {
            Random n = new Random();
            M1 = new int[L1, C1];
            M2 = new int[L2, C2];
            for (int i = 0; i < L1; i++)
            {
                for(int j = 0; j < C1; j++)
                {
                    M1[i, j] = n.Next(0, 21);
                }
            }

            for (int i = 0; i < L2; i++)
            {
                for (int j = 0; j < C2; j++)
                {
                    M2[i, j] = n.Next(0, 21);
                }
            }
        }

        public void ConcatenationMatrice(int[,] M1, int[,] M2, int L1, int C1, int L2, int C2, out string stringTab1, out string stringTab2)
        {
            stringTab1 = "";
            stringTab2 = "";

            for (int i = 0; i < L1; i++)
            {
                for(int j = 0; j < C1 ; j++)
                {
                    stringTab1 += M1[i, j] + "|";
                }
                stringTab1 += "\n";
            }

            for (int i = 0; i < L2; i++)
            {
                for (int j = 0; j < C2; j++)
                {
                    stringTab2 += M2[i, j] + "|";
                }
                stringTab2 += "\n";
            }
        }

        public void AdditionMatrices(int L1, int C1, int L2, int C2, int[,] M1, int[,] M2,out int[,] MR, out bool R)
        {
            R = true;
            MR = new int[L1, C2];
            if (M1.GetLength(0) == M2.GetLength(0) && M1.GetLength(1) == M2.GetLength(1))
            {
                for(int i = 0; i < L1; i++)
                {
                    for (int j = 0; j < C2; j++)
                    {
                        MR[i,j] = M1[i,j] + M2[i,j];
                    }
                }
            }
            else
            {
                R = false;
            }
        }

        public void MultiplicationMatrices(int[,] M1, int[,] M2,out bool verifBool, out int[,] MR)
        {
            verifBool  = true;
            MR = new int[M1.GetLength(0), M2.GetLength(1)];
            if(M1.GetLength(1) == M2.GetLength(0))
            {
                for(int i = 0; i < M1.GetLength(0); i++)
                {
                    for(int j = 0; j < M2.GetLength(1); j++)
                    {
                        MR[i, j] = 0;
                        for(int k = 0; k < M1.GetLength(1); k++)
                        {
                            MR[i, j] = MR[i, j] + M1[i, k] * M2[k, j];
                        }
                    }
                }
            }
            else
            {
                verifBool = false;
            }
        }

        public void ConcatenationResultat(int L1, int C1, int L2, int C2, int[,] MR, out string stringMR)
        {
            stringMR = "";
            for (int i = 0; i < MR.GetLength(0); i++)
            {
                for (int j = 0; j < MR.GetLength(1); j++)
                {
                    stringMR += MR[i, j] + "|";
                }
                stringMR += "\n";
            }
        }
    }
}
