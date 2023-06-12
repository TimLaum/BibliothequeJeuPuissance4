using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;
using BibliothequeJeuPuissance4;

namespace Test_BibliothequeJeuPuissance4
{
    [TestClass]
    public class PartieEstPossible
    {
        [TestMethod]
        public void EstTerminee_Taille_6_7_colonne3_1()
        {
            // Schéma AAA
            // Arrange
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            P.InitPionPlateau(5, 2, 1);
            P.InitPionPlateau(4, 2, 1);
            P.InitPionPlateau(3, 2, 1);
            P.InitPionPlateau(2, 2, 1);
            P.InitPionPlateau(5, 0, 2);
            P.InitPionPlateau(5, 1, 2);
            P.InitPionPlateau(4, 0, 2);
            // Act
            res = P.EstTerminee();
            // Assert
            Assert.AreEqual(1, res);

        }

        [TestMethod]
        public void EstTerminee_Taille_6_7_Plein_0()
        {
            // Schéma AAA
            // Arrange
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            P.InitPionPlateau(5, 0, 1);
            P.InitPionPlateau(5, 1, 1);
            P.InitPionPlateau(5, 2, 1);
            P.InitPionPlateau(5, 3, 2);
            P.InitPionPlateau(5, 4, 1);
            P.InitPionPlateau(5, 5, 1);
            P.InitPionPlateau(5, 6, 1);

            P.InitPionPlateau(4, 0, 2);
            P.InitPionPlateau(4, 1, 2);
            P.InitPionPlateau(4, 2, 2);
            P.InitPionPlateau(4, 3, 1);
            P.InitPionPlateau(4, 4, 2);
            P.InitPionPlateau(4, 5, 2);
            P.InitPionPlateau(4, 6, 2);

            P.InitPionPlateau(3, 0, 1);
            P.InitPionPlateau(3, 1, 1);
            P.InitPionPlateau(3, 2, 1);
            P.InitPionPlateau(3, 3, 2);
            P.InitPionPlateau(3, 4, 1);
            P.InitPionPlateau(3, 5, 1);
            P.InitPionPlateau(3, 6, 1);

            P.InitPionPlateau(2, 0, 2);
            P.InitPionPlateau(2, 1, 2);
            P.InitPionPlateau(2, 2, 2);
            P.InitPionPlateau(2, 3, 1);
            P.InitPionPlateau(2, 4, 2);
            P.InitPionPlateau(2, 5, 2);
            P.InitPionPlateau(2, 6, 2);

            P.InitPionPlateau(1, 0, 1);
            P.InitPionPlateau(1, 1, 1);
            P.InitPionPlateau(1, 2, 1);
            P.InitPionPlateau(1, 3, 2);
            P.InitPionPlateau(1, 4, 1);
            P.InitPionPlateau(1, 5, 1);
            P.InitPionPlateau(1, 6, 2);

            P.InitPionPlateau(0, 0, 2);
            P.InitPionPlateau(0, 1, 2);
            P.InitPionPlateau(0, 2, 2);
            P.InitPionPlateau(0, 3, 1);
            P.InitPionPlateau(0, 4, 1);
            P.InitPionPlateau(0, 5, 2);
            P.InitPionPlateau(0, 6, 2);

            // Act
            res = P.EstTerminee();
            // Assert
            Assert.AreEqual(0, res);

        }
        [TestMethod]
        public void EstTerminee_Taille_8_8_PasFini_Moins_1()
        {
            // Schéma AAA
            // Arrange
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            P.InitPionPlateau(5, 2, 1);
            P.InitPionPlateau(4, 2, 1);
            P.InitPionPlateau(3, 2, 1);
            P.InitPionPlateau(5, 0, 2);
            P.InitPionPlateau(5, 1, 2);
            P.InitPionPlateau(4, 0, 2);
            // Act
            res = P.EstTerminee();
            // Assert
            Assert.AreEqual(-1, res);

        }

        [TestMethod]
        public void EstTerminee_Taille_9_9_Diagonale_1()
        {
            // Schéma AAA
            // Arrange
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            P.InitPionPlateau(5, 6, 1);
            P.InitPionPlateau(5, 5, 2);
            P.InitPionPlateau(4, 5, 1);
            P.InitPionPlateau(5, 4, 2);
            P.InitPionPlateau(4, 4, 1);
            P.InitPionPlateau(5, 3, 2);
            P.InitPionPlateau(3, 4, 1);
            P.InitPionPlateau(4, 3, 2);
            P.InitPionPlateau(2, 3, 1);
            P.InitPionPlateau(4, 6, 2);
            P.InitPionPlateau(2, 4, 1);
            // Act
            res = P.EstTerminee();
            // Assert
            Assert.AreEqual(1, res);

        }
    }
}