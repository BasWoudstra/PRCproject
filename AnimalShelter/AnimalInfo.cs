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
    public partial class AnimalInfo : Form
    {
        Animal animal;
        AdministrationForm administrationform;

        public AnimalInfo()
        {
            InitializeComponent();
        }

        public AnimalInfo(Animal animal, AdministrationForm administrationform)
        {
            InitializeComponent();
            this.administrationform = administrationform;
            this.animal = animal;
            string diertje = animal.ToString();
            string[] values = new string[5];
            values = diertje.Split(',');

            lbSoort.Text = values[0].Substring(0, 3);
            lbChip.Text = values[0].Substring(5);
            lbGD.Text = values[1];
            lbNaam.Text = values[2];
            if (values[3] == " True")
            {
                ckBoxReservering.Checked = true;
            } 
            else if (values[3] == " False")
            {
                ckBoxReservering.Checked = false;
            }

            string soort = diertje.Substring(0, 3);
            if (soort == "cat" || soort == "Cat")
            {
                lbKarakter.Visible = true;
                dtPicker.Visible = false;
                lbUitgelaten.Text = "Karakter: ";
                lbKarakter.Text = values[4];
            }
            else if (soort == "dog" || soort == "Dog")
            {
                lbKarakter.Visible = false;
                dtPicker.Visible = true;
                dtPicker.Value = Convert.ToDateTime(values[4]);
                lbUitgelaten.Text = "Laatst uitgelaten: ";
                
            }

            lbPrice.Text = "€"+Convert.ToString(animal.Price);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Animal changedAnimal;
            int chip = animal.ChipRegistrationNumber;
            SimpleDate geboortedatum = animal.DateOfBirth;
            string naam = animal.Name;
            if (lbSoort.Text == "dog" || lbSoort.Text == "Dog")
            {
                DateTime lastwalkdate = dtPicker.Value;
                SimpleDate lastwalk = new SimpleDate(lastwalkdate.Day,lastwalkdate.Month,lastwalkdate.Year);
                Dog dog = new Dog(chip, geboortedatum, naam, lastwalk);
                changedAnimal = dog;
            }
            else if (lbSoort.Text == "cat" || lbSoort.Text == "Cat")
            {
                Cat cat = new Cat(chip, geboortedatum, naam, lbKarakter.Text);
                changedAnimal = cat;
            }
            else
            {
                changedAnimal = this.animal;
            }
            bool reserved = ckBoxReservering.Checked;
            changedAnimal.IsReserved = reserved;
            administrationform.administration.Change(changedAnimal);
            administrationform.refreshListBoxes();
            this.Close();
        }
    }
}
