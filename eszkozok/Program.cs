using eszkozok;

//fajlbeolvasas es hibakezeles
List<Eszkoz> adatok = new List<Eszkoz>();
foreach (string sor in File.ReadAllLines("eszkozok.txt"))
{
    string[] mezok = sor.Split(';');

    if (!int.TryParse(mezok[3], out int raktardb))
    {
        raktardb = 0;
    }

    if (!int.TryParse(mezok[2], out int ar))
    {
        Console.WriteLine($"[HIBA] A(z) {mezok[0]} sor adatai hibásak, átugorva.");
        continue;
    }

    Eszkoz ujEszkoz = new Eszkoz(mezok[0], mezok[1], ar, raktardb);
    adatok.Add(ujEszkoz);
}

//kiiras
Console.WriteLine("\n=== SIKERESEN BEOLVASOTT ESZKÖZÖK ===");
foreach (Eszkoz eszkoz in adatok)
{
    Console.WriteLine(eszkoz);
}
Console.WriteLine($"Rendszerben registrált eszközök száma: {Eszkoz.OsszesLetezoEszkoz} db");

//brutto ar kiszamitas fuggveny hasznalata
double osszesBruttoAr = 0;
foreach (Eszkoz eszkoz in adatok)
{
    osszesBruttoAr += Penzugy.BruttoArSzamitas((double)eszkoz.BeszerzesiAr*eszkoz.RaktarKeszlet);
}
Console.WriteLine($"Raktárkészlet teljes bruttó értéke: {osszesBruttoAr:0,0} Ft.");
