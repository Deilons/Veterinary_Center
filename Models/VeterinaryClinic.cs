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

    public void UpdateDog(Dog dog)
    {
        Console.WriteLine("Enter the Id of the animal you want to update");
        int AnimalId = int.Parse(Console.ReadLine());
        
        if (dog.GetId() == AnimalId)
        {
            
        }
    }

}
