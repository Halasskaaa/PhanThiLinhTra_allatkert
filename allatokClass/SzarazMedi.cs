using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokClass
{
	internal class SzarazMedi
	{
		private string nev;
		private string faj;
		private int seb;
		private int suly;

		public SzarazMedi(string nev, string faj, int seb, int suly)
		{
			this.nev = "Chris Redfield";
			this.faj = "vaddisznó";
			this.seb = 50;
			this.suly = 90;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Faj { get => faj; set => faj = value; }
		public int Seb { get => seb; set => seb = value; }
		public int Suly { get => suly; set => suly = value; }
	}
}
