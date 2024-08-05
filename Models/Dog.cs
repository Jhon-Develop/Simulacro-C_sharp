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

        public void CastreAnimal()
        {
            BreedingStatus = false;
        }
        public void HairDress()
        {
            CoatType = "Groomed";
        }
    }
}