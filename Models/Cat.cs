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

        public void CastreAnimal()
        {
            if (BreedingStatus == false)
            {
                Console.WriteLine("El animal esta castrado no puede volver  ser castrado.");
            }
            else if (BreedingStatus == true)
            {
                BreedingStatus = false;
                Console.WriteLine("El animal ha sido castrado.");
            }
        }
        public void HairDress()
        {
            FurLength = "short";
        }
    }
}