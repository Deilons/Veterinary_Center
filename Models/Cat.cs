using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models;

public class Cat : Animal
{

    // properties
    public bool BreedingStatus { get; set; }
    public string FurLength { get; set; }

    // constructor

    public Cat(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool isCastrated, bool breedingStatus, string furLength) : base(id, name, birthDate, breed, color, weightInKg, isCastrated)
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
    public void BasicReview()
    {   
        if (this.BreedingStatus == true)
        {
            Console.WriteLine("The cat is healthy");
        }
        else
        {
            Console.WriteLine("The cat is not healthy");
        }
    }

    public void Hairdress()
    {
        if (FurLength == "short" || FurLength == "no hair")
        {
            Console.WriteLine("The cat does not have enough hair to be hairdressed");
        }
        else
        {
            Console.WriteLine("Hairdress successfully");
            FurLength = "Corto";
        }
    }
}
