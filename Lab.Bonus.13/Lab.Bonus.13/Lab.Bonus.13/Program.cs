using System;

namespace Lab.Bonus._13
{
    class Program
    {
        static void Main(string[] args)

        {
            var GameCharacter = new GameCharacter();
            var MagicUsingCharacter = new MagicUsingCharacter();


            var GameCharacters = new GameCharacter[5];
            
            var Warrior = new Warrior();
            Warrior.Name = "Golin";
            Warrior.Strength = 30;
            Warrior.Intelligence = 5;

            GameCharacters[0] = Warrior;

            var Warrior2 = new Warrior();
            Warrior2.Name = "Legolas";
            Warrior2.Strength = 22;
            Warrior2.Intelligence = 11;

            GameCharacters[1] = Warrior2;

            var Wizard = new Wizard();
            Wizard.Name = "Gandalf";
            Wizard.Strength = 15;
            Wizard.Intelligence = 34;

            GameCharacters[2] = Wizard;

            var Wizard2 = new Wizard();
            Wizard2.Name = "Saruman";
            Wizard2.Strength = 18;
            Wizard2.Intelligence = 32;

            GameCharacters[3] = Wizard2;

            var Wizard3 = new Wizard();
            Wizard3.Name = "Elrond";
            Wizard3.Strength = 10;
            Wizard3.Intelligence = 12;

            GameCharacters[4] = Wizard3;


            for (int i = 0; i < GameCharacters.Length; i++)
            {
                if (GameCharacters[i] == null)
                {
                    break;
                }

                Console.Write($"{GameCharacters[i].Play()}\n");
            }
        }
    }
}

//Frodo Baggins - hobbit
//Legolas - elf-warior/wizzard
// - warrior
//Gandalf - wizzard 
//Elrond - elf- warrior
//var Warrior = new Warrior();
//Warrior.Name = "Golin";
//            Warrior.Strength = 2;
//            Warrior.Intelligence = 5;

//            var Warrior2 = new Warrior();
//Warrior.Name = "Legolas";
//            Warrior.Strength = 4;
//            Warrior.Intelligence = 5;


//            var Wizard = new Wizard();
//Wizard.Name = "Gandalf";

//            var Wizard2 = new Wizard();
//Wizard.Name = "Saruman";
