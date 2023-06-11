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
        /// Valeur test avant d'initialiser le numéro du pion
        /// </summary>
        public int _N_Pion;
        /// <summary>
        /// Valeur test avant d'initialiser la couleur du pion
        /// </summary>
        public string _couleur;
        /// <summary>
        /// Renvoi le numéro du pion
        /// </summary>
        /// <returns></returns>
        public int GetN_Pion()
        {
            return N_Pion;
        }
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
            _N_Pion = nPion;
            _couleur = color;
            //Permet d'avoir des valeurs publiques pour vérifier leurs validité avant d'inserer les données dans les variables privées
            //Ici il n'y a encore aucune vérification pour l'instant
            N_Pion = _N_Pion;
            couleur = _couleur;
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
        /// Valeur test avant d'initialiser le numéro du joueur
        /// </summary>
        public int _N_Joueur;
        /// <summary>
        /// Valeur test avant d'initialiser le pseudo du joueur
        /// </summary>
        public string _PseudoJoueur;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nJ">Numéro Joueur et pion</param>
        /// <param name="PionC">Couleur pion</param>
        /// <param name="s">Nom joueur</param>
        public Joueur(int nJ, string PionC, string s) : base(nJ, PionC)
        {
            _N_Joueur = nJ;
            _PseudoJoueur = s;
            //Permet d'avoir des valeurs publiques pour vérifier leurs validité avant d'inserer les données dans les variables privées
            //Ici il n'y a encore aucune vérification pour l'instant
            N_Joueur = _N_Joueur;
            PseudoJoueur = _PseudoJoueur;
            
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

