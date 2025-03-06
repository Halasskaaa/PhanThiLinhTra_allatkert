using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokClass
{
    internal class Allatkert
    {
        private List<IAllat> allatLista;
        private Random random;

        public Allatkert()
        {
            random = new Random();
            int allatSzam = random.Next(5, 16);
            allatLista = new List<IAllat>();

            for (int i = 0; i < allatSzam; i++)
            {
                switch (random.Next(5))
                {
                    case 0:
                        allatLista.Add(new ViziAllat());
                        break;
                    case 1:
                        allatLista.Add(new SzarazHideg());
                        break;
                    case 2:
                        allatLista.Add(new SzarazMedi());
                        break;
                    case 3:
                        allatLista.Add(new SzarazMeleg());
                        break;
                    case 4:
                        allatLista.Add(new SzarazTropusi());
                        break;
                }
            }
        }

        public void Verseny()
        {
            Console.WriteLine("Verseny indul!");

            List<int> positions = new List<int>(new int[allatLista.Count]);

            int maxSteps = 10;
            for (int step = 0; step < maxSteps; step++)
            {
                Console.Clear();

                for (int i = 0; i < allatLista.Count; i++)
                {
                    positions[i] += allatLista[i].Seb;
                }

                foreach (var animal in allatLista)
                {
                    int position = positions[allatLista.IndexOf(animal)];
                    Console.SetCursorPosition(0, allatLista.IndexOf(animal));
                    Console.WriteLine($"{animal.Nev}: " + new string('O', position));
                }

                Thread.Sleep(500);
            }

            int maxPosition = positions.Max();
            int winnerIndex = positions.IndexOf(maxPosition);
            Console.WriteLine("\nA verseny győztese: " + allatLista[winnerIndex].Nev);
        }

        public void AllatokInfo()
        {
            foreach (var allat in allatLista)
            {
                Console.WriteLine(allat);
            }
        }
    }
}
