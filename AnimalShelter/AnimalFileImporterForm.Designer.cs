namespace AnimalShelter
{
    partial class AnimalFileImporterForm
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
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btFindTxt = new System.Windows.Forms.Button();
            this.lBoxInFile = new System.Windows.Forms.ListBox();
            this.btAddToSystem = new System.Windows.Forms.Button();
            this.btClearLBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(29, 37);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(100, 20);
            this.tbFileName.TabIndex = 0;
            // 
            // btFindTxt
            // 
            this.btFindTxt.Location = new System.Drawing.Point(151, 35);
            this.btFindTxt.Name = "btFindTxt";
            this.btFindTxt.Size = new System.Drawing.Size(75, 23);
            this.btFindTxt.TabIndex = 1;
            this.btFindTxt.Text = "Find file";
            this.btFindTxt.UseVisualStyleBackColor = true;
            this.btFindTxt.Click += new System.EventHandler(this.btFindTxt_Click);
            // 
            // lBoxInFile
            // 
            this.lBoxInFile.FormattingEnabled = true;
            this.lBoxInFile.Location = new System.Drawing.Point(12, 74);
            this.lBoxInFile.Name = "lBoxInFile";
            this.lBoxInFile.Size = new System.Drawing.Size(260, 134);
            this.lBoxInFile.TabIndex = 2;
            // 
            // btAddToSystem
            // 
            this.btAddToSystem.Location = new System.Drawing.Point(170, 226);
            this.btAddToSystem.Name = "btAddToSystem";
            this.btAddToSystem.Size = new System.Drawing.Size(102, 23);
            this.btAddToSystem.TabIndex = 3;
            this.btAddToSystem.Text = "Add to system";
            this.btAddToSystem.UseVisualStyleBackColor = true;
            this.btAddToSystem.Click += new System.EventHandler(this.btAddToSystem_Click);
            // 
            // btClearLBox
            // 
            this.btClearLBox.Location = new System.Drawing.Point(12, 226);
            this.btClearLBox.Name = "btClearLBox";
            this.btClearLBox.Size = new System.Drawing.Size(75, 23);
            this.btClearLBox.TabIndex = 4;
            this.btClearLBox.Text = "Clear listbox";
            this.btClearLBox.UseVisualStyleBackColor = true;
            this.btClearLBox.Click += new System.EventHandler(this.btClearLBox_Click);
            // 
            // AnimalFileImporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btClearLBox);
            this.Controls.Add(this.btAddToSystem);
            this.Controls.Add(this.lBoxInFile);
            this.Controls.Add(this.btFindTxt);
            this.Controls.Add(this.tbFileName);
            this.Name = "AnimalFileImporterForm";
            this.Text = "AnimalFileImporterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btFindTxt;
        private System.Windows.Forms.ListBox lBoxInFile;
        private System.Windows.Forms.Button btAddToSystem;
        private System.Windows.Forms.Button btClearLBox;
    }
}