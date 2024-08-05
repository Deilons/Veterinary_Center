using Veterinary_Center.Models;

Console.Clear();
var veterinaryClinic = new VeterinaryClinic( "Vet Clinic", "123 Main Street");

veterinaryClinic.SaveDog(ManagerApp.CreateDog());

veterinaryClinic.showALlDogs();

veterinaryClinic.UpdateDog();

veterinaryClinic.showALlDogs();


