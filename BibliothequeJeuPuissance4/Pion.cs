using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeJeuPuissance4
{
    public class Pion
    {
        private int N_Pion;
        private string couleur;
        public int NumP;
        public string PionC;
        public Pion(int n, string s)
        {
            NumP = n;
            PionC = s;
             
            if(PionC == "Rouge" || PionC=="Jaune" || PionC == "Noir" || PionC == "Blanc")
            {
                return;
            }
        }



    }
    public class Joueur : Pion
    {
        private int N_Joueur;
        private string PseudoJoueur;
        public Joueur(int nJ,string PionC, string s) : base(nJ,PionC)
        {
            N_Joueur = nJ;
            PseudoJoueur = s;
        }

        
    }

}
