using System;

namespace GFT_RPG.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public string Weapon { get; set; }

        void AdventureMessage()
        {
            Console.WriteLine("Let's get it!");
            Console.WriteLine("A little bit of your hero: " + '\n');
        }
        public void HeroInfo()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Class: {this.HeroType}");
            Console.WriteLine($"Level: {this.Level}");
            Console.WriteLine($"Weapon: {this.Weapon}");
        }

        public void SelectHero()
        {
            AdventureMessage();
            HeroInfo();
            Console.WriteLine('\n');
        }

        public virtual void Attack()
        {
            System.Console.WriteLine("A monster is going to attack you, do you want to fight back?");
            System.Console.WriteLine("Y/N: ");
            char choice = char.Parse(Console.ReadLine());

            if (choice == 'Y')
            {
                Console.WriteLine($"{this.Name} attacked with his {this.Weapon}");
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

        public void PlayAdventure()
        {
            System.Console.WriteLine("Do yo want to start a new adventure?");
            System.Console.WriteLine("Y/N: ");
            char choice = char.Parse(Console.ReadLine());
            Console.WriteLine('\n');

            if (choice == 'Y')
            {
                Attack();
            }
            else if (choice == 'N')
            {
                Console.WriteLine("Okay, see ya!");
            }
            else
            {
                Console.WriteLine("Choose a valid option!");
            }
        }
    }
}