namespace UsEsquelbecq
{
    partial class FormAjouterSouscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterSouscription));
            this.labelSponsorSouscription = new System.Windows.Forms.Label();
            this.labelContratSouscription = new System.Windows.Forms.Label();
            this.labelDateSouscription = new System.Windows.Forms.Label();
            this.labelDatePaiementSouscription = new System.Windows.Forms.Label();
            this.labelMontantSouscription = new System.Windows.Forms.Label();
            this.labelCommentaireSouscription = new System.Windows.Forms.Label();
            this.buttonAnnulerSouscription = new System.Windows.Forms.Button();
            this.buttonAjouterSouscription = new System.Windows.Forms.Button();
            this.comboBoxSponsorSouscription = new System.Windows.Forms.ComboBox();
            this.comboBoxContratSouscription = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateSouscription = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPaiementSouscription = new System.Windows.Forms.DateTimePicker();
            this.textBoxMontantSouscription = new System.Windows.Forms.TextBox();
            this.textBoxCommentaireSouscription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSponsorSouscription
            // 
            this.labelSponsorSouscription.AutoSize = true;
            this.labelSponsorSouscription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSponsorSouscription.Location = new System.Drawing.Point(20, 40);
            this.labelSponsorSouscription.Name = "labelSponsorSouscription";
            this.labelSponsorSouscription.Size = new System.Drawing.Size(67, 19);
            this.labelSponsorSouscription.TabIndex = 0;
            this.labelSponsorSouscription.Text = "Sponsor";
            // 
            // labelContratSouscription
            // 
            this.labelContratSouscription.AutoSize = true;
            this.labelContratSouscription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContratSouscription.Location = new System.Drawing.Point(20, 100);
            this.labelContratSouscription.Name = "labelContratSouscription";
            this.labelContratSouscription.Size = new System.Drawing.Size(61, 19);
            this.labelContratSouscription.TabIndex = 1;
            this.labelContratSouscription.Text = "Contrat";
            // 
            // labelDateSouscription
            // 
            this.labelDateSouscription.AutoSize = true;
            this.labelDateSouscription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateSouscription.Location = new System.Drawing.Point(20, 160);
            this.labelDateSouscription.Name = "labelDateSouscription";
            this.labelDateSouscription.Size = new System.Drawing.Size(153, 19);
            this.labelDateSouscription.TabIndex = 2;
            this.labelDateSouscription.Text = "Date de souscription";
            // 
            // labelDatePaiementSouscription
            // 
            this.labelDatePaiementSouscription.AutoSize = true;
            this.labelDatePaiementSouscription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatePaiementSouscription.Location = new System.Drawing.Point(20, 220);
            this.labelDatePaiementSouscription.Name = "labelDatePaiementSouscription";
            this.labelDatePaiementSouscription.Size = new System.Drawing.Size(133, 19);
            this.labelDatePaiementSouscription.TabIndex = 3;
            this.labelDatePaiementSouscription.Text = "Date de paiement";
            // 
            // labelMontantSouscription
            // 
            this.labelMontantSouscription.AutoSize = true;
            this.labelMontantSouscription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontantSouscription.Location = new System.Drawing.Point(20, 280);
            this.labelMontantSouscription.Name = "labelMontantSouscription";
            this.labelMontantSouscription.Size = new System.Drawing.Size(123, 19);
            this.labelMontantSouscription.TabIndex = 4;
            this.labelMontantSouscription.Text = "Montant à payer";
            // 
            // labelCommentaireSouscription
            // 
            this.labelCommentaireSouscription.AutoSize = true;
            this.labelCommentaireSouscription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentaireSouscription.Location = new System.Drawing.Point(20, 340);
            this.labelCommentaireSouscription.Name = "labelCommentaireSouscription";
            this.labelCommentaireSouscription.Size = new System.Drawing.Size(104, 19);
            this.labelCommentaireSouscription.TabIndex = 5;
            this.labelCommentaireSouscription.Text = "Commentaire";
            // 
            // buttonAnnulerSouscription
            // 
            this.buttonAnnulerSouscription.Location = new System.Drawing.Point(80, 428);
            this.buttonAnnulerSouscription.Name = "buttonAnnulerSouscription";
            this.buttonAnnulerSouscription.Size = new System.Drawing.Size(100, 25);
            this.buttonAnnulerSouscription.TabIndex = 6;
            this.buttonAnnulerSouscription.Text = "Annuler";
            this.buttonAnnulerSouscription.UseVisualStyleBackColor = true;
            this.buttonAnnulerSouscription.Click += new System.EventHandler(this.buttonAnnulerSouscription_Click);
            // 
            // buttonAjouterSouscription
            // 
            this.buttonAjouterSouscription.Location = new System.Drawing.Point(189, 428);
            this.buttonAjouterSouscription.Name = "buttonAjouterSouscription";
            this.buttonAjouterSouscription.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterSouscription.TabIndex = 7;
            this.buttonAjouterSouscription.Text = "Ajouter";
            this.buttonAjouterSouscription.UseVisualStyleBackColor = true;
            this.buttonAjouterSouscription.Click += new System.EventHandler(this.buttonAjouterSouscription_Click);
            // 
            // comboBoxSponsorSouscription
            // 
            this.comboBoxSponsorSouscription.FormattingEnabled = true;
            this.comboBoxSponsorSouscription.Location = new System.Drawing.Point(193, 40);
            this.comboBoxSponsorSouscription.Name = "comboBoxSponsorSouscription";
            this.comboBoxSponsorSouscription.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSponsorSouscription.TabIndex = 8;
            // 
            // comboBoxContratSouscription
            // 
            this.comboBoxContratSouscription.FormattingEnabled = true;
            this.comboBoxContratSouscription.Location = new System.Drawing.Point(193, 100);
            this.comboBoxContratSouscription.Name = "comboBoxContratSouscription";
            this.comboBoxContratSouscription.Size = new System.Drawing.Size(150, 21);
            this.comboBoxContratSouscription.TabIndex = 9;
            // 
            // dateTimePickerDateSouscription
            // 
            this.dateTimePickerDateSouscription.Location = new System.Drawing.Point(193, 160);
            this.dateTimePickerDateSouscription.Name = "dateTimePickerDateSouscription";
            this.dateTimePickerDateSouscription.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDateSouscription.TabIndex = 10;
            // 
            // dateTimePickerPaiementSouscription
            // 
            this.dateTimePickerPaiementSouscription.Location = new System.Drawing.Point(193, 220);
            this.dateTimePickerPaiementSouscription.Name = "dateTimePickerPaiementSouscription";
            this.dateTimePickerPaiementSouscription.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerPaiementSouscription.TabIndex = 11;
            // 
            // textBoxMontantSouscription
            // 
            this.textBoxMontantSouscription.Location = new System.Drawing.Point(193, 280);
            this.textBoxMontantSouscription.Name = "textBoxMontantSouscription";
            this.textBoxMontantSouscription.Size = new System.Drawing.Size(150, 20);
            this.textBoxMontantSouscription.TabIndex = 12;
            // 
            // textBoxCommentaireSouscription
            // 
            this.textBoxCommentaireSouscription.Location = new System.Drawing.Point(193, 340);
            this.textBoxCommentaireSouscription.Name = "textBoxCommentaireSouscription";
            this.textBoxCommentaireSouscription.Size = new System.Drawing.Size(150, 20);
            this.textBoxCommentaireSouscription.TabIndex = 13;
            // 
            // FormAjouterSouscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(374, 501);
            this.Controls.Add(this.textBoxCommentaireSouscription);
            this.Controls.Add(this.textBoxMontantSouscription);
            this.Controls.Add(this.dateTimePickerPaiementSouscription);
            this.Controls.Add(this.dateTimePickerDateSouscription);
            this.Controls.Add(this.comboBoxContratSouscription);
            this.Controls.Add(this.comboBoxSponsorSouscription);
            this.Controls.Add(this.buttonAjouterSouscription);
            this.Controls.Add(this.buttonAnnulerSouscription);
            this.Controls.Add(this.labelCommentaireSouscription);
            this.Controls.Add(this.labelMontantSouscription);
            this.Controls.Add(this.labelDatePaiementSouscription);
            this.Controls.Add(this.labelDateSouscription);
            this.Controls.Add(this.labelContratSouscription);
            this.Controls.Add(this.labelSponsorSouscription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(390, 540);
            this.MinimumSize = new System.Drawing.Size(390, 540);
            this.Name = "FormAjouterSouscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une souscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSponsorSouscription;
        private System.Windows.Forms.Label labelContratSouscription;
        private System.Windows.Forms.Label labelDateSouscription;
        private System.Windows.Forms.Label labelDatePaiementSouscription;
        private System.Windows.Forms.Label labelMontantSouscription;
        private System.Windows.Forms.Label labelCommentaireSouscription;
        private System.Windows.Forms.Button buttonAnnulerSouscription;
        private System.Windows.Forms.Button buttonAjouterSouscription;
        private System.Windows.Forms.ComboBox comboBoxSponsorSouscription;
        private System.Windows.Forms.ComboBox comboBoxContratSouscription;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSouscription;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaiementSouscription;
        private System.Windows.Forms.TextBox textBoxMontantSouscription;
        private System.Windows.Forms.TextBox textBoxCommentaireSouscription;
    }
}