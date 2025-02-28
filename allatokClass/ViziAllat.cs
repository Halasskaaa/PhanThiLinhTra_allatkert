using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokClass
{
	internal class ViziAllat
	{
		private string nev;
		private string faj;
		private int seb;
		private int suly;

		public ViziAllat(string nev, string faj, int seb, int suly)
		{
			this.nev = "Ada Wong";
			this.faj = "delfin";
			this.seb = 60;
			this.suly = 175;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Faj { get => faj; set => faj = value; }
		public int Seb { get => seb; set => seb = value; }
		public int Suly { get => suly; set => suly = value; }
	}
}
