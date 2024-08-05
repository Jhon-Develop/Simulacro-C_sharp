using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models
{
    public class ManagerApp
    {
        private static int CurrentId = 1;
        public static Dog CreateDog()
        {
            int newId = CurrentId++;
            string newName = Setting.InputString("Ingresa el nombre de tu perro => ");
            DateOnly newBirthDate;
            do
            {
                newBirthDate = Setting.InputDateOnly("Ingresa la fecha de nacimiento de tu perro (YYYY-MM-DD) => ");
                if (newBirthDate > DateOnly.FromDateTime(DateTime.Now))
                {
                    Console.WriteLine("La fecha de nacimiento no puede ser mayor a la fecha actual.");
                }
            } while (newBirthDate > DateOnly.FromDateTime(DateTime.Now));
            string newBreed = Setting.InputString("Ingresa la raza de tu perro => ");
            string newColor = Setting.InputString("Ingresa el color de tu perro => ");
            double newWeightInKg = Setting.InputDouble("Ingresa el peso en kilogramos de tu perro => ");
            bool newBreedingStatus = Setting.InputBoolean("Ingresa si tu perrro esta castrado (Y / F) => ");
            string newTemperament;
            do
            {
                newTemperament = Setting.InputString("Ingresa el temperamento de tu perro (Timido, Normal, Agresivo) => ").ToLower();
                if (newTemperament != "timido" && newTemperament != "normal" && newTemperament != "agresivo")
                {
                    Console.WriteLine("Temperamento inválido. Intenta de nuevo.");
                }
            } while (newTemperament != "timido" && newTemperament != "normal" && newTemperament != "agresivo");
            string newMicroChipNumber = Setting.InputString("Ingresa el numero de microchip de tu perro => ");
            string newBarkVolume;
            do
            {
                newBarkVolume = Setting.InputString("Ingresa el volumen de ladrido de tu perro (bajo, media, alto) => ").ToLower();
                if (newBarkVolume != "bajo" && newBarkVolume != "media" && newBarkVolume != "alto")
                {
                    Console.WriteLine("Volumen de ladrido inválido. Intenta de nuevo.");
                }
            } while (newBarkVolume != "bajo" && newBarkVolume != "media" && newBarkVolume != "alto");
            string newCoatType;
            do
            {
                newCoatType = Setting.InputString("Ingresa el tipo de capa de tu perro (sin pelo, pelo corto, pelo mediano, pelo largo) => ").ToLower();
                if (newCoatType != "sin pelo" && newCoatType != "pelo corto" && newCoatType != "pelo mediano" && newCoatType != "pelo largo")
                {
                    Console.WriteLine("Tipo de capa inválido. Intenta de nuevo.");
                }
            } while (newCoatType != "sin pelo" && newCoatType != "pelo corto" && newCoatType != "pelo mediano" && newCoatType != "pelo largo");
            
            var newdog = new Dog(newId, newName, newBirthDate, newBreed, newColor, newWeightInKg, newBreedingStatus, newTemperament, newMicroChipNumber, newBarkVolume, newCoatType);
            return newdog;
        }

        public static Cat CreateCat()
        {
            int newId = CurrentId++;
            string newName = Setting.InputString("Ingresa el nobre de tu gato => ");
            DateOnly newBirthDate;
            do
            {
                newBirthDate = Setting.InputDateOnly("Ingresa la fecha de nacimiento de tu gato (YYYY-MM-DD) => ");
                if (newBirthDate > DateOnly.FromDateTime(DateTime.Now))
                {
                    Console.WriteLine("La fecha de nacimiento no puede ser mayor a la fecha actual.");
                }
            } while (newBirthDate > DateOnly.FromDateTime(DateTime.Now));
            string newBreed = Setting.InputString("Ingresa la raza de tu gato => ");
            string newColor = Setting.InputString("Ingresa el color de tu gato => ");
            double newWeightInKg = Setting.InputDouble("Ingresa el peso en kilogramos de tu gato => ");
            bool newBreedingStatus;
            do
            {
                newBreedingStatus = Setting.InputBoolean("Ingresa si tu gato esta castrado (true/false) => ");
                if (newBreedingStatus != true && newBreedingStatus != false)
                {
                    Console.WriteLine("Estado de castrado inválido. Intenta de nuevo.");
                }
            } while (newBreedingStatus != true && newBreedingStatus != false);
            string newFurLength;
            do
            {
                newFurLength = Setting.InputString("Ingresa el tipo de capa de tu perro (sin pelo, pelo corto, pelo mediano, pelo largo) => ").ToLower();
                if (newFurLength != "sin pelo" && newFurLength != "pelo corto" && newFurLength != "pelo mediano" && newFurLength != "pelo largo")
                {
                    Console.WriteLine("Tipo de capa inválido. Intenta de nuevo.");
                }
            } while (newFurLength != "sin pelo" && newFurLength != "pelo corto" && newFurLength != "pelo mediano" && newFurLength != "pelo largo");

            var newCat = new Cat(newId, newName, newBirthDate, newBreed, newColor, newWeightInKg, newBreedingStatus, newFurLength);
            return newCat;
        }

    }
}