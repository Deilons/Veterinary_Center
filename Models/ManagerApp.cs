using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models;

public class ManagerApp
{
    public static int IdDogCounter = 0;

    public static int IdCatCounter = 0;

    public static Dog CreateDog()
    {
        IdDogCounter++;
        int id = IdDogCounter;

        Console.WriteLine("Enter the name of the animal");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("The name cannot be empty, please enter a valid name");
                name = Console.ReadLine();
            }

        }

        Console.WriteLine("Enter the birth date of the animal in the format dd/mm/yyyy");
        DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
        if (birthDate > DateOnly.FromDateTime(DateTime.Now))
        {
            Console.WriteLine("The animal cannot be born in the future, please enter a valid birth date");
            birthDate = DateOnly.Parse(Console.ReadLine());
        } else if ( birthDate.GetType() != typeof(DateOnly))
        {
            while (birthDate.GetType() != typeof(DateOnly))
            {
                Console.WriteLine("The answer cannot be empty, please enter a valid answer in the format dd/mm/yyyy");
                birthDate = DateOnly.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the breed of the animal");
        string breed = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(breed))
        {
            while (string.IsNullOrWhiteSpace(breed))
            {
                Console.Clear();
                Console.WriteLine("The breed cannot be empty, please enter a valid breed");
                breed = Console.ReadLine();
            }
        }

        Console.WriteLine("Enter the color of the animal");
        string color = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(color))
        {
            while (string.IsNullOrWhiteSpace(color))
            {
                Console.Clear();
                Console.WriteLine("The color cannot be empty, please enter a valid color");
                color = Console.ReadLine();
            }
        }

        Console.WriteLine("Enter the weight of the animal");
        double weightInKg = double.Parse(Console.ReadLine());

        if (weightInKg <= 0)
        {
            while (weightInKg <= 0)
            {
                Console.WriteLine("The weight cannot be less than zero, please enter a valid weight");
                weightInKg = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Is the animal castrated? Y/N");
        string answer = Console.ReadLine().ToUpper();
        bool isCastrated;
        if (string.IsNullOrWhiteSpace(answer))
        {
            while (string.IsNullOrWhiteSpace(answer) || answer != "Y" || answer != "N")
            {
                Console.WriteLine("The answer cannot be empty, please enter a valid answer");
                answer = Console.ReadLine();
            }
        }
        if (answer == "Y")
        {
            isCastrated = true;
        }
        else
        {
            isCastrated = false;
        }
        bool breedingStatus = isCastrated;

        Console.WriteLine("what is the temperment of the animal?");
        Console.WriteLine(@"    
            1. Shy
            2. Friendly
            3. Aggressive
                        ");
        int choice1 = int.Parse(Console.ReadLine());
        string temperament = null;

        if (choice1 > 3 || choice1 < 1 || choice1.ToString() == null)
        {
            while (choice1 > 3 || choice1 < 1 || choice1.ToString() == null)
            {
                Console.WriteLine("The answer cannot be empty, please enter a valid answer");
                choice1 = int.Parse(Console.ReadLine());
            }
        }
        switch (choice1)
        {
            case 1:
                temperament = "Shy";
                break;
            case 2:
                temperament = "Friendly";
                break;
            case 3:
                temperament = "Aggressive";
                break;
            default:
                break;
        }

        Console.WriteLine("Enter the microchip number of the animal");
        string microchipNumber = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(microchipNumber))
        {
            while (string.IsNullOrWhiteSpace(microchipNumber))
            {
                Console.WriteLine("The microchip number cannot be empty, please enter a valid microchip number");
                microchipNumber = Console.ReadLine();
            }
        }

        Console.WriteLine("Enter the bark volume of the animal");
        string barkVolume = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(barkVolume))
        {
            while (string.IsNullOrWhiteSpace(barkVolume))
            {
                Console.WriteLine("The bark volume cannot be empty, please enter a valid bark volume");
                barkVolume = Console.ReadLine();
            }
        }

        Console.WriteLine("Enter the coat type of the animal");
        Console.WriteLine(@"
            1. short
            2. medium
            3. long
            4. no hair
                        ");
        int choice2 = int.Parse(Console.ReadLine());
        string coatType = null;
        if (choice2 > 4 || choice2 < 1 || choice1.ToString() == null)
        {
            while (choice2 > 4 || choice2 < 1 || choice1.ToString() == null)
            {
                Console.WriteLine("The answer cannot be empty, please enter a valid answer");
                choice2 = int.Parse(Console.ReadLine());
            }
        }
        switch (choice2)
        {
            case 1:
                coatType = "short";
                break;
            case 2:
                coatType = "medium";
                break;
            case 3:
                coatType = "long";
                break;
            case 4:
                coatType = "no hair";
                break;
        }

        Dog newDog = new Dog(id, name, birthDate, breed, color, weightInKg, isCastrated, breedingStatus, temperament, microchipNumber, barkVolume, coatType);

        return newDog;
    }

    public static Cat CreateCat()
    {
        IdCatCounter++;
        int id = IdCatCounter;

        Console.WriteLine("Enter the name of the animal");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("The name cannot be empty, please enter a valid name");
                name = Console.ReadLine();
            }
        }

        Console.WriteLine("Enter the birth date of the animal in the format dd/mm/yyyy");
        DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
        if (birthDate > DateOnly.FromDateTime(DateTime.Now))
        {
            Console.WriteLine("The animal cannot be born in the future, please enter a valid birth date");
            birthDate = DateOnly.Parse(Console.ReadLine());
        } else if ( birthDate.GetType() != typeof(DateOnly))
        {
            while (birthDate.GetType() != typeof(DateOnly))
            {
                Console.WriteLine("The answer cannot be empty, please enter a valid answer in the format dd/mm/yyyy");
                birthDate = DateOnly.Parse(Console.ReadLine());
            }
        }


        Console.WriteLine("Enter the breed of the animal");
        string breed = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(breed))
        {
            while (string.IsNullOrWhiteSpace(breed))
            {
                Console.WriteLine("The breed cannot be empty, please enter a valid breed");
                breed = Console.ReadLine();
            }
        }

        Console.WriteLine("Enter the color of the animal");
        string color = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(color))
        {
            while (string.IsNullOrWhiteSpace(color))
            {
                Console.WriteLine("The color cannot be empty, please enter a valid color");
                color = Console.ReadLine();
            }
        }

        Console.WriteLine("Enter the weight in kg of the animal");
        double weightInKg = double.Parse(Console.ReadLine());
        if (weightInKg <= 0)
        {
            while (weightInKg <= 0)
            {
                Console.WriteLine("The weight cannot be empty, please enter a valid weight");
                weightInKg = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Is the animal castrated? Y/N");
        string answer = Console.ReadLine().ToUpper();
        bool isCastrated;
        if (string.IsNullOrWhiteSpace(answer))
        {
            while (string.IsNullOrWhiteSpace(answer) || answer != "Y" || answer != "N")
            {
                Console.WriteLine("The answer cannot be empty, please enter a valid answer");
                answer = Console.ReadLine();
            }
        }
        if (answer == "Y")
        {
            isCastrated = true;
        }
        else
        {
            isCastrated = false;
        }
        bool breedingStatus = isCastrated;

        Console.WriteLine("Enter the coat type of the animal");
        Console.WriteLine(@"
            1. short
            2. medium
            3. long
            4. no hair
                        ");
        int choice2 = int.Parse(Console.ReadLine());
        string furLength = null;
        if (choice2 > 4 || choice2 < 1 || choice2.ToString() == null)
        {
            while (choice2 > 4 || choice2 < 1 || choice2.ToString() == null)
            {
                Console.WriteLine("The answer cannot be empty, please enter a valid answer");
                choice2 = int.Parse(Console.ReadLine());
            }
        }
        switch (choice2)
        {
            case 1:
                furLength = "short";
                break;
            case 2:
                furLength = "medium";
                break;
            case 3:
                furLength = "long";
                break;
            case 4:
                furLength = "no hair";
                break;
        }

        Cat newCat = new Cat(id, name, birthDate, breed, color, weightInKg, isCastrated, breedingStatus, furLength);

        return newCat;
    }
    

}
