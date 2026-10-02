using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace eszkozok
{
    internal class Eszkoz
    {
        //adatvedelem es mezok
        private int beszerzesiAr;
        private int raktarKeszlet;
        private static int osszesLezetoEszkoz = 0;

        //properties
        public string Cikkszam { get; set; }
        public string Nev { get; set; }
        public int BeszerzesiAr 
        {
            get => beszerzesiAr;
            set => beszerzesiAr = value > 0 ? value : 0;
        }
        public int RaktarKeszlet
        {
            get => raktarKeszlet;
            set => raktarKeszlet = value > 0 ? value : 0;
        }
        public static int OsszesLetezoEszkoz { get { return osszesLezetoEszkoz; } }

        //konstruktorok
        //1
        public Eszkoz(string cikkszam, string nev, int beszerzesiAr)
        {
            Cikkszam = cikkszam;
            Nev = nev;
            BeszerzesiAr = beszerzesiAr;
            raktarKeszlet = 0;
        }
        //2
        //konstruktorlancolas, h ne kelljen 2x ugyanazt leirni (this)
        public Eszkoz(string cikkszam, string nev, int beszerzesiAr, int raktarKeszlet) : this(cikkszam, nev, beszerzesiAr)
        {
            RaktarKeszlet = raktarKeszlet;
            osszesLezetoEszkoz++;
        }
        //kiiras cucc
        public override string ToString()
        {
            return $"[{Cikkszam}] {Nev} | Beszerzési ár: {BeszerzesiAr} Ft | Készlet: {RaktarKeszlet} db";
        }
        //eladas fuggveny
        public bool Eladas(int db)
        {
            if (RaktarKeszlet >= db)
            {
                RaktarKeszlet -= db;
                return true;
            }
            else
            {
                Console.WriteLine("Nincs elég a készleten!");
                return false;
            }
        }
    }
}
