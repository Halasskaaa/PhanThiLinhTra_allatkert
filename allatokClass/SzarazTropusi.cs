using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokClass
{
	internal class SzarazTropusi
	{
		private string nev;
		private string faj;
		private int seb;
		private int suly;

		public SzarazTropusi(string nev, string faj, int seb, int suly)
		{
			this.nev = "Leon S. Kennedy";
			this.faj = "jaguár";
			this.seb = 80;
			this.suly = 75;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Faj { get => faj; set => faj = value; }
		public int Seb { get => seb; set => seb = value; }
		public int Suly { get => suly; set => suly = value; }
	}
}
