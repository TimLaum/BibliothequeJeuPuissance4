using BibliothequeJeuPuissance4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeJeuPuissance4
{
    public class Pion
    {
        /// <summary>
        /// Numéro du pion en lecture uniquement
        /// </summary>
        private int N_Pion { get;}

        /// <summary>
        /// Couleur du pionen lecture uniquement
        /// </summary>
        private string couleur { get;}

        /// <summary>
        /// Renvoi la couleur du pion
        /// </summary>
        /// <returns></returns>
        public string GetCouleur()
        {
            return couleur;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nPion">Le numéro du pion</param>
        /// <param name="color">La couleur du pion</param>
        public Pion(int nPion, string color)
        {
            N_Pion = nPion;
            couleur = color;

        }
    }


    public class Joueur : Pion//Fille de pion
    {
        /// <summary>
        /// Numéro Joueur en lecture uniquement
        /// </summary>
        private int N_Joueur { get; } //Get pour dire qu'il est en lecture uniquement, a part lors de la construction, N_Joueur ne peut pas
                                      //Voir sa valeur changer

        /// <summary>
        /// Pseudo Joueur en lecture uniquement
        /// </summary>
        private string PseudoJoueur { get;}

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nJ">Numéro Joueur et pion</param>
        /// <param name="PionC">Couleur pion</param>
        /// <param name="s">Nom joueur</param>
        public Joueur(int nJ, string PionC, string s) : base(nJ, PionC)
        {
            N_Joueur = nJ;
            PseudoJoueur = s;
            
        }

        /// <summary>
        /// Renvoi le numéro joueur
        /// </summary>
        /// <returns></returns>
        public int GetN_Joueur()
        {
            return N_Joueur;
        }

        /// <summary>
        /// Renvoi le pseudo joueur
        /// </summary>
        /// <returns></returns>
        public string GetPseudoJoueur()
        {
            return PseudoJoueur;
        }
    }

}

