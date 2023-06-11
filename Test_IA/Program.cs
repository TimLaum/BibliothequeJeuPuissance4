using BibliothequeJeuPuissance4;
Partie p;
Partie p1;
IA a;
p = new Partie(6, 7, 1);
a = new IA(4, 2);

List<(int, int)> CoupAJouer = new List<(int, int)>();
List<(int, int)> C = new List<(int, int)>();

C.Add((5, 0));
p.JouerCoup(C, 1);
C[0] = ((5, 1));
p.JouerCoup(C, 1);


Console.WriteLine(a.Evaluer(p));

/*
C.Add((5, 0));
p.JouerCoup(C,1);
C[0] = (4,0);
p.JouerCoup(C, 1);
C[0] = (3, 0);
p.JouerCoup(C, 1);
C[0] = (2, 0);
p.JouerCoup(C, 1);
*/

for (int i = 0; i < p.GetLignes(); i++)
{
    for (int j = 0; j < p.GetColonnes(); j++)
    {
        Console.Write(p.GetPion(i, j));
    }
    Console.Write("\n");
}
CoupAJouer = a.MeilleurCoup(p);
Console.Write(CoupAJouer[0].Item1);
Console.Write(CoupAJouer[0].Item2);
Console.Write("\n");
p.JouerCoup(CoupAJouer, 2);
for (int i = 0; i < p.GetLignes(); i++)
{
    for (int j = 0; j < p.GetColonnes(); j++)
    {
        Console.Write(p.GetPion(i, j));
    }
    Console.Write("\n");
}






















/*
C[0] = (2, 6);
p.JouerCoup(C, 2);
C[0] = (1, 6);
p.JouerCoup(C, 1);
C[0] = (0, 6);
p.JouerCoup(C, 2);
*/
/*
CoupAJouer =a.MeilleurCoup(p);
Console.Write(CoupAJouer[0].Item1);
Console.Write(CoupAJouer[0].Item2);
Console.Write(p.GetLignes());
Console.Write("\n");
p.JouerCoup(CoupAJouer,2);

*/

/*
C=a.ListeCoupPossible(p);

for(int i = 0; i < C.Count; i++)
{
    Console.WriteLine(C[i]);
}
*/



