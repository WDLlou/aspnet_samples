using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Course_App.Models
{
    public class AnimalDB
    {
        public static List<Animal> Animals = new List<Animal>()
        {
            new Animal() {Species = "Dog", NumberOfLegs = 4, Genus = "Canine"},
            new Animal() {Species = "Cat", NumberOfLegs = 4, Genus = "Feline"},
            new Animal() {Species = "Cow", NumberOfLegs = 4, Genus = "Bovine"},
            new Animal() {Species = "Bee", NumberOfLegs = 6, Genus = "Apis"},
            new Animal() {Species = "Spider", NumberOfLegs = 8, Genus = "Arachnid"},
            new Animal() {Species = "Wolf", NumberOfLegs = 4, Genus = "Canine"}
        };
    }
}