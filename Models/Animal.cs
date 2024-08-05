using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinary_Center.Models
{
    public class Animal(int id, string name, DateOnly birthDate, string breed, string color, double weightInKg)
    {
#pragma warning disable CS9124 // El parámetro se captura en el estado del tipo envolvente y su valor también se usa para inicializar un campo, propiedad o evento.
        protected int Id { get; set; } = id;
        protected string Name { get; set; } = name;
        protected DateOnly BirthDate { get; set; } = birthDate;
        protected string Breed { get; set; } = breed;
        protected string Color { get; set; } = color;
        protected double WeightInKg { get; set; } = weightInKg;

        // get property
        public int GetId() => Id;
        public string GetName() => Name;
        public DateOnly GetBirthDate() => BirthDate;
        public string GetBreed() => Breed;
        public string GetColor() => Color;
        public double GetWeightInKg() => WeightInKg;

        // set property
        public int SetId(int id) => Id = id;
        public string SetName(string name) => Name = name;
        public DateOnly SetBirthDate(DateOnly birthDate) => BirthDate = birthDate;
        public string SetBreed(string breed) => Breed = breed;
        public string SetColor(string color) => Color = color;
        public double SetWeightInKg(double weightInKg) => WeightInKg = weightInKg;

        public void ShowInformation()
        {
            Console.WriteLine(@$"
            Id : {id}
            Name : {name}
            BirthDate : {birthDate}
            Breed : {breed}
            Color : {color}
            WeightInKg : {weightInKg}
            ");
        }
        protected void BasicReview()
        {
            Console.WriteLine($"The animal is {name} and is {weightInKg} kg.");
        }
        protected int CalculateAgeInMonths()
        {
            var today = DateOnly.FromDateTime(DateTime.Now);
            var year = today.Year;
            var month = today.Month;
            var birthYear = BirthDate.Year;
            var birthMonth = BirthDate.Month;
            var age = (year - birthYear) * 12 + (month - birthMonth);
            return age; 
        }
    }
}