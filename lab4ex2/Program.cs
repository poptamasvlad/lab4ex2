using System;

namespace lab4ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
            k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
                Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
            rezultatul.
                Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
            rezultatul. */

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[,,] matrice = new int[n, m, k];
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    for (int l = 0; l < matrice.GetLength(2); l++)
                    {
                        matrice[i, j, l] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("Suma elementelor este: " + Suma(matrice));
            Console.WriteLine("Cel mai mare numar este: " + Maxim(matrice));
        }
           
        static int Suma(int[,,] matrice)
        {
            int suma = 0;
            for(int i=0; i<matrice.GetLength(0); i++ )
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    for (int l = 0; l < matrice.GetLength(2); l++)
                    {
                        suma += matrice[i,j,l];
                    }
                }
            }
            return suma;
        }

        static int Maxim(int[,,] matrice)
        {
            int maxim = matrice[0, 0, 0];
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    for (int l = 0; l < matrice.GetLength(2); l++)
                    {
                        if(matrice[i,j,l] > maxim)
                        {
                            maxim = matrice[i, j, l];
                        }
                    }
                }
            }
            return maxim;
        }
    }
}
