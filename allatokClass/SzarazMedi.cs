using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokClass
{
	internal class SzarazMedi : IAllat
	{
		public string nev { get; set; }
        	public string faj { get; set; }
	        public int seb { get; set; }
        	public int suly { get; set; }

		public SzarazMedi()
		{
			nev = "Chris Redfield";
			faj = "vaddisznó";
			seb = 50;
			suly = 90;
		}

		public override string ToString()
		{
			return $"Az állat neve: {nev}, faja: {faj}, sebessége: {seb}, súlya: {suly}";
		}
	}
}
