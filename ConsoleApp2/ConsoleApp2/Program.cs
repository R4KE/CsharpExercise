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
                    Console.Write("Bestaat niet... ");
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
            Tank tank2 = new Tank("T34", "Sovjet-Unie", "Medium", 4, 56, 30, 76, 43, 50);
            Tank tank1 = new Tank(naam, natie, klasse, bemmaningAantal, topSnelheid, gewicht, kanonKaliber, rompPantser, koepelPantser);

            Console.Write("\n Jouw " + tank1.naam + " gaat vechten tegen de " + tank2.naam + ".");
            CalculateWinChance(tank1, tank2);
        }

        static void CalculateWinChance(Tank tankP, Tank tankE)
        {
            float winChance = 0;
            winChance += CalculateHighest(tankP.topsnelheid, tankE.topsnelheid, 0.03f);
            winChance -= CalculateHighest(tankP.gewicht, tankE.gewicht, 0.01f);
            winChance += CalculateHighest(tankP.kanonkaliber, tankE.kanonkaliber, 0.08f);
            winChance += CalculateHighest(tankP.pantserdikte_romp, tankE.pantserdikte_romp, 0.05f);
            winChance += CalculateHighest(tankP.pantserdikte_koepel, tankE.pantserdikte_koepel, 0.05f);
            winChance -= CalculateHighest(tankP.kanonkaliber, tankE.topsnelheid, 0.03f);

            float winRate = 100 * winChance;
            if (CalculateWin(winChance) == true)
            {
                Console.Write("\n Je " + tankP.naam + " heeft gewonnen!");
                Console.Write("\n Het winpercentage van de " + tankP.naam + " is " + winRate + "%");
            } else
            {
                Console.Write("\n De vijand, de " + tankE.naam + " heeft gewonnen!");
                Console.Write("\n Het winpercentage van de " + tankE.naam + " is " + -winRate + "%");
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