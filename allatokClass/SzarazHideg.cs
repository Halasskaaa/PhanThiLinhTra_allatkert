using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokClass
{
	internal class SzarazHideg : IAllat
	{
		public string nev { get; set; }
        	public string faj { get; set; }
	        public int seb { get; set; }
        	public int suly { get; set; }

		public SzarazHideg()
		{
			nev = "Carlos Oliveira";
			faj = "jávorszarvas";
			seb = 56;
			suly = 500;
		}
  
		public override string ToString()
		{
			return $"Az állat neve: {nev}, faja: {faj}, sebessége: {seb}, súlya: {suly}";
		}
	}
}
