using BibliothequeJeuPuissance4;
Partie p;
Partie p1;
IA a;
p = new Partie(6, 7, 1);
a = new IA(5);

List<(int, int)> CoupAJouer = new List<(int, int)>();
List<(int, int)> C = new List<(int, int)>();

C.Add((5, 0));
p.JouerCoup(C, 1);
C[0] = ((4, 0));
p.JouerCoup(C, 1);
C[0] = ((3, 0));
p.JouerCoup(C, 1);
C[0] = ((2, 0));
p.JouerCoup(C, 1);


C[0] = ((5, 1));
p.JouerCoup(C, 1);
C[0] = ((4, 1));
p.JouerCoup(C, 1);
C[0] = ((3, 1));
p.JouerCoup(C, 1);
C[0] = ((2, 1));
p.JouerCoup(C, 1);
C[0] = ((1, 1));
p.JouerCoup(C, 1);


C[0] = ((5, 2));
p.JouerCoup(C, 1);
C[0] = ((4, 2));
p.JouerCoup(C, 1);
C[0] = ((3, 2));
p.JouerCoup(C, 1);
C[0] = ((2, 2));
p.JouerCoup(C, 1);
C[0] = ((1, 2));
p.JouerCoup(C, 1);


C[0] = ((5, 3));
p.JouerCoup(C, 1);
C[0] = ((4, 3));
p.JouerCoup(C, 1);
C[0] = ((3, 3));
p.JouerCoup(C, 1);
C[0] = ((2, 3));
p.JouerCoup(C, 1);
C[0] = ((1, 3));
p.JouerCoup(C, 1);


C[0] = ((5, 4));
p.JouerCoup(C, 1);
C[0] = ((4, 4));
p.JouerCoup(C, 1);
C[0] = ((3, 4));
p.JouerCoup(C, 1);
C[0] = ((2, 4));
p.JouerCoup(C, 1);
C[0] = ((1, 4));
p.JouerCoup(C, 1);


C[0] = ((5, 5));
p.JouerCoup(C, 1);
C[0] = ((4, 5));
p.JouerCoup(C, 1);
C[0] = ((3, 5));
p.JouerCoup(C, 1);
C[0] = ((2, 5));
p.JouerCoup(C, 1);
C[0] = ((1, 5));
p.JouerCoup(C, 1);


C[0] = ((5, 6));
p.JouerCoup(C, 1);
C[0] = ((4, 6));
p.JouerCoup(C, 1);
C[0] = ((3, 6));
p.JouerCoup(C, 1);
C[0] = ((2, 6));
p.JouerCoup(C, 1);
C[0] = ((1, 6));
p.JouerCoup(C, 1);


CoupAJouer = a.ListeCoupPossible(p);
for(int i = 0; i < CoupAJouer.Count; i++)
{
    Console.WriteLine(CoupAJouer[i]);
}


for (int i = 0; i < p.GetLignes(); i++)
{
    for (int j = 0; j < p.GetColonnes(); j++)
    {
        Console.Write(p.GetPion(i, j));
    }
    Console.Write("\n");
}

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
/*
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
*/






















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



