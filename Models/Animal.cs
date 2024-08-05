using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models;

public abstract class Animal
{   
    // properties

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

    // methods

    public abstract void ShowInfo();

    protected virtual void BasicReview()
    {
        Console.WriteLine("Animal basic review");
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

    // methods to modify attributes

    public void CastrateAnimal()
    {
        IsCastrated = true;
    }

    public int GetId()
    {
        return Id;
    }

    public string GetName()
    {
        return Name;
    }

    public DateOnly GetBirthDate()
    {
        return BirthDate;
    }

    public string GetBreed()
    {
        return Breed;
    }

    public string GetColor()
    {
        return Color;
    }

    public double GetWeightInKg()
    {
        return WeightInKg;
    }

    public bool GetIsCastrated()
    {
        return IsCastrated;
    }

    public void SetId(int id)
    {
        Id = id;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetBirthDate(DateOnly birthDate)
    {
        BirthDate = birthDate;
    }

    public void SetBreed(string breed)
    {
        Breed = breed;
    }

    public void SetColor(string color)
    {
        Color = color;
    }

    public void SetWeightInKg(double weightInKg)
    {
        WeightInKg = weightInKg;
    }

    public void SetIsCastrated(bool isCastrated)
    {
        IsCastrated = isCastrated;
    }

}
