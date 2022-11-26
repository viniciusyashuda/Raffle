using System;
using System.Linq;

namespace Raffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux;
            int[] vetor = new int[10];

            Console.WriteLine("Ordered values:");

            for (int k = 0; k < vetor.Length; k++)
            {
                vetor[0] = new Random().Next(0, 100);

                for (int i = 0; i < vetor.Length; i++)
                    for (int j = i + 1; j < vetor.Length; j++)
                        if (vetor[i] > vetor[j])
                        {
                            aux = vetor[i];
                            vetor[i] = vetor[j];
                            vetor[j] = aux;
                        }
            }

            //Using Linq:
            var orderedUsingLinq = vetor.OrderBy(vetor => vetor);

            foreach (var vetorLinq in orderedUsingLinq)
                Console.WriteLine(vetorLinq);

            Console.WriteLine("\n\n");

            for (int k = 0; k < vetor.Length; k++)
                Console.WriteLine(vetor[k]);

        }
    }
}

