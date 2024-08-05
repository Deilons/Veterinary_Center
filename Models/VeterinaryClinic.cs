using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models;

public class VeterinaryClinic
{   
    // properties
    public string Name { get; set; }

    public string Address { get; set; }

    public List<Dog> Dogs = new List<Dog>();

    public List<Cat> Cats = new List<Cat>();

    // constructor
    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
    }

    // methods

    public void SaveDog(Dog newDog)
    {
        Dogs.Add(newDog);
    }

    public void SaveCat(Cat newCat)
    {
        Cats.Add(newCat);
    }

    // update dog
    public void UpdateDog()
{
    Console.WriteLine("Enter the ID of the dog you want to update:");
    int dogId = int.Parse(Console.ReadLine());

    if (dogId <= 0)
    {
        Console.WriteLine("Invalid dog ID. Please enter a valid ID.");
        return;
    }

    Dog dogToUpdate = Dogs.FirstOrDefault(dog => dog.GetId() == dogId);

    if (dogToUpdate == null)
    {
        Console.WriteLine("Dog with the given ID not found. Please enter a valid ID.");
        return;
    }

    Console.WriteLine("Enter the new name for the dog:");
    string newName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(newName))
    {
        while (string.IsNullOrWhiteSpace(newName))
        {
            Console.WriteLine("The name cannot be empty, please enter a valid name");
            newName = Console.ReadLine();
        }
    }

    dogToUpdate.SetName(newName);
    
    Console.WriteLine("Enter the new birth date for the dog:");
    DateOnly newBirthDate = DateOnly.Parse(Console.ReadLine());

    if (newBirthDate > DateOnly.FromDateTime(DateTime.Now))
    {
        while (newBirthDate > DateOnly.FromDateTime(DateTime.Now))
        {
            Console.WriteLine("The birth date cannot be in the future, please enter a valid birth date");
            newBirthDate = DateOnly.Parse(Console.ReadLine());
        }
    }

    dogToUpdate.SetBirthDate(newBirthDate);

    Console.WriteLine("Enter the new breed for the dog:");
    string newBreed = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(newBreed))
    {
        while (string.IsNullOrWhiteSpace(newBreed))
        {
            Console.WriteLine("The breed cannot be empty, please enter a valid breed");
            newBreed = Console.ReadLine();
        }
    }

    dogToUpdate.SetBreed(newBreed);

    Console.WriteLine("Enter the new color for the dog:");
    string newColor = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(newColor))
    {
        while (string.IsNullOrWhiteSpace(newColor))
        {
            Console.WriteLine("The color cannot be empty, please enter a valid color");
            newColor = Console.ReadLine();
        }
    }

    dogToUpdate.SetColor(newColor);

    Console.WriteLine("Enter the new weight for the dog:");
    double newWeight = double.Parse(Console.ReadLine());

    if (newWeight <= 0)
    {
        while (newWeight <= 0)
        {
            Console.WriteLine("The weight cannot be zero or negative, please enter a valid weight");
            newWeight = double.Parse(Console.ReadLine());
        }
    }

    dogToUpdate.SetWeightInKg(newWeight);

    Console.WriteLine("Enter the new castrated status for the dog:  (0 = no, 1 = yes)");
    bool newCastrated = bool.Parse(Console.ReadLine());

    if (newCastrated == null)
    {
        while (newCastrated == null)
        {
            Console.WriteLine("The castrated status cannot be empty, please enter a valid castrated status (0 = no, 1 = yes)");
            newCastrated = bool.Parse(Console.ReadLine());
        }
    }

    dogToUpdate.SetIsCastrated(newCastrated);


    Console.WriteLine("Enter the new temperament for the dog:");
    Console.WriteLine(@"    
            1. Shy
            2. Friendly
            3. Aggressive
                        ");
        int choice1 = int.Parse(Console.ReadLine());
        string newTemperament = null;

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
                newTemperament = "Shy";
                break;
            case 2:
                newTemperament = "Friendly";
                break;
            case 3:
                newTemperament = "Aggressive";
                break;
            default:
                break;
        }

    dogToUpdate.Temperament = newTemperament;


    Console.WriteLine("Enter the new microchip number for the dog:");
    string newMicrochipNumber = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(newMicrochipNumber))
    {
        while (string.IsNullOrWhiteSpace(newMicrochipNumber))
        {
            Console.WriteLine("The microchip number cannot be empty, please enter a valid microchip number");
            newMicrochipNumber = Console.ReadLine();
        }
    }

    dogToUpdate.MicrochipNumber = newMicrochipNumber;

    Console.WriteLine("Enter the new bark volume for the dog:");
    string newBarkVolume = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(newBarkVolume))
    {
        while (string.IsNullOrWhiteSpace(newBarkVolume))
        {
            Console.WriteLine("The bark volume cannot be empty, please enter a valid bark volume");
            newBarkVolume = Console.ReadLine();
        }
    }
    

    dogToUpdate.BarkVolume = newBarkVolume;

    Console.WriteLine("Enter the new coat type for the dog:");
    Console.WriteLine(@"
            1. short
            2. medium
            3. long
            4. no hair
                        ");
        int choice2 = int.Parse(Console.ReadLine());
        string newCoatType = null;
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
                newCoatType = "short";
                break;
            case 2:
                newCoatType = "medium";
                break;
            case 3:
                newCoatType = "long";
                break;
            case 4:
                newCoatType = "no hair";
                break;
        }

    dogToUpdate.CoatType = newCoatType;

    Console.WriteLine("The dog has been successfully updated");

    }

    public void showALlDogs()
    {
        foreach (var dog in Dogs)
        {
            dog.ShowInfo();
        }
    }
    
}
