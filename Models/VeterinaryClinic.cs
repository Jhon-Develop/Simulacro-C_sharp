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
        public List<Dog> Dogs { get; set; } = [];
        public List<Cat> Cats { get; set; } = [];

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
        public void SaveDog()
        {
            var SaveDog = ManagerApp.CreateDog();

            Dogs.Add(SaveDog);
            Console.WriteLine("");
            Console.WriteLine("Perro agregado con éxito!");
            Console.WriteLine("");
        }
        public void SaveCat()
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
                DateOnly newBirthDate;
                do
                {
                    newBirthDate = Setting.InputDateOnly("Ingresa la fecha de nacimiento de tu perro (YYYY-MM-DD) o enter para dejarlo igual => ");
                    if (newBirthDate > DateOnly.FromDateTime(DateTime.Now))
                    {
                        Console.WriteLine("La fecha de nacimiento no puede ser mayor a la fecha actual.");
                    }
                } while (newBirthDate > DateOnly.FromDateTime(DateTime.Now));
                string newBreed = Setting.InputString("Ingrese la raza del perro o enter para dejarlo igual => ");
                string newColor = Setting.InputString("Ingrese el color del perro o enter para dejarlo igual => ");
                double newWeightInKg = Setting.InputDouble("Ingrese el peso en kilogramos del perro o 0 para dejarlo igual => ");
                bool newBreedingStatus;
                do
                {
                    newBreedingStatus = Setting.InputBoolean("Ingresa si tu perro esta castrado (true/false) o enter para dejarlo igual => ");
                    if (newBreedingStatus != true && newBreedingStatus != false)
                    {
                        Console.WriteLine("Estado de castrado inválido. Intenta de nuevo.");
                    }
                } while (newBreedingStatus != true && newBreedingStatus != false);
                string newTemperament;
                do
                {
                    newTemperament = Setting.InputString("Ingresa el temperamento de tu perro (Timido, Normal, Agresivo) o enter para dejarlo igual => ").ToLower();
                    if (newTemperament != "timido" && newTemperament != "normal" && newTemperament != "agresivo")
                    {
                        Console.WriteLine("Temperamento inválido. Intenta de nuevo.");
                    }
                } while (newTemperament != "timido" && newTemperament != "normal" && newTemperament != "agresivo");
                string newMicroChipNumber = Setting.InputString("Ingrese el numero de microchip del perro o enter para dejarlo igual => ");
                string newBarkVolume;
                do
                {
                    newBarkVolume = Setting.InputString("Ingresa el volumen de ladrido de tu perro (bajo, media, alto) o enter para dejarlo igual => ").ToLower();
                    if (newBarkVolume != "bajo" && newBarkVolume != "media" && newBarkVolume != "alto")
                    {
                        Console.WriteLine("Volumen de ladrido inválido. Intenta de nuevo.");
                    }
                } while (newBarkVolume != "bajo" && newBarkVolume != "media" && newBarkVolume != "alto");
                string newCoatType;
                do
                {
                    newCoatType = Setting.InputString("Ingresa el tipo de capa de tu perro (sin pelo, pelo corto, pelo mediano, pelo largo) o enter para dejarlo igual => ").ToLower();
                    if (newCoatType != "sin pelo" && newCoatType != "pelo corto" && newCoatType != "pelo mediano" && newCoatType != "pelo largo")
                    {
                        Console.WriteLine("Tipo de capa inválido. Intenta de nuevo.");
                    }
                } while (newCoatType != "sin pelo" && newCoatType != "pelo corto" && newCoatType != "pelo mediano" && newCoatType != "pelo largo");

                dog.SetName(string.IsNullOrEmpty(newName) ? dog.GetName() : newName);
                dog.SetBirthDate(newBirthDate == default ? dog.GetBirthDate() : newBirthDate);
                dog.SetBreed(string.IsNullOrEmpty(newBreed) ? dog.GetBreed() : newBreed);
                dog.SetColor(string.IsNullOrEmpty(newColor) ? dog.GetColor() : newColor);
                dog.SetWeightInKg(newWeightInKg == 0 ? dog.GetWeightInKg() : newWeightInKg);
                dog.BreedingStatus = string.IsNullOrEmpty(newBreedingStatus.ToString()) ? dog.BreedingStatus : newBreedingStatus;
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
                DateOnly newBirthDate;
                do
                {
                    newBirthDate = Setting.InputDateOnly("Ingresa la fecha de nacimiento de tu gato (YYYY-MM-DD) o enter para dejarlo igual => ");
                    if (newBirthDate > DateOnly.FromDateTime(DateTime.Now))
                    {
                        Console.WriteLine("La fecha de nacimiento no puede ser mayor a la fecha actual.");
                    }
                } while (newBirthDate > DateOnly.FromDateTime(DateTime.Now));
                string newBreed = Setting.InputString("Ingrese la raza del gato o enter para dejarlo igual => ");
                string newColor = Setting.InputString("Ingrese el color del gato o enter para dejarlo igual => ");
                double newWeightInKg = Setting.InputDouble("Ingrese el peso en kilogramos del gato o 0 para dejarlo igual => ");
                bool newBreedingStatus = Setting.InputBoolean("Ingresa si tu gato esta castrado (Y / F) o enter para dejarlo igual => ");
                string newFurLength;
                do
                {
                    newFurLength = Setting.InputString("Ingresa el tipo de capa de tu perro (sin pelo, pelo corto, pelo mediano, pelo largo) o enter para dejarlo igual => ").ToLower();
                    if (newFurLength != "sin pelo" && newFurLength != "pelo corto" && newFurLength != "pelo mediano" && newFurLength != "pelo largo")
                    {
                        Console.WriteLine("Tipo de capa inválido. Intenta de nuevo.");
                    }
                } while (newFurLength != "sin pelo" && newFurLength != "pelo corto" && newFurLength != "pelo mediano" && newFurLength != "pelo largo");

                cat.SetName(string.IsNullOrEmpty(newName) ? cat.GetName() : newName);
                cat.SetBirthDate(newBirthDate == default ? cat.GetBirthDate() : newBirthDate);
                cat.SetBreed(string.IsNullOrEmpty(newBreed) ? cat.GetBreed() : newBreed);
                cat.SetColor(string.IsNullOrEmpty(newColor) ? cat.GetColor() : newColor);
                cat.SetWeightInKg(newWeightInKg == 0 ? cat.GetWeightInKg() : newWeightInKg);
                cat.BreedingStatus = string.IsNullOrEmpty(newBreedingStatus.ToString()) ? cat.BreedingStatus : newBreedingStatus;
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

        public void ShowPatient(int idPatient, string type)
        {
            if (type == "Dog")
            {
                Dog? dog = Dogs.Find(dog => dog.GetId() == idPatient);
                if (dog != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Id: {dog.GetId()} | Nombre: {dog.GetName()} | Fecha de nacimiento: {dog.GetBirthDate()} | Raza: {dog.GetBreed()} | Color: {dog.GetColor()} | Peso: {dog.GetWeightInKg()} | Estado de castrado: {dog.BreedingStatus} | Temperamento: {dog.Temperament} | Número de microchip: {dog.MicroChipNumber} | Volumen del corteza: {dog.BarkVolume} | Tipo de capa: {dog.CoatType}");
                    Setting.LineSeparator('-');
                }
            }
            if (type == "Cat")
            {
                Cat? cat = Cats.Find(cat => cat.GetId() == idPatient);
                if (cat != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Id: {cat.GetId()} | Nombre: {cat.GetName()} | Fecha de nacimiento: {cat.GetBirthDate()} | Raza: {cat.GetBreed()} | Color: {cat.GetColor()} | Peso: {cat.GetWeightInKg()} | Estado de castrado: {cat.BreedingStatus} | Longitud del pelo: {cat.FurLength}");
                    Setting.LineSeparator('-');
                }
            }
        }
    }
}