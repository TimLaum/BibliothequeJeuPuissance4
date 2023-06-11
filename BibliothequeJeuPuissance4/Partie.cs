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
        /// <summary>
        /// Le nombre de ligne du plateau en lecture uniquement
        /// </summary>
		private int lignes {get;}
        /// <summary>
        /// Le nombre de colonne du plateau en lecture uniquement
        /// </summary>
        private int colonnes {get;}
        /// <summary>
        /// Le plateau de jeu
        /// </summary>
		private int[,] plateau { get; set; }
        /// <summary>
        /// Le numéro du joueur actif
        /// </summary>
        private int JoueurActif { get; set; }
        /// <summary>
        /// Initialisation  du plateau
        /// </summary>
		public void InitPlateau()
		{
			plateau = new int[lignes, colonnes];
            GenererPlateau();
		}
        /// <summary>
        /// Renvoi du joueur actif
        /// </summary>
        /// <returns></returns>
        public int GetJoueurActif()
        {
            return JoueurActif;
        }
        /// <summary>
        /// Place le pion du joueur actuel à l'indice donné
        /// </summary>
        /// <param name="CoupAJouer">L'indice où il faut jouer le pion</param>
        /// <param name="N_Joueur">Numéro Joueur</param>
        public void JouerCoup(List<(int, int)> CoupAJouer,int N_Joueur)
        {
            if (EstPossible(CoupAJouer[0].Item1, CoupAJouer[0].Item2))
            {
                //var (ligne, colonne) = CoupAJouer[0];
                plateau[CoupAJouer[0].Item1, CoupAJouer[0].Item2] = N_Joueur;
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
        /// <summary>
        /// Rempli le plateau de 0
        /// </summary>
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
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="l">nombre ligne du plateau</param>
        /// <param name="c">nombre colonne du plateau</param>
        /// <param name="JA">Joueur actif</param>
		public Partie(int l,int c,int JA) 
		{
			lignes = l;
			colonnes = c;
			JoueurActif = JA;
			InitPlateau();
		}

		/// <summary>
        /// Renvoi le nombre de ligne
        /// </summary>
        /// <returns></returns>
		public int GetLignes()
		{
			return lignes;
		}
        /// <summary>
        /// Renvoi le nombre de colonne
        /// </summary>
        /// <returns></returns>
		public int GetColonnes()
		{
			return colonnes;
		}
        /// <summary>
        /// Renvoi la valeur de la zone d'un pion avec un indice x,y
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
		public int GetPion(int l,int c)
		{
			return plateau[l,c];
		}
        /// <summary>
        /// Vérifie qu'un coup  est possible 
        /// </summary>
        /// <param name="ligne">Indice x du coup</param>
        /// <param name="colonne">Indice y du coup</param>
        /// <returns></returns>
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

        public void InitPionPlateau(int Ligne, int Colonne, int N_Joueur)
        {
            plateau[Ligne, Colonne] = N_Joueur;
        }


        /// <summary>
        /// Verifie si la partie est terminé et par quelle joueur
        /// </summary>
        /// <returns></returns>
		public int EstTerminee()
		{
            for (int ligne = 0; ligne < lignes; ligne++)//vérifie les lignes
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


            for (int ligne = 0; ligne < lignes - 3; ligne++)//vérifie les colonnes
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


            for (int ligne = 0; ligne < lignes - 3; ligne++)//vérifie les diagonales droite gauche
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


            for (int ligne = 3; ligne < lignes; ligne++)//vérifie les diagonales gauche droite
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
        /// <summary>
        /// Vérifie si le plateau est plein
        /// </summary>
        /// <returns></returns>
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
