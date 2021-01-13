/* Augusto adora se exercitar, por isso levanta todos os dias 6h da manhã, em qualquer tempo ou estação do ano. Ele corre em volta de uma lagoa. Ao longo da pista de corrida existem N placas igualmente espaçadas. Augusto conta o número de placas pelas quais ele já passou e verifica se ele já correu pelo menos 10%, 20%, 90% do percurso.

Vamos ajudar o Augusto, calculando para ele o número de placas que ele precisa contar para ter completado pelo menos 10%, 20%, 90% da corrida, de acordo com o número de voltas que ele quer correr e o número total de placas ao longo da pista.

Se Augusto quiser dar 3 voltas e o número de placas for 17, para garantir ter corrido pelo menos 30% do percurso, ele precisa contar 16 placas. Para garantir pelo menos 60%, ele precisa contar 31 placas. */

using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] tokens = Console.ReadLine().Split(" ");

            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
            
            var numeroDeVoltas = convertedItems[0];
            var numeroDePlacasNaPista = convertedItems[1];
            var dezPercent = (numeroDeVoltas * numeroDePlacasNaPista) * 0.1;

            for (int i = 1; i < 10; i++)
            {
                Console.Write(Math.Ceiling(dezPercent * i).ToString("0"));
                                
                if(i != 9) Console.Write(" ");
            }
        }
    }
}