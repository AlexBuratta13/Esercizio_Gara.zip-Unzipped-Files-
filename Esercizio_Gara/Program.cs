using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercizio_Gara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci numero partecipanti: ");
            int p = int.Parse(Console.ReadLine());
            List<string> partecipanti = new List<string>();
            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine($"Inserisci nome del corridore {i}: ");
                string nome = Console.ReadLine();
                partecipanti.Add(nome);
                Corri(nome);
            }
            Console.ReadLine();
        }

        private static async Task Corri(string nome)
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < 100; i++)
                {
                    Console.WriteLine($"{nome} è al km {i}.");
                }
                Console.WriteLine($"{nome} è arrivato al km 100 e ha finito la corsa");
            });
        }
    }
}
