using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models;

public abstract class Animal
{   
    // attributes
    protected int Id { get; set; }
    protected string Name { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string Breed { get; set; }
    protected string Color { get; set; }
    protected double WeightInKg { get; set; }
    protected bool IsCastrated { get; set; }

    // constructor
    public Animal(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool isCastrated)
    {
        Id = id;
        Name = name;
        BirthDate = birthDate;
        Breed = breed;
        Color = color;
        WeightInKg = weightInKg;
        IsCastrated = isCastrated;
    }

    // properties

    public abstract void ShowInfo();

    protected void BasicReview()
    {
        Console.WriteLine($"idk");
    }

    protected int CalculateAgeInMonths()
    {
        int ageInMonths = DateTime.Now.Month - BirthDate.Month;
        if (DateTime.Now.Day < BirthDate.Day)
        {
            ageInMonths--;
        }
        return ageInMonths;
    }

    public void CastrateAnimal()
    {
        IsCastrated = true;
    }

    public string GetId()
    {
        return Id.ToString();
    }
}
