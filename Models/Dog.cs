using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models;

public class Dog : Animal
{
    // properties


    public bool BreedingStatus { get; set; }

    public string Temperament { get; set; }

    public string MicrochipNumber { get; set; }

    public string BarkVolume { get; set; }

    public string CoatType { get; set; }


    // constructor 

    public Dog(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool isCastrated, bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) : base(id, name, birthDate, breed, color, weightInKg, isCastrated)
    {
        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolume = barkVolume;
        CoatType = coatType;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($@"
        Id: {Id}
        Name: {Name}
        BirthDate: {BirthDate}
        Breed: {Breed}
        Color: {Color}
        WeightInKg: {WeightInKg}
        Castrated: {IsCastrated}
        BreedingStatus: {BreedingStatus}
        Temperament: {Temperament}
        MicrochipNumber: {MicrochipNumber}
        BarkVolume: {BarkVolume}
        CoatType: {CoatType}
        ");
    }

    // methods

    public void Hairdress()
    {
        /*
            Console.WriteLine("Enter the Id of the animal you want to hairdress");
            int AnimalId = int.Parse(Console.ReadLine());

            if (Id == AnimalId)
            {
                if (CoatType == "short" || CoatType == "no hair")
                {
                    Console.WriteLine("The animal does not have enough hair to be hairdressed");
                }
                else
                {
                    Console.WriteLine("Animal hairdress successfully");
                    CoatType = "short";
                }
            }
        */
    }

}