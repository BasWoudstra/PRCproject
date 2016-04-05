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
        
    }
}
