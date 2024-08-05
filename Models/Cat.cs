using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models
{
    public class Cat(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg, bool breedingStatus, string furLength) : Animal(id, name, birthDate, breed, color, weightInKg)
    {
        public bool BreedingStatus { get; set; } = breedingStatus;
        public string FurLength { get; set; } = furLength;

        public void CastreAnimal(string name, bool birthingStatus)
        {
            Cat? cat = VeterinaryClinic.Cats.Find(cat => cat.GetName() == name && cat.BreedingStatus == birthingStatus);
            if (cat == null)
            {
                Console.WriteLine("No se encontro el gato.");
            }
            else
            {
                if (cat.BreedingStatus == false)
                {
                    Console.WriteLine("El gato esta castrado no puede volver  ser castrado.");
                }
                else if (cat.BreedingStatus == true)
                {
                    cat.BreedingStatus = false;
                    Console.WriteLine("El gato ha sido castrado.");
                }
            }
        }
        public void HairDress(string name, string furLength)
        {
            Cat? cat = VeterinaryClinic.Cats.Find(cat => cat.GetName() == name && cat.FurLength == furLength);
            if (cat == null)
            {
                Console.WriteLine("No se encontro el gato.");
            }
            else if (furLength == "sin pelo")
            {

                Console.WriteLine("El gato no tiene pelo por lo tanto no se le puede ingrear a la peluqueria.");
            }
            else if (furLength == "pelo corto")
            {
                Console.WriteLine("El gato tiene el pelo corto, no se le puede ingrear a la peluqueria es mejor dejar que le crezca un poco mas.");
            }
            else
            {
                cat.FurLength = "pelo corto";
                Console.WriteLine("Bienvenido a la pelucqueria, en 1 hora estara listo su gato.");
            }
        }
    }
}