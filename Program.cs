using Veterinary_Center.Models;

Console.Clear();
var veterinaryClinic = new VeterinaryClinic( "Vet Clinic", "123 Main Street");

bool isRunning = true;

while (isRunning)
{
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
            ManagerApp.CreateDog();
            ManagerApp.Continue();
            break;

        case 2:
            ManagerApp.CreateCat();
            ManagerApp.Continue();
            break;

        case 3:
            veterinaryClinic.UpdateDog();
            ManagerApp.Continue();
            break;

        case 4:
            veterinaryClinic.UpdateCat();
            ManagerApp.Continue();
            break;

        case 5:
            veterinaryClinic.DeleteDog();
            ManagerApp.Continue();
            break;

        case 6:
            veterinaryClinic.DeleteCat();
            ManagerApp.Continue();
            break;

        case 7:
            veterinaryClinic.ShowAllPatients();
            ManagerApp.Continue();
            break;

        case 8:
            Console.WriteLine("Enter the type of animal (dog or cat):");
            string animalType = Console.ReadLine();
            veterinaryClinic.ShowAnimals(animalType);
            ManagerApp.Continue();
            break;

        case 9:
            Console.WriteLine("Enter the name of the animal:");
            string PatientName = Console.ReadLine();
            veterinaryClinic.ShowAnimalByName(PatientName);
            ManagerApp.Continue();
            break;

        case 10:
            Console.WriteLine("Are you sure you want to exit? (y/n)");
            string exit = Console.ReadLine();
            if (exit == "y")
            {   
                Console.WriteLine("Goodbye!");
                isRunning = false;
            }
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            ManagerApp.Continue();
            break;
    }
}