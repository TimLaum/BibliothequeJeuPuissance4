using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;
using BibliothequeJeuPuissance4;

namespace Test_BibliothequeJeuPuissance4
{
    [TestClass]
    public class PartieEstPossible
    {
        [TestMethod]
         public void EstPossible_Taille_6_7_en_5_6_true()
        {
            // Schéma AAA
            // Arrange
            int Ligne = 6, Colonne =7,Joueur_Actif=1;
            Partie P = new Partie(Ligne,Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            int x=5, y=6;
            // Act
            bool resultat = P.EstPossible(x,y);
            // Assert
            Assert.AreEqual(true, resultat);

        }
        /*
        [TestMethod]
        public void EstPossible_Taille_8_8_en_5_6_true()
        {
            // Schéma AAA
            // Arrange
            int Ligne = 8, Colonne = 8, Joueur_Actif = 1;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            int x = 7, y = 0;
            for(int i = 0; i < Colonne; i++)
            {
                if (i % 2 == 0)
                {
                }
            }
            // Act
            bool resultat = P.EstPossible(x, y);
            // Assert
            Assert.AreEqual(true, resultat);

        }

        [TestMethod]
        public void EstPossible_Taille_6_7_en_0_0_true()
        {
            // Schéma AAA
            // Arrange
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            int x = 5, y = 6;
            // Act
            bool resultat = P.EstPossible(x, y);
            // Assert
            Assert.AreEqual(true, resultat);

        }
        */
    }
}