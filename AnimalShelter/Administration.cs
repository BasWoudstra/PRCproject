using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace AnimalShelter
{
    [Serializable]
    public class Administration
    {
        public List<Animal> animals;

        IFormatter formatter = new BinaryFormatter();

        public Administration()
        {
            animals = new List<Animal>();
        }
        
        public void Add(Animal animal)
        {
            
            if (FindAnimal(animal.ChipRegistrationNumber) != null)
            {
                 new DuplicateWaitObjectException();
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

        public void Change(Animal animal)
        {
            RemoveAnimal(animal.ChipRegistrationNumber);
            Add(animal);
        }

        /// <summary>
        /// Saves all animals to a file with the given file name using serialisation.
        /// </summary>
        /// <param name="fileName">The file to write to.</param>
        public void Save(string fileName)
        {
            using(FileStream stream = new FileStream(fileName,FileMode.Create,FileAccess.Write)){
               formatter.Serialize(stream, animals);
            }
            /*using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                foreach (Animal animal in animals)
                {
                    writer.Write(animal.ToString());
                    writer.Write("\r\n");
                }
            }*/
        }

        /// <summary>
        /// Loads all animals from a file with the given file name using deserialisation.
        /// All animals currently in the administration are removed.
        /// </summary>
        /// <param name="fileName">The file to read from.</param>
        public void Load(string fileName)
        {
            animals.Clear();

            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                animals = formatter.Deserialize(stream) as List<Animal>;
            }
        }
            /*
            string animalValues;

            string[] values = new string[5];
            string[] date = new string[4];

            if (File.Exists(fileName))
            {
                    using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                    {
                        animalValues = reader.ReadString();
                        values = animalValues.Split(',');
                        int chipRegistrationNumber = Convert.ToInt32(values[0].Substring(4));
                        date = values[1].Split('-');
                        int day = Convert.ToInt32(date[0]);
                        int month = Convert.ToInt32(date[1]);
                        int year = Convert.ToInt32(date[2]);
                        SimpleDate dateOfBirth = new SimpleDate(day, month, year);
                        string name = values[2].Substring(1);
                        bool reserved;
                        if (values[3] == "true")
                        {
                            reserved = true;
                        }
                        else
                        {
                            reserved = false;
                        }

                        if (values[0].Contains("Dog") || values[0].Contains("dog"))
                        {
                            date = values[4].Split('-');
                            day = Convert.ToInt32(date[0]);
                            month = Convert.ToInt32(date[1]);
                            year = Convert.ToInt32(date[2]);
                            SimpleDate lastWalkDate = new SimpleDate(day, month, year);
                            Dog dog = new Dog(chipRegistrationNumber, dateOfBirth, name, lastWalkDate);
                            dog.IsReserved = reserved;
                            Add(dog);
                        }
                        else if (values[0].Contains("Cat") || values[0].Contains("cat"))
                        {
                            string badHabits = values[4];
                            Cat cat = new Cat(chipRegistrationNumber, dateOfBirth, name, badHabits);
                            cat.IsReserved = reserved;
                            Add(cat);
                        }
                    }
                
            
            }*/
            /// <summary>
/// Exports the info of all animals to a text file with the given file name.
/// 
/// Each line of the file contains the info about exactly one animal.
/// Each line starts with the type of animal and a colon (e.g. 'Cat:' or 'Dog:')
/// followed by the properties of the animal seperated by comma's.
/// </summary>
/// <param name="fileName">The text file to write to.</param>
        public void Export(string fileName)
        {
            int x = 0;
            int length = animals.Count();
            string[] animalsString = new string[length];
            foreach (Animal animal in animals)
            {
                animalsString[x] = animal.ToString();
                x++;
            }
            System.IO.File.WriteAllLines(fileName,animalsString);
        }

    }
}
