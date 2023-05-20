using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeJeuPuissance4
{
	public class Partie
	{
		private int lignes {get;}
		private int colonnes {get;}
		private int[,] plateau { get; set; }
        private bool JoueurActif { get; }

		public void InitPlateau()
		{
			plateau = new int[lignes, colonnes];
		}
		public Partie(int l,int c,bool JA) 
		{
			lignes = l;
			colonnes = c;
			JoueurActif = JA;
			InitPlateau();
		}

		public void GetTaillePlateau()
		{
            Console.WriteLine(Convert.ToString(plateau.GetLength(0))); 
            Console.WriteLine(Convert.ToString(plateau.GetLength(1)));
        }

    }
}
