using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tank
    {
        private string naam;
        private string natie;
        private string klasse;
        private int bemanningaantal;
        private int topsnelheid;
        private int gewicht;
        private int kanonkaliber;
        private int pantserdikte_romp;
        private int pantserdikte_koepel;

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

        public string TankNaam
        {
            get
            {
                return TankNaam;
            }
            set
            {
                TankNaam = naam;
            }
        }

        public string TankNatie
        {
            get
            {
                return TankNatie;
            }
            set
            {
                TankNatie = natie;
            }
        }

        public string TankKlasse
        {
            get
            {
                return TankKlasse;
            }
            set
            {
                TankKlasse = klasse;
            }
        }

        public int TankBemmaning
        {
            get
            {
                return TankBemmaning;
            }
            set
            {
                TankBemmaning = bemanningaantal;
            }
        }

        public int TankSnelheid
        {
            get
            {
                return TankSnelheid;
            }
            set
            {
                TankSnelheid = topsnelheid;
            }
        }

        public int TankGewicht
        {
            get
            {
                return TankGewicht;
            }
            set
            {
                TankGewicht = gewicht;
            }
        }

        public int TankKanon
        {
            get
            {
                return TankKanon;
            }
            set
            {
                TankKanon = kanonkaliber;
            }
        }

        public int TankRompPantser
        {
            get
            {
                return TankRompPantser;
            }
            set
            {
                TankRompPantser = pantserdikte_romp;
            }
        }

        public int TankKoepelPantser
        {
            get
            {
                return TankKoepelPantser;
            }
            set
            {
                TankKoepelPantser = pantserdikte_koepel;
            }
        }
    }

}
