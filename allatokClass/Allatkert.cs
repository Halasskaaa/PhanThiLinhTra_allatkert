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
		
		static List<int> ListSeb()
		{
			ViziAllat delfin = new();
			SzarazHideg jszarvas = new();
			SzarazMedi vaddiszno = new();
			SzarazMeleg strucc = new();
			SzarazTropusi jaguar = new();
			
			List<int> sebLista = new List<int>() { delfin.Seb, jszarvas.Seb, vaddiszno.Seb, strucc.Seb, jaguar.Seb  };

            return sebLista;
		}
		static List<string> ListFaj()
		{
			ViziAllat delfin = new();
			SzarazHideg jszarvas = new();
			SzarazMedi vaddiszno = new();
			SzarazMeleg strucc = new();
			SzarazTropusi jaguar = new();

			List<string> fajLista = new List<string>() { delfin.Faj, jszarvas.Faj, vaddiszno.Faj, strucc.Faj, jaguar.Faj };

			return fajLista;
		}
		static List<string> ListNev()
		{
			ViziAllat delfin = new();
			SzarazHideg jszarvas = new();
			SzarazMedi vaddiszno = new();
			SzarazMeleg strucc = new();
			SzarazTropusi jaguar = new();

			List<string> nevLista = new List<string>() { delfin.Nev, jszarvas.Nev, vaddiszno.Nev, strucc.Nev, jaguar.Nev };

			return nevLista;
		}





	}
}
