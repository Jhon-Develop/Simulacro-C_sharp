using Veterinary_Center.Models;

namespace Veterinary_Center;

class Program
{
    static void Main(string[] args)
    {
        VeterinaryClinic veterinaria = new("Veterinary Center", "Av. de la República, 100, Barcelona, Spain");
        bool menuOpen = true;
        while (menuOpen)
        {
            Console.WriteLine($"{Setting.Header("Bienvenido a Veterinary Center")}");
            Console.WriteLine(@"
            1. Perros.
            2. Gatos.
            3. Ver animales.
            4. Salir.
            ");
            int option = Setting.InputInt("Elige una opción => ");
            switch (option)
            {
                case 1:
                    Console.WriteLine($"{Setting.Header("Perros")}");
                    Console.WriteLine(@"
                    1. Agregar Perro.
                    2. Eliminar Perro.
                    3. Actualizar Perro.
                    4. Salir.
                    ");
                    int optionDogs = Setting.InputInt("Elige una opción => ");
                    switch (optionDogs)
                    {
                        case 1:
                            Console.WriteLine($"{Setting.Header("Agregar Perro")}");
                            veterinaria.SaveDog();
                            Setting.FinishOption();
                            break;
                        case 2:
                            Console.WriteLine($"{Setting.Header("Eliminar Perro")}");
                            int idDog = Setting.InputInt("Ingrese el ID del Perro => ");
                            veterinaria.DeleteDog(idDog);
                            Setting.FinishOption();
                            break;
                        case 3:
                            Console.WriteLine($"{Setting.Header("Actualizar Perro")}");
                            string dogName = Setting.InputString("Ingrese el nombre del Perro => ");
                            DateOnly dogBirthDate = Setting.InputDateOnly("Ingrese la fecha de nacimiento del Perro => ");
                            veterinaria.UpdateDog(dogName, dogBirthDate);
                            Setting.FinishOption();
                            break;
                        case 4:
                            menuOpen = false;
                            break;
                        default:
                            Console.WriteLine($"{Setting.Error("Opción no válida.")}");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine($"{Setting.Header("Gatos")}");
                    Console.WriteLine(@"
                    1. Agregar Gato.
                    2. Eliminar Gato.
                    3. Actualizar Gato.
                    4. Salir.
                    ");
                    int optionCats = Setting.InputInt("Elige una opción => ");
                    switch (optionCats)
                    {
                        case 1:
                            Console.WriteLine($"{Setting.Header("Agregar Gato")}");
                            veterinaria.SaveCat();
                            Setting.FinishOption();
                            break;
                        case 2:
                            Console.WriteLine($"{Setting.Header("Eliminar Gato")}");
                            int idCat = Setting.InputInt("Ingrese el ID del Gato => ");
                            veterinaria.DeleteCat(idCat);
                            Setting.FinishOption();
                            break;
                        case 3:
                            Console.WriteLine($"{Setting.Header("Actualizar Gato")}");
                            string catName = Setting.InputString("Ingrese el nombre del Gato => ");
                            DateOnly catBirthDate = Setting.InputDateOnly("Ingrese la fecha de nacimiento del Gato => ");
                            veterinaria.UpdateCat(catName, catBirthDate);
                            Setting.FinishOption();
                            break;
                        case 4:
                            menuOpen = false;
                            break;
                        default:
                            Console.WriteLine($"{Setting.Error("Opción no válida.")}");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine($"{Setting.Header("Ver Animales")}");
                    Console.WriteLine(@"
                    1. Ver Todos los Animales.
                    2. Ver por raza.
                    3. Salir.
                    ");
                    int optionShowAnimals = Setting.InputInt("Elige una opción => ");
                    switch (optionShowAnimals)
                    {
                        case 1:
                            Console.WriteLine($"{Setting.Header("Ver Todos los Animales")}");
                            veterinaria.ShowAllPatients();
                            Setting.FinishOption();
                            break;
                        case 2:
                            Console.WriteLine($"{Setting.Header("Ver Animales Por Raza")}");
                            string type = Setting.InputString("Ingrese la raza del animal => ");
                            veterinaria.ShowAnimals(type);
                            Setting.FinishOption();
                            break;
                        case 3: 
                            Console.WriteLine($"{Setting.Header("Ver Animales Por Id")}");
                            string searchtype = Setting.InputString("Ingrese el tipo del animal (Dog, Cat) => ");
                            int id = Setting.InputInt("Ingrese el id del animal => ");
                            veterinaria.ShowPatient(id, searchtype);
                            Setting.FinishOption();
                            break;
                        case 4:
                            menuOpen = false;
                            break;
                        default:
                            Console.WriteLine($"{Setting.Error("Opción no válida.")}");
                            break;
                    }
                    break;
                case 4:
                    menuOpen = false;
                    break;
                default:
                    Console.WriteLine($"{Setting.Error("Opción no válida.")}");
                    break;

            }
        }
    }
}
