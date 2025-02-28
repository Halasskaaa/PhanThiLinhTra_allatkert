using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokClass
{
	internal class SzarazHideg
	{
		private string nev;
		private string faj;
		private int seb;
		private int suly;

		public SzarazHideg()
		{
			nev = "Carlos Oliveira";
			faj = "jávorszarvas";
			seb = 56;
			suly = 500;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Faj { get => faj; set => faj = value; }
		public int Seb { get => seb; set => seb = value; }
		public int Suly { get => suly; set => suly = value; }
		public override string ToString()
		{
			return $"Az állat neve: {nev}, faja: {faj}, sebessége: {seb}, súlya: {suly}";
		}
	}
}
