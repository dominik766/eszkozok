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
        public string Nev {  get; set; }
        public int BeszerzesiAr { get; set { if (beszerzesiAr == 0 || beszerzesiAr < 0) { value = 0; } } }
        public int RaktarKeszlet { get; set { if (raktarKeszlet == 0 || raktarKeszlet > 0) { value = 0; } } }
        public readonly int OsszesLetezoEszkoz = osszesLezetoEszkoz;
    }
}
