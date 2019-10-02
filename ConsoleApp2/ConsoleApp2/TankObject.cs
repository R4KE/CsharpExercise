using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tank
    {
        private string tankNaam;
        private string tankNatie;
        private string tankKlasse;
        private int tankBemanningAantal;
        private int tankTopsnelheid;
        private int tankGewicht;
        private int tankKanonkaliber;
        private int tankPantserdikte_romp;
        private int tankPantserdikte_koepel;

        public Tank(string nNaam, string nNatie, string nKlasse, int nBemanningaantal, int nTopsnelheid, int nGewicht, int nKanonkaliber, int nPantserdikte_romp, int nPantserdikte_koepel)
        {
            tankNaam = nNaam;
            tankNatie = nNatie;
            tankKlasse = nKlasse;
            tankBemanningAantal = nBemanningaantal;
            tankTopsnelheid = nTopsnelheid;
            tankGewicht = nGewicht;
            tankKanonkaliber = nKanonkaliber;
            TankPantserdikte_romp = nPantserdikte_romp;
            TankPantserdikte_koepel = nPantserdikte_koepel;
        }

        public string TankNaam
        {
            get
            {
                return tankNaam;
            }
            set
            {
                tankNaam = value;
            }
        }

        public string TankNatie
        {
            get
            {
                return tankNatie;
            }
            set
            {
                tankNatie = value;
            }
        }

        public string TankKlasse
        {
            get
            {
                return tankKlasse;
            }
            set
            {
                tankKlasse = value;
            }
        }

        public int TankBemanningAantal
        {
            get
            {
                return tankBemanningAantal;
            }
            set
            {
                tankBemanningAantal = value;
            }
        }

        public int TankSnelheid
        {
            get
            {
                return tankTopsnelheid;
            }
            set
            {
                tankTopsnelheid = value;
            }
        }

        public int TankGewicht
        {
            get
            {
                return tankGewicht;
            }
            set
            {
                tankGewicht = value;
            }
        }

        public int TankKanonKaliber
        {
            get
            {
                return tankKanonkaliber;
            }
            set
            {
                tankKanonkaliber = value;
            }
        }

        public int TankPantserdikte_romp
        {
            get
            {
                return tankPantserdikte_romp;
            }
            set
            {
                tankPantserdikte_romp = value;
            }
        }

        public int TankPantserdikte_koepel
        {
            get
            {
                return tankPantserdikte_koepel;
            }
            set
            {
                tankPantserdikte_koepel = value;
            }
        }

    }
}