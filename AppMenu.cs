using System;

namespace TPfinalC
{
    public class AppMenu
    {
        //private Manage Parc;
        private static AppMenu _instance;

        public static AppMenu GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppMenu();
            }
            return _instance;
        }

        public AppMenu()
        {
            //Parc = new Manage();

            Interface();
        }

        private static void Interface()
        {
            Console.Clear();

            bool Quit = false;

            Console.WriteLine("Welcome to car gestioneer 2077 :\n");
            while (Quit == false)
            {
                PrintChoices();
                string UnverifedInput = Console.ReadLine();
                try {
                    int UserInput = int.Parse(UnverifedInput);
                    switch (UserInput)
                    {
                        case 1:
                            //Parc.();
                            Console.Clear();
                            Console.WriteLine(UserInput);
                            break;
                        case 2:
                            //Parc.();
                            Console.Clear();
                            Console.WriteLine(UserInput);
                            break;
                        case 3:
                            //Parc.();
                            Console.Clear();
                            Console.WriteLine(UserInput);
                            break;
                        case 4:
                            //Parc.();
                            Console.Clear();
                            Console.WriteLine(UserInput);
                            break;
                        case 5:
                            Quit = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Enter a valid number !\n");
                            break;
                    }
                }
                catch (Exception e) {
                    Console.Clear();
                    Console.WriteLine("Enter a valid number !\n");
                }
            }
            Console.Clear();
            Console.WriteLine("End of the Manager.\n");
        }

        private static void PrintChoices()
        {
            Console.WriteLine(
                "+-----------------------------------+\n"+
                "| Enter on of the folowing option : |\n"+
                "|                                   |\n"+
                "| 1 - Ajouter une nouvelle voiture  |\n"+
                "| 2 - Lister les voitures           |\n"+
                "| 3 - Louer une voiture             |\n"+
                "| 4 - Rendre une voiture            |\n"+
                "| 5 - Quiter                        |\n"+
                "+-----------------------------------+\n"
                );
        }
    }
}