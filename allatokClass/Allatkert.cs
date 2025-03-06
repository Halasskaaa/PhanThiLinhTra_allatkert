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

        public void ListFaj()
        {
            Console.WriteLine("Állatkert jelenlegi állapota:");

            int totalSpace = 15;  // Maximum number of animals the zoo can hold
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
    int maxSteps = 10;
    int raceDistance = 50;

    for (int step = 0; step < maxSteps; step++)
    {
        Console.Clear();

        for (int i = 0; i < allatLista.Count; i++)
        {
            int moveDistance = (allatLista[i].Seb * raceDistance) / 100;
            positions[i] += moveDistance;
        }

        for (int i = 0; i < allatLista.Count; i++)
        {
            int position = positions[i];
            Console.SetCursorPosition(0, i);
            Console.WriteLine($"{allatLista[i].Nev}: " + new string('O', position));
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
