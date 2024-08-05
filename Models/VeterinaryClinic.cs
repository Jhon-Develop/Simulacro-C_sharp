using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models
{
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
    public class VeterinaryClinic
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Cat> Cats { get; set; }

        public VeterinaryClinic(string name, string address, List<Dog> dogs, List<Cat> cats)
        {
            Name = name;
            Address = address;
            Dogs = dogs;
            Cats = cats;
        }

        public VeterinaryClinic(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void SaveDog(Dog newdog)
        {
            var SaveDog = ManagerApp.CreateDog();
            Dogs.Add(SaveDog);
            Console.WriteLine("");
            Console.WriteLine("Perro agregado con éxito!");
            Console.WriteLine("");
        }
        public void SaveCat(Cat newcat)
        {
            var SaveCat = ManagerApp.CreateCat();
            Cats.Add(SaveCat);
            Console.WriteLine("");
            Console.WriteLine("Gato agregado con éxito!");
            Console.WriteLine("");
        }

        public void UpdateDog(string name, DateOnly birthDate)
        {
            Dog? dog = Dogs.Find(dog => dog.GetName() == name && dog.GetBirthDate() == birthDate);
            if (dog != null)
            {
                string newName = Setting.InputString("Ingrese el nombre del perro o enter para dejarlo igual => ");
                DateOnly newBirthDate = Setting.InputDateOnly("Ingrese la fecha de nacimiento del perro o enter para dejarlo igual => ");
                string newBreed = Setting.InputString("Ingrese la raza del perro o enter para dejarlo igual => ");
                string newColor = Setting.InputString("Ingrese el color del perro o enter para dejarlo igual => ");
                double newWeightInKg = Setting.InputDouble("Ingrese el peso en kilogramos del perro o 0 para dejarlo igual => ");
                bool newBreedingStatus = Setting.InputBool("Ingrese si el perro esta castrado (Y / N) o enter para dejarlo igual => ");
                string newTemperament = Setting.InputString("Ingrese el temperamento del perro o enter para dejarlo igual => ");
                string newMicroChipNumber = Setting.InputString("Ingrese el numero de microchip del perro o enter para dejarlo igual => ");
                string newBarkVolume = Setting.InputString("Ingrese el volumen del corteza del perro o enter para dejarlo igual => ");
                string newCoatType = Setting.InputString("Ingrese el tipo de capa del perro o enter para dejarlo igual => ");

                dog.SetName(string.IsNullOrEmpty(newName) ? dog.GetName() : newName);
                dog.SetBirthDate(newBirthDate == default ? dog.GetBirthDate() : newBirthDate);
                dog.SetBreed(string.IsNullOrEmpty(newBreed) ? dog.GetBreed() : newBreed);
                dog.SetColor(string.IsNullOrEmpty(newColor) ? dog.GetColor() : newColor);
                dog.SetWeightInKg(newWeightInKg == 0 ? dog.GetWeightInKg() : newWeightInKg);
                dog.BreedingStatus = string.IsNullOrEmpty(Setting.InputBool(newBreedingStatus)) ? dog.BreedingStatus : newBreedingStatus;
                dog.Temperament = string.IsNullOrEmpty(newTemperament) ? dog.Temperament : newTemperament;
                dog.MicroChipNumber = string.IsNullOrEmpty(newMicroChipNumber) ? dog.MicroChipNumber : newMicroChipNumber;
                dog.BarkVolume = string.IsNullOrEmpty(newBarkVolume) ? dog.BarkVolume : newBarkVolume;
                dog.CoatType = string.IsNullOrEmpty(newCoatType) ? dog.CoatType : newCoatType;

                Console.WriteLine("");
                Console.WriteLine("Datos actualizados con éxito!");
                Console.WriteLine("");
            }
        }

        public void UpdateCat(string name, DateOnly birthDate)
        {
            Cat? cat = Cats.Find(cat => cat.GetName() == name && cat.GetBirthDate() == birthDate);
            if (cat != null)
            {
                string newName = Setting.InputString("Ingrese el nombre del gato o enter para dejarlo igual => ");
                DateOnly newBirthDate = Setting.InputDateOnly("Ingrese la fecha de nacimiento del gato o enter para dejarlo igual => ");
                string newBreed = Setting.InputString("Ingrese la raza del gato o enter para dejarlo igual => ");
                string newColor = Setting.InputString("Ingrese el color del gato o enter para dejarlo igual => ");
                double newWeightInKg = Setting.InputDouble("Ingrese el peso en kilogramos del gato o 0 para dejarlo igual => ");
                bool newBreedingStatus = Setting.InputBool("Ingrese si el gato esta castrado (Y / N) o enter para dejarlo igual => ");
                string newFurLength = Setting.InputString("Ingrese la longitud del pelo del gato o enter para dejarlo igual => ");

                cat.SetName(string.IsNullOrEmpty(newName) ? cat.GetName() : newName);
                cat.SetBirthDate(newBirthDate == default ? cat.GetBirthDate() : newBirthDate);
                cat.SetBreed(string.IsNullOrEmpty(newBreed) ? cat.GetBreed() : newBreed);
                cat.SetColor(string.IsNullOrEmpty(newColor) ? cat.GetColor() : newColor);
                cat.SetWeightInKg(newWeightInKg == 0 ? cat.GetWeightInKg() : newWeightInKg);
                cat.BreedingStatus = string.IsNullOrEmpty(Setting.InputBool(newBreedingStatus)) ? cat.BreedingStatus : newBreedingStatus;
                cat.FurLength = string.IsNullOrEmpty(newFurLength) ? cat.FurLength : newFurLength;

                Console.WriteLine("");
                Console.WriteLine("Datos actualizados con éxito!");
                Console.WriteLine("");
            }
        }

        public void DeleteDog(int id)
        {
            Dog? dog = Dogs.Find(dog => dog.GetId() == id);
            if (dog != null)
            {
                Dogs.Remove(dog);
                Console.WriteLine("");
                Console.WriteLine("Perro eliminado con éxito!");
                Console.WriteLine("");
            }
        }
        
        public void DeleteCat(int id)
        {
            Cat? cat = Cats.Find(cat => cat.GetId() == id);
            if (cat != null)
            {
                Cats.Remove(cat);
                Console.WriteLine("");
                Console.WriteLine("Gato eliminado con éxito!");
                Console.WriteLine("");
            }
        }

        public void ShowAllPatients()
        {
            Console.WriteLine("Listado de perros:");
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"Id: {dog.GetId()} | Nombre: {dog.GetName()} | Fecha de nacimiento: {dog.GetBirthDate()} | Raza: {dog.GetBreed()} | Color: {dog.GetColor()} | Peso: {dog.GetWeightInKg()} | Estado de castrado: {dog.BreedingStatus} | Temperamento: {dog.Temperament} | Número de microchip: {dog.MicroChipNumber} | Volumen del corteza: {dog.BarkVolume} | Tipo de capa: {dog.CoatType}");
                Setting.LineSeparator('-');
            }
            Console.WriteLine("");
            Console.WriteLine("Listado de gatos:");
            foreach (Cat cat in Cats)
            {
                Console.WriteLine($"Id: {cat.GetId()} | Nombre: {cat.GetName()} | Fecha de nacimiento: {cat.GetBirthDate()} | Raza: {cat.GetBreed()} | Color: {cat.GetColor()} | Peso: {cat.GetWeightInKg()} | Estado de castrado: {cat.BreedingStatus} | Longitud del pelo: {cat.FurLength}");
                Setting.LineSeparator('-');
            }
            Console.WriteLine("");
        }

        public void ShowAnimals(string Type)
        {
            if (Type == "Dog")
            {
                Console.WriteLine("Listado de perros:");
                foreach (Dog dog in Dogs)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Id: {dog.GetId()} | Nombre: {dog.GetName()} | Fecha de nacimiento: {dog.GetBirthDate()} | Raza: {dog.GetBreed()} | Color: {dog.GetColor()} | Peso: {dog.GetWeightInKg()} | Estado de castrado: {dog.BreedingStatus} | Temperamento: {dog.Temperament} | Número de microchip: {dog.MicroChipNumber} | Volumen del corteza: {dog.BarkVolume} | Tipo de capa: {dog.CoatType}");
                    Setting.LineSeparator('-');
                }
            }
            else if (Type == "Cat")
            {
                Console.WriteLine("Listado de gatos:");
                foreach (Cat cat in Cats)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Id: {cat.GetId()} | Nombre: {cat.GetName()} | Fecha de nacimiento: {cat.GetBirthDate()} | Raza: {cat.GetBreed()} | Color: {cat.GetColor()} | Peso: {cat.GetWeightInKg()} | Estado de castrado: {cat.BreedingStatus} | Longitud del pelo: {cat.FurLength}");
                    Setting.LineSeparator('-');
                }
            }
        }

        public void ShowPatient(int idPatient)
        { 
            Dog? dog = Dogs.Find(dog => dog.GetId() == idPatient);
            if (dog != null)
            {
                Console.WriteLine("");
                Console.WriteLine($"Id: {dog.GetId()} | Nombre: {dog.GetName()} | Fecha de nacimiento: {dog.GetBirthDate()} | Raza: {dog.GetBreed()} | Color: {dog.GetColor()} | Peso: {dog.GetWeightInKg()} | Estado de castrado: {dog.BreedingStatus} | Temperamento: {dog.Temperament} | Número de microchip: {dog.MicroChipNumber} | Volumen del corteza: {dog.BarkVolume} | Tipo de capa: {dog.CoatType}");
                Setting.LineSeparator('-');
            }
            Cat? cat = Cats.Find(cat => cat.GetId() == idPatient); if (cat != null)
            {
                Console.WriteLine("");
                Console.WriteLine($"Id: {cat.GetId()} | Nombre: {cat.GetName()} | Fecha de nacimiento: {cat.GetBirthDate()} | Raza: {cat.GetBreed()} | Color: {cat.GetColor()} | Peso: {cat.GetWeightInKg()} | Estado de castrado: {cat.BreedingStatus} | Longitud del pelo: {cat.FurLength}");
                Setting.LineSeparator('-');
            }
        }
    }
}