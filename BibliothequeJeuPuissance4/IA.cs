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

            if (partie.GetJoueurActif() == N_joueurIA)
            {

                partie.JouerCoup(CoupAJouer, N_joueurIA);
            }
        }
        
        public List<(int, int)> MeilleurCoup(Partie partie)
        {
            List<int> CoupAjouer = new List<int>();
            List<(int, int)> LP = new List<(int, int)>();
            CoupAjouer = MinMax(partie, 3, 2);
            LP.Add((CoupAjouer[1], CoupAjouer[2]));
            JouerCoupIA(partie, LP);
            return LP;

            /*
            List<(int, int)> LCP = ListeCoupPossible(partie);
            int meilleurScore = int.MinValue;
            List<(int, int)> ListeMeilleurCoup = new List<(int, int)>();

            foreach ((int ligne, int colonne) in LCP)
            {
                int score = MinMax(partie, profondeurMax,LCP);
                if (score > meilleurScore)
                {
                    meilleurScore = score;
                    ListeMeilleurCoup.Clear();
                    ListeMeilleurCoup.Add((ligne, colonne));
                }
                else if (score == meilleurScore)
                {
                    ListeMeilleurCoup.Clear();
                    ListeMeilleurCoup.Add((ligne, colonne));
                }
            }

            return ListeMeilleurCoup;
            */
        }

        private List<int> MinMax(Partie noeud, int profondeur,int evalMax)
        {
            Partie f;
            List<(int, int)> LP = new List<(int, int)>();
            List<int> ListeRetour = new List<int>();
            List<int> Values = new List<int>();
            ListeRetour.Add(0);
            ListeRetour.Add(0);
            ListeRetour.Add(0);


            if (profondeur == 0 || noeud.EstTerminee() == -1)
            {
                ListeRetour[0]= Evaluer(noeud);
                return ListeRetour;
            }
            else
            {
                f=CopierPartie(noeud);
                if (evalMax == 2)
                {
                    LP = ListeCoupPossible(noeud);
                    for(int i=f.GetColonnes();i> 0; i--)
                    {
                        if (i > 1)
                        {
                         f.InitPionPlateau(LP[i-1].Item1, LP[i-1].Item2, 0);
                        }
                        f.InitPionPlateau(LP[i].Item1, LP[i].Item2,evalMax);
                        Values = MinMax(f, profondeur - 1, 1);
                        if (ListeRetour[0] < Values[0])
                        {
                            ListeRetour[1] = Values[1];
                            ListeRetour[1] = Values[2];
                        }
                    }
                    return ListeRetour;
                }
                else
                {
                    LP = ListeCoupPossible(noeud);
                    for (int i = f.GetColonnes(); i > 0; i--)
                    {
                        if (i > 1)
                        {
                            f.InitPionPlateau(LP[i - 1].Item1, LP[i - 1].Item2, 0);
                        }
                        f.InitPionPlateau(LP[i].Item1, LP[i].Item2,evalMax);
                        Values = MinMax(f, profondeur - 1, 2);
                        if (ListeRetour[0] < Values[0])
                        {
                            ListeRetour[1] = Values[1];
                            ListeRetour[1] = Values[2];
                        }
                    }
                    return ListeRetour;
                }
            }
            /*
            int meilleurScore = int.MinValue;
            

            foreach ((int ligne, int colonne) in LCP)
            {
                Partie copiePartie = CopierPartie(noeud);
                copiePartie.JouerCoup(new List<(int, int)> { (ligne, colonne) }, copiePartie.GetJoueurActif());
                int score = MinMax(copiePartie, profondeur - 1,LCP);
                meilleurScore = Math.Max(meilleurScore, score);
            }

            return meilleurScore;
            */
        }

        private List<(int, int)> ListeCoupPossible(Partie partie)
        {
            bool verif=false;
            int c, l;


            List<(int, int)> listeCoupsPossibles = new List<(int, int)>();
            /*
            for (int ligne = 0; ligne < partie.GetLignes(); ligne++)
            {
                for (int colonne = 0; colonne < partie.GetColonnes(); colonne++)
                {
                    if (partie.EstPossible(ligne, colonne))
                    {
                        if(colonne != 0)
                        {
                            if(!partie.EstPossible(ligne, colonne - 1))
                            {
                                listeCoupsPossibles.Add((ligne, colonne));
                                break;
                            }
                        }
                        else
                        {
                            listeCoupsPossibles.Add((ligne, colonne));
                            break;
                        }
                        
                    }
                }
            }*/
            for( c = 0; c < partie.GetColonnes(); c++)
            {
                verif = false;

                for ( l = partie.GetLignes(); l > 0; l--)
                {
                    if (!partie.EstPossible(l, c))
                    {
                        verif = true;
                        l ++;
                        break;
                    }
                }
                if (verif)
                {
                    listeCoupsPossibles.Add((l, c));
                }

            }

            return listeCoupsPossibles;
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

        private Partie CopierPartie(Partie partie)
        {
            int lignes = partie.GetLignes();
            int colonnes = partie.GetColonnes();
            Partie copiePartie = new Partie(lignes, colonnes,partie.GetJoueurActif());
            for (int ligne = 0; ligne < lignes; ligne++)
            {
                for (int colonne = 0; colonne < colonnes; colonne++)
                {
                    int pion = partie.GetPion(ligne, colonne);
                    copiePartie.JouerCoup(new List<(int, int)> { (ligne, colonne) }, pion);
                }
            }
            return copiePartie;
        }
    }
}
