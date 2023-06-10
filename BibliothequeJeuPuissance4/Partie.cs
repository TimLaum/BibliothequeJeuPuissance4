using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BibliothequeJeuPuissance4
{
	 public class Partie
	{
		private int lignes {get;}
		private int colonnes {get;}
		private int[,] plateau { get; set; }
        private int JoueurActif { get; set; }

		public void InitPlateau()
		{
			plateau = new int[lignes, colonnes];
            GenererPlateau();
		}

        public int GetJoueurActif()
        {
            return JoueurActif;
        }

        public void JouerCoup(List<(int, int)> CoupAJouer,int N_Joueur)
        {
            if (EstPossible(CoupAJouer[0].Item1, CoupAJouer[0].Item2))
            {
                var (ligne, colonne) = CoupAJouer[0];
                plateau[ligne,colonne] = N_Joueur;
                if (JoueurActif == 2)
                {
                    JoueurActif = 1;
                }
                else
                {
                    JoueurActif = 2;
                }
            }
        }


        public void GenererPlateau()
        {
            for(int i = 0; i < lignes; i++)
            {
                for(int j = 0; j < colonnes; j++)
                {
                    plateau[i, j] = 0;
                }
            }
        }
		public Partie(int l,int c,int JA) 
		{
			lignes = l;
			colonnes = c;
			JoueurActif = JA;
			InitPlateau();
		}

		
		public int GetLignes()
		{
			return lignes;
		}

		public int GetColonnes()
		{
			return colonnes;
		}

		public int GetPion(int l,int c)
		{
			return plateau[l,c];
		}

         public bool EstPossible(int ligne,int colonne)
        {
            if (plateau[ligne,colonne] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		public int EstTerminee()
		{
            for (int ligne = 0; ligne < lignes; ligne++)
            {
                for (int colonne = 0; colonne < colonnes - 3; colonne++)
                {
                    if ((plateau[ligne, colonne] == 1 && plateau[ligne, colonne+1] == 1 && plateau[ligne, colonne+2] == 1 && plateau[ligne, colonne+3] == 1 ))
                    {
                        return 1;
                    }
                    else if((plateau[ligne, colonne] == 2 && plateau[ligne, colonne + 1] == 2 && plateau[ligne, colonne + 2] == 2 && plateau[ligne, colonne + 3] == 2))
                    {
                        return 2;
                    }               
                }
            }


            for (int ligne = 0; ligne < lignes - 3; ligne++)
            {
                for (int colonne = 0; colonne < colonnes; colonne++)
                {
                    if ((plateau[ligne, colonne] == 1 && plateau[ligne + 1, colonne] == 1 && plateau[ligne + 2, colonne] == 1 && plateau[ligne + 3, colonne ] == 1))
                    {
                        return 1;
                    }
                    else if ((plateau[ligne, colonne] == 2 && plateau[ligne + 1 , colonne] == 2 && plateau[ligne + 2, colonne] == 2 && plateau[ligne + 3, colonne] == 2))
                    {
                        return 2;
                    }

                }
            }


            for (int ligne = 0; ligne < lignes - 3; ligne++)
            {
                for (int colonne = 0; colonne < colonnes - 3; colonne++)
                {

                    if ((plateau[ligne, colonne] == 1 && plateau[ligne + 1, colonne + 1] == 1 && plateau[ligne + 2, colonne + 2] == 1 && plateau[ligne + 3, colonne + 3] == 1))
                    {
                        return 1;
                    }
                    else if ((plateau[ligne, colonne] == 2 && plateau[ligne + 1, colonne + 1] == 2 && plateau[ligne + 2, colonne + 2] == 2 && plateau[ligne + 3, colonne + 3] == 2))
                    {
                        return 2;
                    }
                }
            }


            for (int ligne = 3; ligne < lignes; ligne++)
            {
                for (int colonne = 0; colonne < colonnes - 3; colonne++)
                {
                    if ((plateau[ligne, colonne] == 1 && plateau[ligne - 1, colonne + 1] == 1 && plateau[ligne - 2, colonne + 2] == 1 && plateau[ligne - 3, colonne + 3] == 1))
                    {
                        return 1;
                    }
                    else if ((plateau[ligne, colonne] == 2 && plateau[ligne - 1, colonne + 1] == 2 && plateau[ligne - 2, colonne + 2] == 2 && plateau[ligne - 3, colonne + 3] == 2))
                    {
                        return 2;
                    }
                }
            }

            if (EstPlein())
            {
                return 0;
            }
            return -1;
        }
        public bool EstPlein()
        {
            for(int ligne = 0; ligne < lignes;ligne++)
            {
                for(int colonne =0; colonne < colonnes;colonne++)
                {
                    if (plateau[ligne,colonne] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
