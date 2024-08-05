using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models
{
    public class ManagerApp
    {
        public static Dog CreateDog()
        {
            int newId = Setting.InputInt("Ingresa el id de tu perro => ");
            string newName = Setting.InputString("Ingresa el nobre de tu perro => ");
            DateOnly newBirthDate = Setting.InputDateOnly("Ingresa la fecha de nacimiento de tu perro => ");
            string newBreed = Setting.InputString("Ingresa la raza de tu perro => ");
            string newColor = Setting.InputString("Ingresa el color de tu perro => ");
            double newWeightInKg = Setting.InputDouble("Ingresa el pero en kilogramos de tu perro => ");
            bool newBreedingStatus = Setting.InputBool("Ingresa el estado de la crianza de tu perro => ");
            string newTemperament = Setting.InputString("Ingresa el temperamento de tu perro (Timido, Normal, Agresivo) => ");
            string newMicroChipNumber = Setting.InputString("Ingresa el numero de microchip de tu perro => ");
            string newBarkVolume = Setting.InputString("Ingresa el volumen del corteza de tu perro => ");
            string newCoatType = Setting.InputString("Ingresa el tipo de capa de tu perro (sin pelo, pelo corto, pelo mediano, pelo largo) => ");

            if(newTemperament == "Timido" || newTemperament == "Normal" || newTemperament == "Agresivo")
            {
                Console.WriteLine("Ingresa el temperamento de tu perro (Timido, Normal, Agresivo) => ");
                var newdog = new Dog(newId, newName, newBirthDate, newBreed, newColor, newWeightInKg, newBreedingStatus, newTemperament, newMicroChipNumber, newBarkVolume, newCoatType);
                return newdog;
            }
            else if (newCoatType == "sin pelo" || newCoatType == "pelo corto" || newCoatType == "pelo mediano" ||newCoatType == "pelo largo")
            {
                Console.WriteLine("Ingresa el tipo de pelo de tu perro (sin pelo, pelo corto, pelo mediano, pelo largo) => ");
                var newdog = new Dog(newId, newName, newBirthDate, newBreed, newColor, newWeightInKg, newBreedingStatus, newTemperament, newMicroChipNumber, newBarkVolume, newCoatType);
                return newdog;
            }
            else
            {
                Console.WriteLine("Datos incorrectos, por favor, vuelve a ingresar.");
                return CreateDog();
            }
        }

        public static Cat CreateCat()
        {
            int newId = Setting.InputInt("Ingresa el id de tu gato => ");
            string newName = Setting.InputString("Ingresa el nobre de tu gato => ");
            DateOnly newBirthDate = Setting.InputDateOnly("Ingresa la fecha de nacimiento de tu gato => ");
            string newBreed = Setting.InputString("Ingresa la raza de tu gato => ");
            string newColor = Setting.InputString("Ingresa el color de tu gato => ");
            double newWeightInKg = Setting.InputDouble("Ingresa el peso en kilogramos de tu gato => ");
            bool newBreedingStatus = Setting.InputBool("Ingresa si tu gato esta castrado (Y / N) => ");
            string newFurLength = Setting.InputString("Ingresa la longitud del pelo de tu gato => ");

            var newCat = new Cat(newId, newName, newBirthDate, newBreed, newColor, newWeightInKg, newBreedingStatus, newFurLength);
            return newCat;
        }

        /*
        Los metodos de ShowHeader, ShowFooter y ShowSeparator estan en la clase de setting 
        que es una clase totalmente estatica de referencia para hacer algunas cosas comunes.
        */
        
    }
}