using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokClass
{
	internal class ViziAllat : IAllat
	{
		public string nev { get; set; }
        	public string faj { get; set; }
	        public int seb { get; set; }
        	public int suly { get; set; }

		public ViziAllat()
		{
			nev = "Ada Wong";
			faj = "delfin";
			seb = 60;
			suly = 175;
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
