using Veterinary_Center.Models;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        bool isRunning = true;
        
        while (isRunning)
        {   
            var veterinaryClinic = new VeterinaryClinic( "Vet Clinic", "123 Main Street");

            Console.Clear();
            ManagerApp.ShowHeader();
            Console.WriteLine(@$"
            ╔══════════════════════════════════════════════════╗
            ║                                                  ║
            ║                                                  ║
            ║             Please select an option:             ║
            ║                                                  ║
            ║            [1] Register a new Dog                ║
            ║            [2] Register a new Cat                ║
            ║            [3] Update an existing Dog            ║
            ║            [4] Update an existing Cat            ║
            ║            [5] Delete an existing Dog            ║
            ║            [6] Delete an existing Cat            ║
            ║            [7] Show all registered patients      ║
            ║            [8] Show animals by type              ║
            ║            [9] Search an animal by name          ║
            ║            [10] Exit                             ║
            ║                                                  ║
            ║                                                  ║
            ╚══════════════════════════════════════════════════╝

                ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    veterinaryClinic.SaveDog(ManagerApp.CreateDog());
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 2:
                    Console.Clear();
                    veterinaryClinic.SaveCat(ManagerApp.CreateCat());
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 3:
                    Console.Clear();
                    veterinaryClinic.UpdateDog();
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 4:
                    Console.Clear();
                    veterinaryClinic.UpdateCat();
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 5:
                    Console.Clear();
                    veterinaryClinic.DeleteDog();
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 6:
                    Console.Clear();
                    veterinaryClinic.DeleteCat();
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 7:
                    Console.Clear();
                    veterinaryClinic.ShowAllPatients();
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("Enter the type of animal (dog or cat):");
                    string animalType = Console.ReadLine();
                    veterinaryClinic.ShowAnimals(animalType);
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("Enter the name of the animal:");
                    string PatientName = Console.ReadLine();
                    veterinaryClinic.ShowAnimalByName(PatientName);
                    ManagerApp.ShowSeparator();
                    ManagerApp.Continue();
                    break;

                case 10:
                    Console.Clear();
                    ManagerApp.ShowSeparator();
                    Console.WriteLine("Are you sure you want to exit? (y/n)");
                    ManagerApp.ShowSeparator();

                    string exit = Console.ReadLine();
                    if (exit == "y")
                    {   
                        Console.WriteLine("Goodbye!");
                        ManagerApp.ShowFooter();
                        isRunning = false;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    ManagerApp.Continue();
                    break;
            }
        }
        
    }
}   