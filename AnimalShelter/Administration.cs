﻿using System;
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
        public List<Animal> temporaryAnimals;

        IFormatter formatter = new BinaryFormatter();

        public Administration()
        {
            animals = new List<Animal>();
        }
        
        public void Add(Animal animal)
        {
            
            if (FindAnimal(animal.ChipRegistrationNumber) != null)
            {
                new ArgumentException();
            }
            else if(animal == null)
            {
                new ArgumentNullException();
            }
            else
            {
                animals.Add(animal);
            }
            //we hebben hier gekozen voor een exception terug te geven omdat er geen null Animal verwacht word, 
            //indien we deze check weg zouden halen zouden we er een bool van moeten maken voor 
            //het checken ofdat de methode goed is uitgevoerd. u had gezegt dat NullExceptions beter waren indien
            //ze met code werden afgehandeld, maar ook dat ze voor onverwachte situaties waren en dat het beter is om
            //geen bool terug te geven, en omdat de code aanpassen voor alle exceptions op dit moment niet haalbaar
            // is om te doen naast het werk voor de proftaak. hierom hebben wij gekozen om deze te laten staan ipv
            //de code te veranderen. 
            //dit geld voor iedere excpetion 
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
            try
            {
                RemoveAnimal(animal.ChipRegistrationNumber);
                Add(animal);
            }
            catch
            {
                throw new ArgumentNullException();
                // throw new exeption. want als catch(Exception ex){throw ex;} dan geeft hij een verkeerde exeption terug.
            }
        }

        public void SortListBox()
        {
            animals.Sort();
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
        }

        /// <summary>
        /// Loads all animals from a file with the given file name using deserialisation.
        /// All animals currently in the administration are removed.
        /// </summary>
        /// <param name="fileName">The file to read from.</param>
        public void Load(string fileName, string fileType)
        {
            if (File.Exists(fileName))
            {
                animals.Clear();
                switch (fileType)
                {
                    case "dat":

                        using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                        {
                            animals = formatter.Deserialize(stream) as List<Animal>;
                        }
                        break;
                    case "txt":
                        temporaryAnimals = new List<Animal>();
                        string[] values = new string[5];
                        string[] date = new string[4];
                        string[] animalsString = System.IO.File.ReadAllLines(fileName);
                        int howManyAnimals = animalsString.Count();
                        for (int x = 0; x < howManyAnimals; x++)
                        {
                            values = animalsString[x].Split(',');
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
                                temporaryAnimals.Add(dog);
                            }
                            else if (values[0].Contains("Cat") || values[0].Contains("cat"))
                            {
                                string badHabits = values[4];
                                Cat cat = new Cat(chipRegistrationNumber, dateOfBirth, name, badHabits);
                                cat.IsReserved = reserved;
                                temporaryAnimals.Add(cat);
                            }
                        }
                        break;
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
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
