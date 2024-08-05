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

    if (!string.IsNullOrWhiteSpace(newName))
    {
        dogToUpdate.Name = newName;
    }
}
