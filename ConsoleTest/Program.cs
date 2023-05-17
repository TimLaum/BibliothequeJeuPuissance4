using System;
using BibliothequeJeuPuissance4;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur j = new Joueur(2,"Rouge","Tim");
            Console.WriteLine(j.couleur);
        }
    }
}
