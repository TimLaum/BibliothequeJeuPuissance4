using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeJeuPuissance4
{
    public class IA
    {
        private int profondeurMax;
        private int N_joueurIA;

        public IA(int profondeur, int joueur)
        {
            profondeurMax = profondeur;
            N_joueurIA = joueur;
        }

        public void JouerCoupIA(Partie partie, List<(int, int)> CoupAJouer)
        {
            if(partie.GetJoueurActif() == N_joueurIA)
            {
                partie.JouerCoup(CoupAJouer,N_joueurIA);
            }

        }
        

        public List<(int,int)> MeilleurCoup(Partie partie)
        {
            List<(int,int)> LCP = new List<(int,int)> ();  
            int meilleurCoupLigne = 0;
            int meilleurCoupColonne = 0;
            int meilleurScore = -1000;
            List<(int,int)> ListeMeilleurCoup = new List<(int,int)> (); 
            
            LCP = ListeCoupPossible(partie);

            foreach ((int ligne, int colonne) in LCP)
            {
                    int score = MinMax(partie, profondeurMax);

                    if (score > meilleurScore)
                    {
                        meilleurScore = score;
                        meilleurCoupLigne = ligne;
                        meilleurCoupColonne = colonne;
                    }
            }
            ListeMeilleurCoup.Add((meilleurCoupLigne, meilleurCoupColonne));

            return ListeMeilleurCoup;
        }

        public List<(int,int)> ListeCoupPossible(Partie partie)
        {
            int ligne = 0;
            int colonne;
            List<(int,int)> listeCoupsPossibles = new List<(int, int)>() ;
            while(ligne < partie.GetLignes())
            {
                colonne = 0;
                while(colonne < partie.GetColonnes())
                {
                    if (partie.EstPossible(ligne,colonne))
                    {
                        listeCoupsPossibles.Add((ligne, colonne));
                    }
                    colonne++;
                }
                ligne++;
            }
            return listeCoupsPossibles;
        }

        private int MinMax(Partie partie, int profondeur)
        {
            List<(int,int)> LCP = new List<(int, int)> ();
            if (profondeur == 0 || partie.EstTerminee() != -1)
            {
                return Evaluer(partie);
            }
                int meilleurScore = int.MinValue;
                LCP = ListeCoupPossible(partie); 
                foreach((int ligne,int colonne)in LCP)
                {
                        int score = MinMax(partie, profondeur - 1);
                        meilleurScore = Math.Max(meilleurScore, score);
                }
                return meilleurScore;
        }

        private int Evaluer(Partie partie)
        {
            int score = 0;

            
            for (int ligne = 0; ligne < partie.GetLignes(); ligne++)
            {
                for (int colonne = 0; colonne < partie.GetColonnes() - 3; colonne++)
                {
                    int pion1 = partie.GetPion(ligne, colonne);
                    int pion2 = partie.GetPion(ligne, colonne + 1);
                    int pion3 = partie.GetPion(ligne, colonne + 2);
                    int pion4 = partie.GetPion(ligne, colonne + 3);

                    score += EvaluerSequencePions(pion1, pion2, pion3, pion4);
                }
            }

           
            for (int ligne = 0; ligne < partie.GetLignes() - 3; ligne++)
            {
                for (int colonne = 0; colonne < partie.GetColonnes(); colonne++)
                {
                    int pion1 = partie.GetPion(ligne, colonne);
                    int pion2 = partie.GetPion(ligne + 1, colonne);
                    int pion3 = partie.GetPion(ligne + 2, colonne);
                    int pion4 = partie.GetPion(ligne + 3, colonne);
                    
                    score += EvaluerSequencePions(pion1, pion2, pion3, pion4);
                }
            }

            
            for (int ligne = 0; ligne < partie.GetLignes() - 3; ligne++)
            {
                for (int colonne = 0; colonne < partie.GetColonnes() - 3; colonne++)
                {
                    int pion1 = partie.GetPion(ligne, colonne);
                    int pion2 = partie.GetPion(ligne + 1, colonne + 1);
                    int pion3 = partie.GetPion(ligne + 2, colonne + 2);
                    int pion4 = partie.GetPion(ligne + 3, colonne + 3);

                    score += EvaluerSequencePions(pion1, pion2, pion3, pion4);
                }
            }

            
            for (int ligne = 3; ligne < partie.GetLignes(); ligne++)
            {
                for (int colonne = 0; colonne < partie.GetColonnes() - 3; colonne++)
                {
                    int pion1 = partie.GetPion(ligne, colonne);
                    int pion2 = partie.GetPion(ligne - 1, colonne + 1);
                    int pion3 = partie.GetPion(ligne - 2, colonne + 2);
                    int pion4 = partie.GetPion(ligne - 3, colonne + 3);

                    score += EvaluerSequencePions(pion1, pion2, pion3, pion4);
                }
            }

            return score;
        }

        private int EvaluerSequencePions(int pion1, int pion2, int pion3, int pion4)
        {
            int score = 0;

            if (pion1 == 2 && pion2 == 2 && pion3 == 2 && pion4 == 2)
            { 
                score += 100;
            }
            

            else if (pion1 == 1 && pion2 == 1 && pion3 == 1 && pion4 == 1)
            {
                score -= 100;
            }
            

            else if ((pion1 == 2 || pion1 == 0) && (pion2 == 2 || pion2 == 0) &&
                     (pion3 == 2 || pion3 == 0) && (pion4 == 2 || pion4 == 0))
            {
                score += 10;
            }

            return score;
        }

    }
}
