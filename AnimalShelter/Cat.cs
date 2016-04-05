using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Cat : Animal
    {
        /// <summary>
        /// Description of the bad habits that the cat has (e.g. "Scratches the couch").
        /// or null if the cat has no bad habits.
        /// </summary>
        public string BadHabits { get; set; }

        public override decimal Price
        {
            get
            {
                int price;
                int howlong = BadHabits.Length;

                price = 60 - howlong;
                if (price < 20)
                {
                    price = 20;
                }
                return price;
            }
        }

        /// <summary>
        /// Creates a cat.
        /// </summary>
        /// <param name="chipRegistrationNumber">The chipnumber of the animal. 
        ///                                      Must be unique. Must be zero or greater than zero.</param>
        /// <param name="dateOfBirth">The date of birth of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        /// <param name="badHabits">The bad habbits of the cat (e.g. "scratches the couch")
        ///                         or null if none.</param>
        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, string badHabits) : base(chipRegistrationNumber,dateOfBirth,name)
        {
            try
            {
                this.BadHabits = badHabits;// TODO: Modify the constructor. Make sure it initializes all properties of the class.
            }
            catch
            {
                throw new ArgumentNullException("Bad habits is leeg");
            }
        }

        public override string MakeNoise()
        {
            return "Miauw";
        }

        /// <summary>
        /// Retrieve information about this cat
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "Cat: <ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>, <BadHabits>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///                 BadHabits will be "none" if the cat has no bad habits, or the bad habits string otherwise.
        /// </returns>
        public override string ToString()
        {
            // TODO: Put your own code here to make the method return the string specified in the
            // med description.
            return "Cat: " + base.ToString() + ", " + BadHabits;
        }
    }
}
