using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;
using BibliothequeJeuPuissance4;

namespace Test_BibliothequeJeuPuissance4
{
    [TestClass]
    public class PartieEstTermine
    {
        [TestMethod]
        public void EstTerminee_Taille_6_7_colonne3_1()
        {
            // Schéma AAA
            // Arrange
            List<(int, int)> Coups = new List<(int, int)>();
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            Coups.Add((5, 2));
            P.JouerCoup(Coups, 1);
            Coups[0] = (4, 2);
            P.JouerCoup(Coups, 1);
            Coups[0] = (3, 2);
            P.JouerCoup(Coups, 1);
            Coups[0] = (2, 2);
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 0);
            P.JouerCoup(Coups, 2);
            Coups[0] = (5, 1);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 0);
            P.JouerCoup(Coups, 2);
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
            List<(int, int)> Coups = new List<(int, int)>();
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            Coups.Add((5, 0));
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 1);
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 2);
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 3);
            P.JouerCoup(Coups, 2);
            Coups[0] = (5, 4);
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 5);
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 6);
            P.JouerCoup(Coups, 1);

            Coups[0] = (4, 0);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 1);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 2);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 3);
            P.JouerCoup(Coups, 1);
            Coups[0] = (4, 4);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 5);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 6);
            P.JouerCoup(Coups, 2);

            Coups[0] = (3, 0);
            P.JouerCoup(Coups, 1);
            Coups[0] = (3,1);
            P.JouerCoup(Coups, 1);
            Coups[0] = (3, 2);
            P.JouerCoup(Coups, 1);
            Coups[0] = (3, 3);
            P.JouerCoup(Coups, 2);
            Coups[0] = (3, 4);
            P.JouerCoup(Coups, 1);
            Coups[0] = (3, 5);
            P.JouerCoup(Coups, 1);
            Coups[0] = (3, 6);
            P.JouerCoup(Coups, 1);

            Coups[0] = (2, 0);
            P.JouerCoup(Coups, 2);
            Coups[0] = (2, 1);
            P.JouerCoup(Coups, 2);
            Coups[0] = (2, 2);
            P.JouerCoup(Coups, 2);
            Coups[0] = (2, 3);
            P.JouerCoup(Coups, 1);
            Coups[0] = (2, 4);
            P.JouerCoup(Coups, 2);
            Coups[0] = (2, 5);
            P.JouerCoup(Coups, 2);
            Coups[0] = (2, 6);
            P.JouerCoup(Coups, 2);

            Coups[0] = (1, 0);
            P.JouerCoup(Coups, 1);
            Coups[0] = (1, 1);
            P.JouerCoup(Coups, 1);
            Coups[0] = (1, 2);
            P.JouerCoup(Coups, 1);
            Coups[0] = (1, 3);
            P.JouerCoup(Coups, 2);
            Coups[0] = (1, 4);
            P.JouerCoup(Coups, 1);
            Coups[0] = (1, 5);
            P.JouerCoup(Coups, 1);
            Coups[0] = (1, 6);
            P.JouerCoup(Coups, 2);

            Coups[0] = (0, 0);
            P.JouerCoup(Coups, 2);
            Coups[0] = (0, 1);
            P.JouerCoup(Coups, 2);
            Coups[0] = (0, 2);
            P.JouerCoup(Coups, 2);
            Coups[0] = (0, 3);
            P.JouerCoup(Coups, 1);
            Coups[0] = (0, 4);
            P.JouerCoup(Coups, 1);
            Coups[0] = (0, 5);
            P.JouerCoup(Coups, 2);
            Coups[0] = (0, 6);
            P.JouerCoup(Coups, 2);

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
            List<(int, int)> Coups = new List<(int, int)>();
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            Coups.Add((5, 2));
            P.JouerCoup(Coups, 1);
            Coups[0] = (4, 2);
            P.JouerCoup(Coups, 1);
            Coups[0] = (3, 2);
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 0);
            P.JouerCoup(Coups, 2);
            Coups[0] = (5, 1);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 0);
            P.JouerCoup(Coups, 2);
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
            List<(int, int)> Coups = new List<(int, int)>();
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            Coups.Add((5, 6));
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 5);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 5);
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 4);
            P.JouerCoup(Coups, 2);
            Coups[0] = (4, 4);
            P.JouerCoup(Coups, 1);
            Coups[0] = (5, 3);
            P.JouerCoup(Coups, 2);
            Coups[0] = (3, 4);
            P.JouerCoup(Coups, 1);
            Coups[0] = (4, 3);
            P.JouerCoup(Coups, 2);
            Coups[0] = (2, 3);
            P.JouerCoup(Coups, 1);
            Coups[0] = (4, 6);
            P.JouerCoup(Coups, 2);
            Coups[0] = (2, 4);
            P.JouerCoup(Coups,1);
            // Act
            res = P.EstTerminee();
            // Assert
            Assert.AreEqual(1, res);

        }
        [TestMethod]
        public void EstTerminee_Taille_9_9_Pvide_moins_1()
        {
            // Schéma AAA
            // Arrange
            List<(int, int)> Coups = new List<(int, int)>();
            int Ligne = 6, Colonne = 7, Joueur_Actif = 1, res;
            Partie P = new Partie(Ligne, Colonne, Joueur_Actif);
            //plateau inialisé avec que des 0
            // Act
            res = P.EstTerminee();
            // Assert
            Assert.AreEqual(-1, res);

        }
    }
}