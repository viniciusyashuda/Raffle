using System;

namespace Raffle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int aux;
            int[] vetor = new int[10];

            Console.WriteLine("\nOrdered values:");

            for (int k = 0; k < vetor.Length; k++)
            {

                vetor[0] = new Random().Next(0, 100);

                for (int i = 0; i < vetor.Length; i++)
                {

                    for (int j = i + 1; j < vetor.Length; j++)
                    {

                        if (vetor[i] > vetor[j])
                        {

                            aux = vetor[i];
                            vetor[i] = vetor[j];
                            vetor[j] = aux;

                        }

                    }

                }
            }

            for (int k = 0; k < vetor.Length; k++)
            {

                Console.WriteLine(vetor[k]);

            }
        }
    }
}

