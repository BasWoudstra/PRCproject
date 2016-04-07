using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form 
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        public Administration administration;

        List<Animal> sortedAnimals = new List<Animal>();

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            insertIntoCBCat();
            administration = new Administration();
            MakeRandomAnimals();
            refreshListBoxes();
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            int chipRegistrationNumber;
            string name;

            bool NameNull = String.IsNullOrWhiteSpace(tbName.Text);
            bool chipCorrect = Int32.TryParse(tbChipNumber.Text, out chipRegistrationNumber);
            if (NameNull == false && chipCorrect)
            {
                name = tbName.Text;
                if (administration.FindAnimal(chipRegistrationNumber) != null)
                {
                    MessageBox.Show("Chipnumber " + chipRegistrationNumber + " is already present in the system.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill in all values");
                return;
            }

            SimpleDate dateOfBirth = null;
            int day;
            int month;
            int year;
            int minDate = DateTimePicker.MinimumDateTime.Year;
            int maxDate = DateTimePicker.MaximumDateTime.Year;
            bool checkD = Int32.TryParse(tbDOBD.Text, out day);
            bool checkM = Int32.TryParse(tbDOBM.Text, out month);
            bool checkY = Int32.TryParse(tbDOBY.Text, out year);
            bool yearRight;
            if (year > minDate && year < maxDate)
            {
                yearRight = true;
            }
            else
            {
                yearRight = false;
            }
            if (checkD == true && checkM == true && checkY == true && yearRight == true)
            {
                dateOfBirth = new SimpleDate(day, month, year);
            }
            else
            {
                if (yearRight == false)
                {
                    MessageBox.Show("The date must be between the year " + minDate +" and "+ maxDate);
                    return;
                }
                else
                {
                    MessageBox.Show("Please fill in all values");
                    return;
                }
            }

            SimpleDate lastWalkDate = null;
            if (animalTypeComboBox.Text == "Dog" || animalTypeComboBox.Text == "dog")
            {
                checkD = Int32.TryParse(tbLWD.Text, out day);
                checkM = Int32.TryParse(tbLWM.Text, out month);
                checkY = Int32.TryParse(tbLWY.Text, out year);
                if (year > minDate && year < maxDate)
                {
                    yearRight = true;
                }
                else
                {
                    yearRight = false;
                }
                if (checkD && checkM == true && checkY == true && yearRight == true)
                {
                    lastWalkDate = new SimpleDate(day, month, year);
                }
                else
                {
                    if (yearRight == false)
                    {
                        MessageBox.Show("The date must be between the year " + minDate + " and " + maxDate);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all values");
                        return;
                    }
                }
            }

            // TODO: See method description
                switch (animalTypeComboBox.Text)
                {
                    case "Dog":
                    case "dog":
                        try
                        {
                            Dog dog = new Dog(chipRegistrationNumber,dateOfBirth,name,lastWalkDate);
                            administration.Add(dog);
                            break;
                        }
                        catch(Exception x)
                        {
                            if (x is ArgumentNullException || x is ArgumentException)
                            MessageBox.Show("unable to create dog");
                            break;
                        }
                    case "Cat":
                    case "cat":
                        try
                        {
                            Cat cat = new Cat(chipRegistrationNumber,dateOfBirth,name,cbBadHabits.Text);
                            administration.Add(cat);
                            break;
                        }
                        catch(Exception x)
                        {
                            if(x is ArgumentNullException || x is ArgumentException)
                            MessageBox.Show("unable to create dog");
                            break;
                        }
                        
                }
                refreshListBoxes();
            
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            Animal animal = null;
            int chipNumber;
            bool correct = Int32.TryParse(tbChipNumber.Text, out chipNumber);
            if (correct)
            {
                animal = administration.FindAnimal(chipNumber);
                if (animal != null)
                {
                    AnimalInfo animalinfo = new AnimalInfo(animal, this);
                    animalinfo.Show();
                }
                else
                {
                    MessageBox.Show("No animals with chipnumber " + chipNumber + " can be found in the system.");
                }
            }
        }

        private void insertIntoCBCat()
        {
            cbBadHabits.Items.Add("Niks");
            cbBadHabits.Items.Add("Is erg bazig");
            cbBadHabits.Items.Add("Valt andere katten aan");
            cbBadHabits.Items.Add("Kan slecht alleen zijn");
            cbBadHabits.Items.Add("Niet geschikt voor kinderen");
            cbBadHabits.Items.Add("Atilla the Hun incarnated");
            cbBadHabits.SelectedIndex = 0;
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbanimal = animalTypeComboBox.Text;

            switch (cbanimal)
            {
                case "Cat":
                    tbLWD.Visible = false;
                    tbLWM.Visible = false;
                    tbLWY.Visible = false;
                    cbBadHabits.Visible = true;
                    lbDogCat.Text = "Bad habits: ";
                    break;
                case "Dog":
                    tbLWD.Visible = true;
                    tbLWM.Visible = true;
                    tbLWY.Visible = true;
                    cbBadHabits.Visible = false;
                    lbDogCat.Text = "Last walk (D/M/Y):";
                    break;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            int chipnumber;
            bool correct = Int32.TryParse(tbChipNumber.Text,  out chipnumber);

            if (correct)
            {
                string name = administration.FindAnimal(chipnumber).Name;
                try
                {
                    administration.RemoveAnimal(chipnumber);
                    MessageBox.Show(name + " was succesfully removed.");
                }
                catch(ArgumentNullException)
                {
                    MessageBox.Show("No animals have the chipnumber: " + chipnumber);
                }
            }
            else
            {
                MessageBox.Show("please enter a chipnumber");
            }
        }

        public void orderListBoxes()
        {
            sortedAnimals.Clear();
            //Ascending
            List<Animal> SortedList = administration.animals.OrderBy(o => o.ChipRegistrationNumber).ToList();
            //Descending
            //List<Animal> SortedList = administration.animals.OrderByDescending(o => o.ChipRegistrationNumber).ToList();

            foreach (Animal diertje in SortedList)
            {
                sortedAnimals.Add(diertje);
            }
        }

        public void refreshListBoxes()
        {
            orderListBoxes();
            string[] values = new string[5];
            lbNotReserved.Items.Clear();
            lbReserved.Items.Clear();
            foreach (Animal animal in sortedAnimals)
            {
                string diertje = animal.ToString();
                values = diertje.Split(',');
                if (values[3] == " True")
                {
                    lbReserved.Items.Add(values[0] + values[3]);
                }
                else if (values[3] == " False")
                {
                    lbNotReserved.Items.Add(values[0] + values[3]);
                }
            }
        }

        private void btMakeNoise_Click(object sender, EventArgs e)
        {
            bool checkIfEmpty = String.IsNullOrWhiteSpace(tbChipNumber.Text);
            if (checkIfEmpty == false)
            {
                Animal diertje = administration.FindAnimal(Convert.ToInt32(tbChipNumber.Text));
                if (diertje != null)
                {
                    string geluid = diertje.MakeNoise();
                    MessageBox.Show(geluid);
                }
            }
        }
        
        private void MakeRandomAnimals()
        {
            string[] namenHond = { "Bello", "Toby", "Kevin", "Laika" };
            string[] namenKat = { "Poes", "Thor", "KittyCat" };
            string[] badHabits = { "Niks", "Is erg bazig", "Valt andere katten aan", "Kan slecht alleen zijn", "Niet geschikt voor kinderen", "Atilla the Hun incarnated" };
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
                chipnummer = random.Next(1, 9999);
                day = random.Next(1, 28);
                month = random.Next(1, 12);
                year = random.Next(1990, DateTime.Now.Year);
                geboortedatum = new SimpleDate(day, month, year);
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
                administration.Add(animal);
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
                uitlaten = new SimpleDate(day, month, year);

                dog = new Dog(chipnummer, geboortedatum, naam, uitlaten);
                animal = dog;
                int randomnumber = random.Next(0, 2);
                if (randomnumber == 1)
                {
                    animal.IsReserved = true;
                }
                else if (randomnumber == 0)
                {
                    animal.IsReserved = false;
                }
                administration.Add(animal);
            }
        }
        
        private void btSaveTxt_Click(object sender, EventArgs e)
        {
            administration.Export(tbLocaton.Text+".txt");
        }

        private void btSaveSerial_Click(object sender, EventArgs e)
        {
            administration.Save(tbLocaton.Text+".dat");
        }

        private void btLoadSerial_Click(object sender, EventArgs e)
        {
            try
            {
                administration.Load(tbLocaton.Text + ".dat", "dat");
                refreshListBoxes();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No file with the name: " + tbLocaton.Text + ".dat " + "has been found");
            }
        }

        private void btLoadTxt_Click(object sender, EventArgs e)
        {
            AnimalFileImporterForm animalFileImporter = new AnimalFileImporterForm(administration, this);
            animalFileImporter.Show();
            /*try
            {
                administration.Load(tbLocaton.Text + ".txt", "txt");
                refreshListBoxes();
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("No file with the name: " + tbLocaton.Text + ".txt " + "has been found");
            }*/
       }

    }
}
