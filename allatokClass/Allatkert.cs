using System;
using System.Collections.Generic;
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

        public void ListFaj()
        {
            Console.WriteLine("Állatkert jelenlegi állapota:");

            int totalSpace = 15;
            int filledSpace = allatLista.Count;

            double filledPercentage = (double)filledSpace / totalSpace * 100;
            Console.WriteLine($"Az állatkert megtelt: {filledPercentage}% ({filledSpace}/{totalSpace} állat)");

            Console.Write("Állatkerti térképe: ");
            for (int i = 0; i < totalSpace; i++)
            {
                if (i < filledSpace)
                    Console.BackgroundColor = ConsoleColor.Green;
                else
                    Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }

        public void Verseny()
        {
            Console.WriteLine("Verseny indul!");

            List<int> positions = new List<int>(new int[allatLista.Count]);
            List<int> speed = allatLista.Select(a => a.Seb).ToList();

            int maxDistance = 100;
            int stepDuration = 1000;

            while (positions.Max() < maxDistance)
            {
                Console.Clear();
                for (int i = 0; i < allatLista.Count; i++)
                {
                    positions[i] += (speed[i] / 10);
                }

                for (int i = 0; i < allatLista.Count; i++)
                {
                    Console.SetCursorPosition(positions[i], i);
                    Console.Write($"{allatLista[i].Nev[0]}");
                }

                Thread.Sleep(stepDuration);
            }

            int winnerIndex = positions.IndexOf(positions.Max());
            Console.WriteLine($"\nA verseny győztese: {allatLista[winnerIndex].Nev}, Sebesség: {allatLista[winnerIndex].Seb}");
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
