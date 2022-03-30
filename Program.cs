using System;
using GFT_RPG.src.Entities;

namespace GFT_RPG
{
    class program
    {
        static void Main(string[] args)
        {

            Berserker Thork = new Berserker("Thork", 70, "Berserker", "Long Sword");
            Lancer Arthur = new Lancer("Arthur", 50, "Lancer", "Spear");

            Thork.SelectHero();
            Thork.PlayAdventure();
        }
    }
}