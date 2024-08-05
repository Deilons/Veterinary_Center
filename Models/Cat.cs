using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models;

public class Cat : Animal
{   

    // properties
    public string BreedingStatus { get; set; }
    public string FurLength { get; set; }

    // constructor

    public Cat ( int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool isCastrated, string breedingStatus, string furLength) : base(id, name, birthDate, breed, color, weightInKg, isCastrated)
    {
        BreedingStatus = breedingStatus;
        FurLength = furLength;
    }

    // methods

    public override void ShowInfo()
    {
        Console.WriteLine($@"
        Id: {Id}
        Name: {Name}
        BirthDate: {BirthDate}
        Breed: {Breed}
        Color: {Color}
        WeightInKg: {WeightInKg}
        IsCastrated: {IsCastrated}
        BreedingStatus: {BreedingStatus}
        FurLength: {FurLength}
        ");
    }

    public void Hairdress()
    {
        /*
        Console.WriteLine("Enter the Id of the animal you want to hairdress");
        int AnimalId = int.Parse(Console.ReadLine());
        
        if (Id == AnimalId)
        {
            if (FurLength == "Corto" || FurLength == "Sin pelo")
            {
                Console.WriteLine("The animal does not have enough hair to be hairdressed");
            }
            else
            {
                Console.WriteLine("Animal hairdress successfully");
                FurLength = "Corto";
            }
        }
        */
    }
}
