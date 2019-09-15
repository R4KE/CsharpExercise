using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tank
    {
        public string naam;
        public string natie;
        public string klasse;
        public int bemanningaantal;
        public int topsnelheid;
        public int gewicht;
        public int kanonkaliber;
        public int pantserdikte_romp;
        public int pantserdikte_koepel;

        public Tank(string nNaam, string nNatie, string nKlasse, int nBemanningaantal, int nTopsnelheid, int nGewicht, int nKanonkaliber, int nPantserdikte_romp, int nPantserdikte_koepel)
        {
            naam = nNaam;
            natie = nNatie;
            klasse = nKlasse;
            bemanningaantal = nBemanningaantal;
            topsnelheid = nTopsnelheid;
            gewicht = nGewicht;
            kanonkaliber = nKanonkaliber;
            pantserdikte_romp = nPantserdikte_romp;
            pantserdikte_koepel = nPantserdikte_koepel;
        }
    }
}
