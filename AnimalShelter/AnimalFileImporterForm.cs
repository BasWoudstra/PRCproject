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
    public partial class AnimalFileImporterForm : Form
    {
        Administration administration;
        AdministrationForm administrationForm;
        List<Animal> animals;

        public AnimalFileImporterForm()
        {
            InitializeComponent();
            animals = new List<Animal>();
        }

        public AnimalFileImporterForm(Administration administration, AdministrationForm administrationForm)
        {
            InitializeComponent();
            this.administration = administration;
            this.administrationForm = administrationForm;
            animals = new List<Animal>();
        }

        private void btFindTxt_Click(object sender, EventArgs e)
        {
            try
            {
                administration.Load(tbFileName.Text + ".txt", "txt");
                foreach (Animal animal in administration.temporaryAnimals)
                {
                    animals.Add(animal);
                }
                showInListBox();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No file with the name: " + tbFileName.Text + ".txt " + "has been found");
            }
        }

        private void showInListBox()
        {
            lBoxInFile.Items.Clear();
            foreach (Animal animal in animals)
            {
                string[] values = new string[5];
                string diertje = animal.ToString();
                values = diertje.Split(',');
                lBoxInFile.Items.Add(values[0]);
            }
        }

        private void btAddToSystem_Click(object sender, EventArgs e)
        {
            foreach (Animal animal in animals)
            {
                administration.Add(animal);
            }
            administrationForm.refreshListBoxes();
            this.Close();
        }

        private void btClearLBox_Click(object sender, EventArgs e)
        {
            animals.Clear();
        }
    }
}
