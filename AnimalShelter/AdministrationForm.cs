using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        public static Administration administration;
        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            insertIntoCBCat();
            administration = new Administration();
            administration.makeRandomAnimals();
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
            if (NameNull == false)
            {
                name = tbName.Text;
            }
            else
            {
                MessageBox.Show("Please fill in all values");
                return;
            }
            bool chipCorrect = Int32.TryParse(tbChipNumber.Text, out chipRegistrationNumber);
            if (chipCorrect == false)
            {
                MessageBox.Show("Please fill in all values");
                return;
            }
            else
            {
                bool inSystem = administration.alreadyInSystem(chipRegistrationNumber);
                if (inSystem)
                {
                    MessageBox.Show("Chipnumber " + chipRegistrationNumber + " is already present in the system.");
                    return;
                }
            }

            SimpleDate dateOfBirth = null;
            int day;
            int month;
            int year;
            bool checkD = Int32.TryParse(tbDOBD.Text, out day);
            bool checkM = Int32.TryParse(tbDOBM.Text, out month);
            bool checkY = Int32.TryParse(tbDOBY.Text, out year); 
            if (checkD == true && checkM == true && checkY == true)
            {
                dateOfBirth = new SimpleDate(day, month, year);
            }
            else
            {
               MessageBox.Show("Please fill in all values");
               return;
            }

            SimpleDate lastWalkDate = null;
            if (animalTypeComboBox.Text == "Dog" || animalTypeComboBox.Text == "dog")
            {
                checkD = Int32.TryParse(tbLWD.Text, out day);
                checkD = Int32.TryParse(tbLWM.Text, out month);
                checkD = Int32.TryParse(tbLWY.Text, out year);
                if (checkD && checkM == true && checkY == true)
                {
                    lastWalkDate = new SimpleDate(day, month, year);
                }
                else
                {
                    MessageBox.Show("Please fill in all values");
                    return;
                }
            }

            // TODO: See method description
                switch (animalTypeComboBox.Text)
                {
                    case "Dog":
                    case "dog":
                        Dog dog = new Dog(chipRegistrationNumber,dateOfBirth,name,lastWalkDate);
                        administration.Add(dog);
                        break;
                    case "Cat":
                    case "cat":
                        Cat cat = new Cat(chipRegistrationNumber,dateOfBirth,name,cbBadHabits.Text);
                        administration.Add(cat);
                        break;
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
                animal = administration.findAnimal(chipNumber);
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
            string animalName = "";
            Animal animal;
            bool removed = false;
            bool correct = Int32.TryParse(tbChipNumber.Text, out chipnumber);
            if (correct){
                animal = administration.findAnimal(chipnumber);
                if (animal != null)
                {
                    animalName = animal.Name;
                }
                removed = administration.RemoveAnimal(chipnumber);
            }
            if (removed)
            {
                MessageBox.Show(animalName + " was succesfully removed.");
                refreshListBoxes();
            }
            else
            {
                MessageBox.Show("No animals have the chipnumber: " + chipnumber);
            }
        }

        public void refreshListBoxes()
        {
            string[] values = new string[5];
            lbNotReserved.Items.Clear();
            lbReserved.Items.Clear();
            foreach (Animal animal in administration.animals)
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
            Animal diertje = administration.findAnimal(Convert.ToInt32(tbChipNumber.Text));
            string geluid = diertje.makeNoise();
            MessageBox.Show(geluid);
        }

    }
}
