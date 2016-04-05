using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        public List<Animal> animals = new List<Animal>();
        
        public void Add(Animal animal)
        {
            
            if (AlreadyInSystem(animal.ChipRegistrationNumber))
            {
                throw new DuplicateWaitObjectException();
            }
            else
            {
                animals.Add(animal);
            }
        }

        public void RemoveAnimal(int chipRegistrationNumber)
        {
            Animal deleteAnimal = FindAnimal(chipRegistrationNumber);
            
            if (deleteAnimal == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                animals.Remove(deleteAnimal);
            }
        }

        public Animal FindAnimal(int chipRegistrationNumber)
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

        public bool AlreadyInSystem(int chipRegistrationNumber)
        {
            if(FindAnimal(chipRegistrationNumber) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Change(Animal animal)
        {
            RemoveAnimal(animal.ChipRegistrationNumber);
            Add(animal);
        }
        
    }
}
