namespace AnimalShelter
{
    partial class AnimalInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSoort = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNaam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbGD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUitgelaten = new System.Windows.Forms.Label();
            this.lbKarakter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChip = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.ckBoxReservering = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diersoort:";
            // 
            // lbSoort
            // 
            this.lbSoort.AutoSize = true;
            this.lbSoort.Location = new System.Drawing.Point(121, 25);
            this.lbSoort.Name = "lbSoort";
            this.lbSoort.Size = new System.Drawing.Size(35, 13);
            this.lbSoort.TabIndex = 1;
            this.lbSoort.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naam:";
            // 
            // lbNaam
            // 
            this.lbNaam.AutoSize = true;
            this.lbNaam.Location = new System.Drawing.Point(121, 69);
            this.lbNaam.Name = "lbNaam";
            this.lbNaam.Size = new System.Drawing.Size(35, 13);
            this.lbNaam.TabIndex = 3;
            this.lbNaam.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Geboortedatum:";
            // 
            // lbGD
            // 
            this.lbGD.AutoSize = true;
            this.lbGD.Location = new System.Drawing.Point(121, 92);
            this.lbGD.Name = "lbGD";
            this.lbGD.Size = new System.Drawing.Size(35, 13);
            this.lbGD.TabIndex = 5;
            this.lbGD.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gereserveerd:";
            // 
            // lbUitgelaten
            // 
            this.lbUitgelaten.AutoSize = true;
            this.lbUitgelaten.Location = new System.Drawing.Point(13, 145);
            this.lbUitgelaten.Name = "lbUitgelaten";
            this.lbUitgelaten.Size = new System.Drawing.Size(88, 13);
            this.lbUitgelaten.TabIndex = 8;
            this.lbUitgelaten.Text = "Laatst uitgelaten:";
            // 
            // lbKarakter
            // 
            this.lbKarakter.AutoSize = true;
            this.lbKarakter.Location = new System.Drawing.Point(121, 145);
            this.lbKarakter.Name = "lbKarakter";
            this.lbKarakter.Size = new System.Drawing.Size(41, 13);
            this.lbKarakter.TabIndex = 9;
            this.lbKarakter.Text = "label10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chipnummer:";
            // 
            // lbChip
            // 
            this.lbChip.AutoSize = true;
            this.lbChip.Location = new System.Drawing.Point(121, 47);
            this.lbChip.Name = "lbChip";
            this.lbChip.Size = new System.Drawing.Size(35, 13);
            this.lbChip.TabIndex = 11;
            this.lbChip.Text = "label3";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(66, 218);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(204, 218);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(124, 145);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(155, 20);
            this.dtPicker.TabIndex = 18;
            // 
            // ckBoxReservering
            // 
            this.ckBoxReservering.AutoSize = true;
            this.ckBoxReservering.Location = new System.Drawing.Point(124, 118);
            this.ckBoxReservering.Name = "ckBoxReservering";
            this.ckBoxReservering.Size = new System.Drawing.Size(15, 14);
            this.ckBoxReservering.TabIndex = 19;
            this.ckBoxReservering.UseVisualStyleBackColor = true;
            // 
            // AnimalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.ckBoxReservering);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbChip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKarakter);
            this.Controls.Add(this.lbUitgelaten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbGD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSoort);
            this.Controls.Add(this.label1);
            this.Name = "AnimalInfo";
            this.Text = "AnimalInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSoort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNaam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbGD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbUitgelaten;
        private System.Windows.Forms.Label lbKarakter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbChip;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.CheckBox ckBoxReservering;
    }
}