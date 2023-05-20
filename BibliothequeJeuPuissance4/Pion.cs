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
        private int N_Pion { get;}
        private string couleur { get;}
        public int _N_Pion;
        public string _couleur;
        public int GetN_Pion()
        {
            return N_Pion;
        }

        public string GetCouleur()
        {
            return couleur;
        }

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


    public class Joueur : Pion
    {
        private int N_Joueur { get; } //Get pour dire qu'il est en lecture uniquement, a part lors de la construction, N_Joueur ne peut pas
        //Voir sa valeur changer
        private string PseudoJoueur { get;} 
        public int _N_Joueur;
        public string _PseudoJoueur;

        public Joueur(int nJ, string PionC, string s) : base(nJ, PionC)
        {
            _N_Joueur = nJ;
            _PseudoJoueur = s;
            //Permet d'avoir des valeurs publiques pour vérifier leurs validité avant d'inserer les données dans les variables privées
            //Ici il n'y a encore aucune vérification pour l'instant
            N_Joueur = _N_Joueur;
            PseudoJoueur = _PseudoJoueur;
        }

        public int GetN_Joueur()
        {
            return N_Joueur;
        }

        public string GetPseudoJoueur()
        {
            return PseudoJoueur;
        }
    }

}

