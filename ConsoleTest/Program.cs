using System;
using BibliothequeJeuPuissance4;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur j = new Joueur(2,"Rouge","Tim");
            Console.WriteLine(j.GetN_Joueur());
            Joueur joueur = new Joueur(1,"Bleu", "Alice");
            Console.WriteLine(joueur.GetCouleur());
            Partie p = new Partie(2,3,1);
            
            p.GetTaillePlateau();

        }
    }
}
