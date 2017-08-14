namespace UsEsquelbecq
{
    partial class FormAjouterEvenement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterEvenement));
            this.labelTypeEvenement = new System.Windows.Forms.Label();
            this.labelNomEvenement = new System.Windows.Forms.Label();
            this.labelSponsorEvenement = new System.Windows.Forms.Label();
            this.labelDateEvenement = new System.Windows.Forms.Label();
            this.comboBoxTypeEvenement = new System.Windows.Forms.ComboBox();
            this.comboBoxNomEvenement = new System.Windows.Forms.ComboBox();
            this.comboBoxSponsorEvenement = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEvenement = new System.Windows.Forms.DateTimePicker();
            this.buttonAnnulerEvenement = new System.Windows.Forms.Button();
            this.buttonAjouterEvenement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeEvenement
            // 
            this.labelTypeEvenement.AutoSize = true;
            this.labelTypeEvenement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeEvenement.Location = new System.Drawing.Point(20, 40);
            this.labelTypeEvenement.Name = "labelTypeEvenement";
            this.labelTypeEvenement.Size = new System.Drawing.Size(44, 19);
            this.labelTypeEvenement.TabIndex = 0;
            this.labelTypeEvenement.Text = "Type";
            // 
            // labelNomEvenement
            // 
            this.labelNomEvenement.AutoSize = true;
            this.labelNomEvenement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEvenement.Location = new System.Drawing.Point(20, 100);
            this.labelNomEvenement.Name = "labelNomEvenement";
            this.labelNomEvenement.Size = new System.Drawing.Size(43, 19);
            this.labelNomEvenement.TabIndex = 1;
            this.labelNomEvenement.Text = "Nom";
            // 
            // labelSponsorEvenement
            // 
            this.labelSponsorEvenement.AutoSize = true;
            this.labelSponsorEvenement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSponsorEvenement.Location = new System.Drawing.Point(20, 160);
            this.labelSponsorEvenement.Name = "labelSponsorEvenement";
            this.labelSponsorEvenement.Size = new System.Drawing.Size(67, 19);
            this.labelSponsorEvenement.TabIndex = 2;
            this.labelSponsorEvenement.Text = "Sponsor";
            // 
            // labelDateEvenement
            // 
            this.labelDateEvenement.AutoSize = true;
            this.labelDateEvenement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateEvenement.Location = new System.Drawing.Point(20, 220);
            this.labelDateEvenement.Name = "labelDateEvenement";
            this.labelDateEvenement.Size = new System.Drawing.Size(41, 19);
            this.labelDateEvenement.TabIndex = 3;
            this.labelDateEvenement.Text = "Date";
            // 
            // comboBoxTypeEvenement
            // 
            this.comboBoxTypeEvenement.FormattingEnabled = true;
            this.comboBoxTypeEvenement.Location = new System.Drawing.Point(154, 40);
            this.comboBoxTypeEvenement.Name = "comboBoxTypeEvenement";
            this.comboBoxTypeEvenement.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeEvenement.TabIndex = 4;
            // 
            // comboBoxNomEvenement
            // 
            this.comboBoxNomEvenement.FormattingEnabled = true;
            this.comboBoxNomEvenement.Location = new System.Drawing.Point(154, 100);
            this.comboBoxNomEvenement.Name = "comboBoxNomEvenement";
            this.comboBoxNomEvenement.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNomEvenement.TabIndex = 5;
            // 
            // comboBoxSponsorEvenement
            // 
            this.comboBoxSponsorEvenement.FormattingEnabled = true;
            this.comboBoxSponsorEvenement.Location = new System.Drawing.Point(154, 160);
            this.comboBoxSponsorEvenement.Name = "comboBoxSponsorEvenement";
            this.comboBoxSponsorEvenement.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSponsorEvenement.TabIndex = 6;
            // 
            // dateTimePickerEvenement
            // 
            this.dateTimePickerEvenement.Location = new System.Drawing.Point(154, 220);
            this.dateTimePickerEvenement.Name = "dateTimePickerEvenement";
            this.dateTimePickerEvenement.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerEvenement.TabIndex = 7;
            // 
            // buttonAnnulerEvenement
            // 
            this.buttonAnnulerEvenement.Location = new System.Drawing.Point(45, 308);
            this.buttonAnnulerEvenement.Name = "buttonAnnulerEvenement";
            this.buttonAnnulerEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonAnnulerEvenement.TabIndex = 8;
            this.buttonAnnulerEvenement.Text = "Annuler";
            this.buttonAnnulerEvenement.UseVisualStyleBackColor = true;
            this.buttonAnnulerEvenement.Click += new System.EventHandler(this.buttonAnnulerEvenement_Click);
            // 
            // buttonAjouterEvenement
            // 
            this.buttonAjouterEvenement.Location = new System.Drawing.Point(154, 308);
            this.buttonAjouterEvenement.Name = "buttonAjouterEvenement";
            this.buttonAjouterEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterEvenement.TabIndex = 9;
            this.buttonAjouterEvenement.Text = "Ajouter";
            this.buttonAjouterEvenement.UseVisualStyleBackColor = true;
            this.buttonAjouterEvenement.Click += new System.EventHandler(this.buttonAjouterEvenement_Click);
            // 
            // FormAjouterEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(304, 381);
            this.Controls.Add(this.buttonAjouterEvenement);
            this.Controls.Add(this.buttonAnnulerEvenement);
            this.Controls.Add(this.dateTimePickerEvenement);
            this.Controls.Add(this.comboBoxSponsorEvenement);
            this.Controls.Add(this.comboBoxNomEvenement);
            this.Controls.Add(this.comboBoxTypeEvenement);
            this.Controls.Add(this.labelDateEvenement);
            this.Controls.Add(this.labelSponsorEvenement);
            this.Controls.Add(this.labelNomEvenement);
            this.Controls.Add(this.labelTypeEvenement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 420);
            this.MinimumSize = new System.Drawing.Size(320, 420);
            this.Name = "FormAjouterEvenement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeEvenement;
        private System.Windows.Forms.Label labelNomEvenement;
        private System.Windows.Forms.Label labelSponsorEvenement;
        private System.Windows.Forms.Label labelDateEvenement;
        private System.Windows.Forms.ComboBox comboBoxTypeEvenement;
        private System.Windows.Forms.ComboBox comboBoxNomEvenement;
        private System.Windows.Forms.ComboBox comboBoxSponsorEvenement;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvenement;
        private System.Windows.Forms.Button buttonAnnulerEvenement;
        private System.Windows.Forms.Button buttonAjouterEvenement;
    }
}