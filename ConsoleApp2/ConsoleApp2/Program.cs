using ConsoleApp2;
using System;

namespace HelloWorld
{

    class Program
    {
        static void Main()
        {
            //Tank win calculator

            Console.Write("Hoe heet de tank? : ");
            string naam = Console.ReadLine();

            Console.Write("\n");
            Console.Write("Van welke natie is de tank? : ");
            string natie = Console.ReadLine();

            string klasse = "";
            bool incorrect = true;
            while (incorrect)
            {
                Console.Write("\n Van welk type is de tank? \n");
                Console.Write(" \nlicht | medium | zwaar | mbt | spg | antitank \n");
                Console.Write("\n : ");
                klasse = Console.ReadLine();
                if (klasse.ToLower() == "licht" || klasse.ToLower() == "medium" || klasse.ToLower() == "zwaar" || klasse.ToLower() == "mbt" || klasse.ToLower() == "spg" || klasse.ToLower() == "antitank") {
                    incorrect = false;
                } else {
                    Console.Write("\n Bestaat niet... ");
                }

            }

            Console.Write("\n Hoeveel mensen zitten er in het pantservoertuig? : ");
            int bemmaningAantal = Convert.ToInt16(Console.ReadLine());

            Console.Write("\n Wat is de topsnelheid? : ");
            int topSnelheid = Convert.ToInt16(Console.ReadLine());

            Console.Write("\n Hoe zwaar is de tank in ton? : ");
            int gewicht = Convert.ToInt16(Console.ReadLine());

            Console.Write("\n Wat is de diameter van het kanon in MM? : ");
            int kanonKaliber = Convert.ToInt16(Console.ReadLine());

            Console.Write("\n Wat is de gemiddelde dichte van het romppantser in MM? : ");
            int rompPantser = Convert.ToInt16(Console.ReadLine());

            Console.Write("\n Wat is de gemiddelde dichte van het koepelpantser in MM? : ");
            int koepelPantser = Convert.ToInt16(Console.ReadLine());

            //naam //natie //klasse //bemanningaantal //topsnelheid //gewicht //kanonkaliber //p_romp //p_koepel

            //Tank tank2 = new Tank("T34", "Sovjet-Unie", "Medium", 4, 56, 30, 76, 43, 50);
            //Tank tank2 = new Tank("Tiger I", "Duitsland", "Zwaar", 5, 40, 55, 88, 90, 90);
            Tank tank2 = new Tank("Panther I", "Duitsland", "Medium", 5, 55, 45, 75, 58, 63);
            //Tank tank2 = new Tank("MS-1", "Sovjet-Unie", "Licht", 2, 32, 6, 45, 16, 16);
            //Tank tank2 = new Tank("E75", "Duitsland", "Zwaar", 5, 40, 85, 128, 132, 115);
            //Tank tank2 = new Tank("Maus", "Duitsland", "Zwaar", 6, 20, 188, 128, 182, 226);
            //Tank tank2 = new Tank("M4A1", "Amerika", "Medium", 5, 48, 30, 75, 42, 60);
            //Tank tank2 = new Tank("M4A1", "Amerika", "Medium", 5, 48, 30, 75, 42, 60);

            Tank tank1 = new Tank(naam, natie, klasse, bemmaningAantal, topSnelheid, gewicht, kanonKaliber, rompPantser, koepelPantser);

            Console.Write("\n Jouw " + tank1.TankNaam + " gaat vechten tegen de " + tank2.TankNaam + ".");
            CalculateWinChance(tank1, tank2);
        }

        static void CalculateWinChance(Tank tankP, Tank tankE)
        {
            float winChance = 0;
            winChance += CalculateHighest(tankP.TankSnelheid, tankE.TankSnelheid, 0.03f);
            winChance -= CalculateHighest(tankP.TankGewicht, tankP.TankGewicht, 0.01f);
            winChance += CalculateHighest(tankP.TankKanon, tankE.TankKanon, 0.08f);
            winChance += CalculateHighest(tankP.TankRompPantser, tankE.TankRompPantser, 0.05f);
            winChance += CalculateHighest(tankP.TankKoepelPantser, tankE.TankKoepelPantser, 0.05f);
            winChance -= CalculateHighest(tankP.TankKanon, tankE.TankSnelheid, 0.03f);

            float winRate = 100 * winChance;
            if (CalculateWin(winChance) == true)
            {
                Console.Write("\n Je " + tankP.TankNaam + " heeft gewonnen!");
                Console.Write("\n Het winpercentage van de " + tankP.TankNaam + " is " + winRate + "%");
            } else
            {
                Console.Write("\n De vijand, de " + tankE.TankNaam + " heeft gewonnen!");
                Console.Write("\n Het winpercentage van de " + tankE.TankNaam + " is " + -winRate + "%");
            }
            Console.ReadLine();
        }

        static bool CalculateWin(float winChance)
        {
            bool win = false;
            if (winChance > 0) {
                win = true;
            }
            return win;
        }

        static float CalculateHighest(int stat1, int stat2, float factor)
        {
            float winFactor = 0;
            if(stat1 > stat2) {
                winFactor += Math.Abs(stat1 - stat2) * factor;
            } else if(stat1 == stat2) {
                //Do nothing
            } else
            {
                winFactor -= Math.Abs(stat1 - stat2) * factor;
            }
            return winFactor;
        }
    }
}