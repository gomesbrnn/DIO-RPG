using System;

namespace GFT_RPG.src.Entities
{
    public class Berserker : Hero
    {
        public Berserker(string Name, int Level, string HeroType, string Weapon) : base(Name, Level, HeroType, Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }

        public override void Attack()
        {
            System.Console.WriteLine("A monster is going to attack you, do you want to fight back?");
            System.Console.WriteLine("Y/N: ");
            char choice = char.Parse(Console.ReadLine());
            Console.WriteLine('\n');

            if(choice == 'Y')
            {
                Console.WriteLine($"{this.Name} used the skill: 'exile' with your {this.Weapon}!");
                Console.WriteLine("Level 20 monster eliminated!");
            }
            else if (choice == 'N')
            {
                Console.WriteLine("You ran away.");
                Console.WriteLine("Get stronger and get ready for the next.");
            }
            else
            {
                Console.WriteLine("Choose a valid option!");
            }
        }
    }
}