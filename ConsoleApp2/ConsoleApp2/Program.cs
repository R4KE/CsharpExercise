using ConsoleApp2;
using System;

namespace HelloWorld
{

    class Program
    {

        static void Main()
        {
            Tank tank1 = new Tank("T34", "Sovjet-Unie", "Medium", 4, 56, 30, 76, 43, 50);
            //naam //natie //klasse //bemanningaantal //topsnelheid //gewicht //kanonkaliber //p_romp //p_koepel
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

            Console.Write("\n Hoeveel mennen zitten er in het pantservoertuig? : ");
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

            Tank tank2 = new Tank(naam, natie, klasse, bemmaningAantal, topSnelheid, gewicht, kanonKaliber, rompPantser, koepelPantser);

            Console.Write("\n Jouw " + tank2.naam + " gaat vechten tegen de " + tank1.naam);
            CalculateWin(tank1, tank2);
        }

        static void CalculateWin(Tank tankP, Tank tankE)
        {
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}