using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogAbibakar
{
    internal class Trainer
    {
        private static List<Pokemon> Inventory = new List<Pokemon>();

        public static string GetName()
        {
            Console.WriteLine("Hva heter du?");
            return Console.ReadLine();
        }

        public static void ChooseStarterPokemon()
        {
            string userInput2 = "";
            do
            {
                Console.WriteLine("Velg din starter-Pokemon:");
                Console.WriteLine("1: Bulbasaur");
                Console.WriteLine("2: Squirtle");
                Console.WriteLine("3: Charmander");
                userInput2 = Console.ReadLine();
            } while (userInput2 is not ("1" or "2" or "3"));

            switch (userInput2)
            {
                case "1":
                    //Bulbasaur
                    Inventory.Add(new Pokemon("Bulbasaur", 21, 21));
                    break;
                case "2":
                    //doSomethingElse(); //Se inventory

                    Inventory.Add(new Pokemon("Squirtle", 21, 21));
                    break;

                case "3":

                    Inventory.Add(new Pokemon("Charmander", 21, 21));
                    break;
            }
        }

        public static void FangPokmen()
        {
            Console.WriteLine(" du er ute for fange pokemon!");

            string[] wilpokmen = { "pikachu", "charmer", "poki", };

            

            Random random = new Random();

            string FangPokmen = wilpokmen[random.Next(wilpokmen.Length)];

            Inventory.Add(new Pokemon(FangPokmen,21,21));


            Console.WriteLine($"du cathc pokmen{FangPokmen}");

        }

        public static void Gotilbuttiken()
        {
            Console.WriteLine("1, get pokmon");

            string userchoice = Console.ReadLine();

            switch (userchoice)
            {
                case "1":

                    string[] pokombutik = { "pikachu", "charmer" };
                    Random random = new Random();


                    string boughtpokmon = pokombutik [random.Next(pokombutik.Length)];

                    Inventory.Add(new Pokemon(boughtpokmon,33,44));

                    Console.WriteLine($"succesful added {boughtpokmon}");



                break;
            }


        }

        public static void ShowInventory()


        {
            Console.WriteLine("here er det iventory");
            if (Inventory.Count == 0)
            {
                Console.WriteLine("you got no pokmon");

            }
            else
            {
                foreach (var Pokemon in Inventory)
                {
                    Console.WriteLine($"here er iventory: {Pokemon.Name}");

                }
            }
        }








        public static void ShowChoiceMenu()
        {
            string userInput;
            do
            {
                Console.WriteLine("Velg alternativ under:");
                Console.WriteLine("1: Fang pokemons");
                Console.WriteLine("2: Se inventory");
                Console.WriteLine("3: Gå til butikk");
                userInput = Console.ReadLine();
            } while (userInput is not ("1" or "2" or "3"));

            switch (userInput)
            {
                case "1":
                    //doSomething(); //Fang pokemons

                    FangPokmen();

                    break;
                case "2":
                    //doSomethingElse(); //Se inventory

                    ShowInventory();





                    break;

                case "3":

                    Gotilbuttiken();

                    break;





            }
        }
    }
}
