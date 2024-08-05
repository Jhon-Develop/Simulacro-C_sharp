using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models
{
    public class Dog(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool breedingStatus, string temperament, string microChipNumber, string barkVolume, string coatType) : Animal(id, name, birthDate, breed, color, weightInKg)
    {
        public bool BreedingStatus {get; set;} = breedingStatus;
        public string Temperament {get; set;} = temperament;
        public string MicroChipNumber {get; set;} = microChipNumber;
        public string BarkVolume {get; set;} = barkVolume;
        public string CoatType {get; set;} = coatType;

        public void CastreAnimal(string name, bool birthingStatus)
        {
            Dog? dog = VeterinaryClinic.Dogs.Find(dog => dog.GetName() == name && dog.BreedingStatus == birthingStatus);
            if (dog == null)
            {
                Console.WriteLine("No se encontro el perro.");
            }
            else
            {
                if (dog.BreedingStatus == false)
                {
                    Console.WriteLine("El perro esta castrado no puede volver  ser castrado.");
                }
                else if (dog.BreedingStatus == true)
                {
                    dog.BreedingStatus = false;
                    Console.WriteLine("El perro ha sido castrado.");
                }
            }
        }
        public void HairDress(string name, string coatType)
        {
            Dog? dog = VeterinaryClinic.Dogs.Find(dog => dog.GetName() == name && dog.CoatType == coatType);
            if (dog == null)
            {
                Console.WriteLine("No se encontro el perro.");
            }
            else if (coatType == "sin pelo")
            {
                dog.CoatType = "sin pelo";
                Console.WriteLine("El perro no tiene pelo por lo tanto no se le puede ingrear a la peluqueria.");
            }
            else if (coatType == "pelo corto")
            {
                dog.CoatType = "pelo corto";
                Console.WriteLine("Bienvenido a la pelucqueria, en 1 hora estara listo su perro.");
            }
            else
            {
                dog.CoatType = "pelo corto";
                Console.WriteLine("El perro puede ingresar a la peluqueria.");
            }
        }
    }
}