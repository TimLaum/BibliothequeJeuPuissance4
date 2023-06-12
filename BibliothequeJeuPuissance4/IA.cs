using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeJeuPuissance4
{
    public class IA
    {
        /// <summary>
        /// Profondeur maximale où l'IA descend
        /// </summary>
        private int profondeurMax;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="profondeur">Profondeur maximale où l'IA descend</param>
        /// <param name="joueur"></param>
        public IA(int profondeur)
        {
            profondeurMax = profondeur;
        }

        /// <summary>
        /// Joue le coup que l'IA à trouvé
        /// </summary>
        /// <param name="partie">Classe partie</param>
        /// <param name="CoupAJouer">Le Coup que l'IA doit jouer</param>
        public void JouerCoupIA(Partie partie, List<(int, int)> CoupAJouer)
        {

            if (partie.GetJoueurActif() == 2)
            {

                partie.JouerCoup(CoupAJouer, 2);
            }
        }
        /// <summary>
        /// Trouve le meilleur coup possible en appelant la méthode MinMax et le renvoi
        /// </summary>
        /// <param name="partie">Classe partie,qui est en cours</param>
        /// <returns></returns>
        public List<(int, int)> MeilleurCoup(Partie partie)
        {
            List<int> CoupAjouer = new List<int>();
            List<(int, int)> LP = new List<(int, int)>();
            CoupAjouer = MinMax(partie, profondeurMax, 2);
            LP.Add((CoupAjouer[1], CoupAjouer[2]));
            return LP;
        }
        /// <summary>
        /// Méthode récursive qui renvoi le score d'un coup et la position x,y du coup 
        /// </summary>
        /// <param name="noeud">Classe partie</param>
        /// <param name="profondeur">Profondeur actuelle</param>
        /// <param name="evalMax">Le numéro du joeur actif</param>
        /// <returns></returns>
        private List<int> MinMax(Partie noeud, int profondeur,int evalMax)
        {
            Partie f;//partie fils de noeud
            List<(int, int)> LP = new List<(int, int)>();//Une liste de tuples des indices  des coups possible 
            List<int> ListeRetour = new List<int>();//C'est l'élément renvoyer;Element du premier indice :score de la situation;Element du deuxième indice :indice x du meilleur coupactuel;indice y du meilleur coupactuel
            List<int> Values = new List<int>();//Element du premier indice :score de la situation;Element du deuxième indice :indice x du meilleur coupactuel;indice y du meilleur coupactuel
            LP = ListeCoupPossible(noeud);
            ListeRetour.Add(0);
            if (LP.Count > 0)
            {
                ListeRetour.Add(LP[0].Item1);
                ListeRetour.Add(LP[0].Item2);
            }
            if (profondeur == 0 || noeud.EstTerminee() != -1)
            {

                ListeRetour[0]=(Evaluer(noeud));

                return ListeRetour;
            }
            else
            {
                f=CopierPartie(noeud);
                
                if (evalMax == 2)
                {
                    ListeRetour[0] = -1000;
                    for (int i=0;i< LP.Count; i++)
                    {
                        if (i >= 1)
                        {
                         f.InitPionPlateau(LP[i-1].Item1, LP[i-1].Item2, 0);
                        }

                        f.InitPionPlateau(LP[i].Item1, LP[i].Item2,evalMax);
                        Values = MinMax(f, profondeur - 1, 1);

                        if (ListeRetour[0] <= Values[0])
                        {
                            ListeRetour[0]= Values[0];
                            ListeRetour[1] = LP[i].Item1;
                            ListeRetour[2] = LP[i].Item2;
                        }
                    }
                    return ListeRetour;
                }
                else
                {
                    ListeRetour[0] = 1000;
                    for (int i = 0; i < LP.Count; i++)
                    {
                        if (i >= 1)
                        {
                            f.InitPionPlateau(LP[i - 1].Item1, LP[i - 1].Item2, 0);
                        }
                        f.InitPionPlateau(LP[i].Item1, LP[i].Item2,evalMax);
                        Values = MinMax(f, profondeur - 1, 2);
                        if (ListeRetour[0] >= Values[0])
                        {
                            ListeRetour[0] = Values[0];
                            ListeRetour[1] = LP[i].Item1;
                            ListeRetour[2] = LP[i].Item2;
                        }
                    }
                    return ListeRetour;
                }
            }
        }

        /// <summary>
        /// Liste des coup possible sur un plateau de la classe partie
        /// </summary>
        /// <param name="partie">Classe partie à évaluer</param>
        /// <returns></returns>
        public List<(int, int)> ListeCoupPossible(Partie partie)
        {
            bool verif=false;
            int c, l;


            List<(int, int)> listeCoupsPossibles = new List<(int, int)>();

            for( c = 0; c < partie.GetColonnes(); c++)
            {
                verif = false;

                for ( l = partie.GetLignes()-1; l >= 0; l--)
                {
                    if (partie.EstPossible(l, c))
                    {
                        verif = true;
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

        /// <summary>
        /// Evalue la situation sur un plateau de la classe partie pour le Joueur Numéro 2 et renvoye le score de cette situation
        /// </summary>
        /// <param name="partie">Classe partie à evaluer</param>
        /// <returns></returns>
        public int Evaluer(Partie partie)
        {
            int scoreActuel = 0;
            int scoreTemporaire =0;



            for (int ligne = 0; ligne < partie.GetLignes() - 3; ligne++)//Vérifie les colonnes
            {
                for (int colonne = 0; colonne < partie.GetColonnes(); colonne++)
                {
                    int pion1 = partie.GetPion(ligne, colonne);
                    int pion2 = partie.GetPion(ligne + 1, colonne);
                    int pion3 = partie.GetPion(ligne + 2, colonne);
                    int pion4 = partie.GetPion(ligne + 3, colonne);

                    scoreTemporaire = EvaluerSequencePions(pion1, pion2, pion3, pion4);

                        scoreActuel += scoreTemporaire;
                    
  
                }
            }

            for (int ligne = 0; ligne < partie.GetLignes(); ligne++)//Vérifie les lignes
            {
                for (int colonne = 0; colonne < partie.GetColonnes() - 3; colonne++)
                {
                    int pion1 = partie.GetPion(ligne, colonne);
                    int pion2 = partie.GetPion(ligne, colonne + 1);
                    int pion3 = partie.GetPion(ligne, colonne + 2);
                    int pion4 = partie.GetPion(ligne, colonne + 3);
                    scoreTemporaire = EvaluerSequencePions(pion1, pion2, pion3, pion4);

                       
                        scoreActuel += scoreTemporaire;
                        


                }
            }

            for (int ligne = 0; ligne < partie.GetLignes() - 3; ligne++)//Vérifie les diagonale gauche droite
            {
                for (int colonne = 0; colonne < partie.GetColonnes() - 3; colonne++)
                {
                    int pion1 = partie.GetPion(ligne, colonne);
                    int pion2 = partie.GetPion(ligne + 1, colonne + 1);
                    int pion3 = partie.GetPion(ligne + 2, colonne + 2);
                    int pion4 = partie.GetPion(ligne + 3, colonne + 3);

                    scoreTemporaire = EvaluerSequencePions(pion1, pion2, pion3, pion4);

                        scoreActuel += scoreTemporaire;

                }
            }

            for (int ligne = 3; ligne < partie.GetLignes(); ligne++)//Vérifie les diagonale droite gauche
            {
                for (int colonne = 0; colonne < partie.GetColonnes() - 3; colonne++)
                {
                    int pion1 = partie.GetPion(ligne, colonne);
                    int pion2 = partie.GetPion(ligne - 1, colonne + 1);
                    int pion3 = partie.GetPion(ligne - 2, colonne + 2);
                    int pion4 = partie.GetPion(ligne - 3, colonne + 3);

                    scoreTemporaire = EvaluerSequencePions(pion1, pion2, pion3, pion4);

                        
                        scoreActuel += scoreTemporaire;
                        
                    

                }
            }

            return scoreActuel;
        }
        /// <summary>
        /// Evalue la situation de 4 zone  pions aligner sur un plateau de la classe partie  pour le Joueur Numéro 2 et renvoye le score de cette situation
        /// </summary>
        /// <param name="pion1">Le pion numéro 1</param>
        /// <param name="pion2">Le pion numéro 1</param>
        /// <param name="pion3">Le pion numéro 1</param>
        /// <param name="pion4">Le pion numéro 1</param>
        /// <returns></returns>
        private int EvaluerSequencePions(int pion1, int pion2, int pion3, int pion4)
        {
            int score = 0;


            if (pion1 == 2 && pion2 == 2 && pion3 == 2 && pion4 == 2)
            {
                score += 200;
            }
            else
            {
                if(pion1 == 0 && pion2 == 2 && pion3 == 2 && pion4 == 2){
                    score += 60;
                }
                else
                {
                    if (pion1 == 0 && pion2 == 0 && pion3 == 2 && pion4 == 2)
                    {
                        score += 30;
                    }
                    else
                    {
                        if (pion1 == 0 && pion2 == 0 && pion3 == 0 && pion4 == 2)
                        {
                            score += 10;
                        }
                    }
                }


            }

            if ((pion1 == 1 && pion2 == 1 && pion3 == 1 && pion4 == 1))
            {
                score -= 100;
            }
            else
            {
                if (pion1 == 0 && pion2 == 1 && pion3 == 1 && pion4 == 1)
                {
                    score -= 60;
                }
                else
                {
                    if (pion1 == 0 && pion2 == 0 && pion3 == 1 && pion4 == 1)
                    {
                        score -= 30;
                    }
                    else
                    {
                        if (pion1 == 0 && pion2 == 0 && pion3 == 0 && pion4 == 1)
                        {
                            score -= 10;
                        }

                    }
                }

            }

            return score;
        }
        /// <summary>
        /// Copie une classe partie et renvoye cette copie
        /// </summary>
        /// <param name="partie">Classe partie à copier</param>
        /// <returns></returns>
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
