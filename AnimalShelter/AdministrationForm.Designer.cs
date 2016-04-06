namespace AnimalShelter
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.tbChipNumber = new System.Windows.Forms.TextBox();
            this.tbDOBD = new System.Windows.Forms.TextBox();
            this.tbDOBM = new System.Windows.Forms.TextBox();
            this.tbDOBY = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLWY = new System.Windows.Forms.TextBox();
            this.tbLWM = new System.Windows.Forms.TextBox();
            this.tbLWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDogCat = new System.Windows.Forms.Label();
            this.cbBadHabits = new System.Windows.Forms.ComboBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbNotReserved = new System.Windows.Forms.ListBox();
            this.lbReserved = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btMakeNoise = new System.Windows.Forms.Button();
            this.btSaveSerial = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSaveTxt = new System.Windows.Forms.Button();
            this.btLoadTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 10);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(209, 10);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // tbChipNumber
            // 
            this.tbChipNumber.Location = new System.Drawing.Point(142, 55);
            this.tbChipNumber.Name = "tbChipNumber";
            this.tbChipNumber.Size = new System.Drawing.Size(100, 20);
            this.tbChipNumber.TabIndex = 3;
            // 
            // tbDOBD
            // 
            this.tbDOBD.Location = new System.Drawing.Point(142, 81);
            this.tbDOBD.Name = "tbDOBD";
            this.tbDOBD.Size = new System.Drawing.Size(25, 20);
            this.tbDOBD.TabIndex = 5;
            // 
            // tbDOBM
            // 
            this.tbDOBM.Location = new System.Drawing.Point(170, 81);
            this.tbDOBM.Name = "tbDOBM";
            this.tbDOBM.Size = new System.Drawing.Size(25, 20);
            this.tbDOBM.TabIndex = 6;
            // 
            // tbDOBY
            // 
            this.tbDOBY.Location = new System.Drawing.Point(198, 81);
            this.tbDOBY.Name = "tbDOBY";
            this.tbDOBY.Size = new System.Drawing.Size(44, 20);
            this.tbDOBY.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(142, 107);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbLWY
            // 
            this.tbLWY.Location = new System.Drawing.Point(198, 133);
            this.tbLWY.Name = "tbLWY";
            this.tbLWY.Size = new System.Drawing.Size(44, 20);
            this.tbLWY.TabIndex = 11;
            this.tbLWY.Visible = false;
            // 
            // tbLWM
            // 
            this.tbLWM.Location = new System.Drawing.Point(170, 133);
            this.tbLWM.Name = "tbLWM";
            this.tbLWM.Size = new System.Drawing.Size(25, 20);
            this.tbLWM.TabIndex = 10;
            this.tbLWM.Visible = false;
            // 
            // tbLWD
            // 
            this.tbLWD.Location = new System.Drawing.Point(142, 133);
            this.tbLWD.Name = "tbLWD";
            this.tbLWD.Size = new System.Drawing.Size(25, 20);
            this.tbLWD.TabIndex = 9;
            this.tbLWD.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ChipNummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date of birth (D/M/Y):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name:";
            // 
            // lbDogCat
            // 
            this.lbDogCat.AutoSize = true;
            this.lbDogCat.Location = new System.Drawing.Point(35, 136);
            this.lbDogCat.Name = "lbDogCat";
            this.lbDogCat.Size = new System.Drawing.Size(98, 13);
            this.lbDogCat.TabIndex = 15;
            this.lbDogCat.Text = "Last walk (D/M/Y):";
            // 
            // cbBadHabits
            // 
            this.cbBadHabits.FormattingEnabled = true;
            this.cbBadHabits.Location = new System.Drawing.Point(142, 133);
            this.cbBadHabits.Name = "cbBadHabits";
            this.cbBadHabits.Size = new System.Drawing.Size(142, 21);
            this.cbBadHabits.TabIndex = 16;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(269, 48);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(64, 23);
            this.btRemove.TabIndex = 17;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // lbNotReserved
            // 
            this.lbNotReserved.FormattingEnabled = true;
            this.lbNotReserved.Location = new System.Drawing.Point(304, 194);
            this.lbNotReserved.Name = "lbNotReserved";
            this.lbNotReserved.Size = new System.Drawing.Size(286, 121);
            this.lbNotReserved.TabIndex = 18;
            // 
            // lbReserved
            // 
            this.lbReserved.FormattingEnabled = true;
            this.lbReserved.Location = new System.Drawing.Point(12, 194);
            this.lbReserved.Name = "lbReserved";
            this.lbReserved.Size = new System.Drawing.Size(286, 121);
            this.lbReserved.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reserved:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Not Reserved:";
            // 
            // btMakeNoise
            // 
            this.btMakeNoise.Location = new System.Drawing.Point(304, 131);
            this.btMakeNoise.Name = "btMakeNoise";
            this.btMakeNoise.Size = new System.Drawing.Size(75, 23);
            this.btMakeNoise.TabIndex = 22;
            this.btMakeNoise.Text = "Make noise";
            this.btMakeNoise.UseVisualStyleBackColor = true;
            this.btMakeNoise.Click += new System.EventHandler(this.btMakeNoise_Click);
            // 
            // btSaveSerial
            // 
            this.btSaveSerial.Location = new System.Drawing.Point(395, 53);
            this.btSaveSerial.Name = "btSaveSerial";
            this.btSaveSerial.Size = new System.Drawing.Size(75, 23);
            this.btSaveSerial.TabIndex = 23;
            this.btSaveSerial.Text = "Save Serial";
            this.btSaveSerial.UseVisualStyleBackColor = true;
            this.btSaveSerial.Click += new System.EventHandler(this.btSaveSerial_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(395, 84);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 24;
            this.btLoad.Text = "Load Serial";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoadSerial_Click);
            // 
            // btSaveTxt
            // 
            this.btSaveTxt.Location = new System.Drawing.Point(488, 53);
            this.btSaveTxt.Name = "btSaveTxt";
            this.btSaveTxt.Size = new System.Drawing.Size(75, 23);
            this.btSaveTxt.TabIndex = 25;
            this.btSaveTxt.Text = "Save Txt";
            this.btSaveTxt.UseVisualStyleBackColor = true;
            this.btSaveTxt.Click += new System.EventHandler(this.btSaveTxt_Click);
            // 
            // btLoadTxt
            // 
            this.btLoadTxt.Location = new System.Drawing.Point(488, 84);
            this.btLoadTxt.Name = "btLoadTxt";
            this.btLoadTxt.Size = new System.Drawing.Size(75, 23);
            this.btLoadTxt.TabIndex = 26;
            this.btLoadTxt.Text = "Load Txt";
            this.btLoadTxt.UseVisualStyleBackColor = true;
            this.btLoadTxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 327);
            this.Controls.Add(this.btLoadTxt);
            this.Controls.Add(this.btSaveTxt);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSaveSerial);
            this.Controls.Add(this.btMakeNoise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbReserved);
            this.Controls.Add(this.lbNotReserved);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.cbBadHabits);
            this.Controls.Add(this.lbDogCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLWY);
            this.Controls.Add(this.tbLWM);
            this.Controls.Add(this.tbLWD);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbDOBY);
            this.Controls.Add(this.tbDOBM);
            this.Controls.Add(this.tbDOBD);
            this.Controls.Add(this.tbChipNumber);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox tbChipNumber;
        private System.Windows.Forms.TextBox tbDOBD;
        private System.Windows.Forms.TextBox tbDOBM;
        private System.Windows.Forms.TextBox tbDOBY;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLWY;
        private System.Windows.Forms.TextBox tbLWM;
        private System.Windows.Forms.TextBox tbLWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDogCat;
        private System.Windows.Forms.ComboBox cbBadHabits;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbNotReserved;
        private System.Windows.Forms.ListBox lbReserved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btMakeNoise;
        private System.Windows.Forms.Button btSaveSerial;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSaveTxt;
        private System.Windows.Forms.Button btLoadTxt;

    }
}

