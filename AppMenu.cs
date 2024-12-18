using System;

namespace TPfinalC
{
    public class AppMenu
    {
        private Manage parc;
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
            parc = new Manage();

            Interface();
        }

        private void Interface()
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
                            ChoseCar();
                            break;
                        case 2:
                            Console.Clear();
                            _instance.parc.ListCar();
                            break;
                        case 3:
                            //parc.();
                            Console.Clear();
                            Console.WriteLine(UserInput);
                            break;
                        case 4:
                            //parc.();
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

        private void ChoseCar()
        {
            Console.Clear();
            bool quit = true;
            while (quit){
                Console.WriteLine(
                "+------------------------------------+\n"+
                "| Add folowing modéle to the parck : |\n"+
                "|                                    |\n"+
                "| 1 - Merceges, Benz                 |\n"+
                "| 2 - Pegeo, berlyngot               |\n"+
                "| 3 - Reno, C4                       |\n"+
                "| 4 - Exit                           |\n"+
                "+------------------------------------+\n"
                );
                            
                string UserInput = Console.ReadLine();
                switch (UserInput)
                {
                    case "1":
                        Console.Clear();
                        _instance.parc.AddCar(new Merceges(_instance.parc.GetID()));
                        Console.WriteLine("Car sucefuly added !\n");
                        quit = false;
                        break;
                    case "2":
                        Console.Clear();
                        _instance.parc.AddCar(new Pegeo(_instance.parc.GetID()));
                        Console.WriteLine("Car sucefuly added !\n");
                        quit = false;
                        break;
                    case "3":
                        Console.Clear();
                        _instance.parc.AddCar(new Reno(_instance.parc.GetID()));
                        Console.WriteLine("Car sucefuly added !\n");
                        quit = false;
                        break;
                    case "4":
                        quit = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Enter a valid number !\n");
                        break;
                }
            }
        }
    }
}