using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        public List<Animal> animals = new List<Animal>();

        public Administration()
        {
        }

        public bool Add(Animal animal)
        {
            bool added = false;
            animals.Add(animal);

            foreach(Animal diertje in animals){
                if (diertje.ToString() == animal.ToString())
                {
                    added = true;
                }
            }
            return added;
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            bool removed = false;
            int x = 0;
            
            foreach (Animal diertje in animals)
            {
                if (diertje.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    animals.RemoveAt(x);
                    removed = true;
                    return removed;
                }
                x++;
            }
            return removed;
        }

        public Animal findAnimal(int chipRegistrationNumber)
        {
            Animal animal = null;
            foreach (Animal diertje in animals)
            {
                if (diertje.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    animal = diertje;
                    return animal;
                }
            }
            return animal;
        }

        public bool alreadyInSystem(int chipRegistrationNumber)
        {
            bool inSystem = false;

            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    inSystem = true;
                }
            }
            return inSystem;
        }

        public void Change(Animal animal)
        {
            RemoveAnimal(animal.ChipRegistrationNumber);
            Add(animal);
        }

        public void makeRandomAnimals()
        {
            string[] namenHond = {"Bello","Toby","Kevin","Laika"};
            string[] namenKat = { "Poes", "Thor", "KittyCat" };
            string[] badHabits = { "Niks","Is erg bazig","Valt andere katten aan","Kan slecht alleen zijn","Niet geschikt voor kinderen","Atilla the Hun incarnated"};
            Random random = new Random();
            Cat cat;
            Dog dog;
            Animal animal;
            SimpleDate geboortedatum;
            int chipnummer;
            int day;
            int month;
            int year;
            string naam;
            string badhabits;
            SimpleDate uitlaten;

            //Cats
            for (int x = 0; x < 3; x++)
            {
                naam = namenKat[random.Next(namenKat.Length)];
                chipnummer = random.Next(1,9999);
                day = random.Next(1,28);
                month = random.Next(1,12);
                year = random.Next(1990, DateTime.Now.Year);
                geboortedatum = new SimpleDate(day,month,year);
                badhabits = badHabits[random.Next(badHabits.Length)];

                cat = new Cat(chipnummer, geboortedatum, naam, badhabits);
                animal = cat;
                if (random.Next(0, 1) == 1)
                {
                    animal.IsReserved = true;
                }
                else
                {
                    animal.IsReserved = false;
                }
                Add(animal);
            }
            //Dogs
            for (int x = 0; x < 3; x++)
            {
                naam = namenHond[random.Next(namenHond.Length)];
                chipnummer = random.Next(1, 9999);
                day = random.Next(1, 28);
                month = random.Next(1, 12);
                year = random.Next(1990, DateTime.Now.Year);
                geboortedatum = new SimpleDate(day, month, year);
                day = random.Next(geboortedatum.Day, 28);
                month = random.Next(geboortedatum.Month, 12);
                year = random.Next(geboortedatum.Year, DateTime.Now.Year);
                uitlaten = new SimpleDate(day,month,year);

                dog = new Dog(chipnummer, geboortedatum, naam, uitlaten);
                animal = dog;
                int randomnumber = random.Next(0, 2);
                if ( randomnumber== 1)
                {
                    animal.IsReserved = true;
                }
                else if(randomnumber == 0)
                {
                    animal.IsReserved = false;
                }
                Add(animal);
            }
        }

    }
}
