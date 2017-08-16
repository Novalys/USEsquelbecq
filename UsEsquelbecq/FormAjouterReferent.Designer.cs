namespace UsEsquelbecq
{
    partial class FormAjouterReferent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterReferent));
            this.labelNomPrenomReferent = new System.Windows.Forms.Label();
            this.labelSponsorReferent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNomPrenomReferent = new System.Windows.Forms.ComboBox();
            this.comboBoxSponsorReferent = new System.Windows.Forms.ComboBox();
            this.dateTimePickerReferent = new System.Windows.Forms.DateTimePicker();
            this.buttonAnnulerReferent = new System.Windows.Forms.Button();
            this.buttonAjouterReferent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomPrenomReferent
            // 
            this.labelNomPrenomReferent.AutoSize = true;
            this.labelNomPrenomReferent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPrenomReferent.Location = new System.Drawing.Point(20, 40);
            this.labelNomPrenomReferent.Name = "labelNomPrenomReferent";
            this.labelNomPrenomReferent.Size = new System.Drawing.Size(68, 19);
            this.labelNomPrenomReferent.TabIndex = 0;
            this.labelNomPrenomReferent.Text = "Référent";
            // 
            // labelSponsorReferent
            // 
            this.labelSponsorReferent.AutoSize = true;
            this.labelSponsorReferent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSponsorReferent.Location = new System.Drawing.Point(20, 100);
            this.labelSponsorReferent.Name = "labelSponsorReferent";
            this.labelSponsorReferent.Size = new System.Drawing.Size(67, 19);
            this.labelSponsorReferent.TabIndex = 2;
            this.labelSponsorReferent.Text = "Sponsor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // comboBoxNomPrenomReferent
            // 
            this.comboBoxNomPrenomReferent.FormattingEnabled = true;
            this.comboBoxNomPrenomReferent.Location = new System.Drawing.Point(164, 40);
            this.comboBoxNomPrenomReferent.Name = "comboBoxNomPrenomReferent";
            this.comboBoxNomPrenomReferent.Size = new System.Drawing.Size(160, 21);
            this.comboBoxNomPrenomReferent.TabIndex = 4;
            // 
            // comboBoxSponsorReferent
            // 
            this.comboBoxSponsorReferent.FormattingEnabled = true;
            this.comboBoxSponsorReferent.Location = new System.Drawing.Point(164, 100);
            this.comboBoxSponsorReferent.Name = "comboBoxSponsorReferent";
            this.comboBoxSponsorReferent.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSponsorReferent.TabIndex = 6;
            // 
            // dateTimePickerReferent
            // 
            this.dateTimePickerReferent.Location = new System.Drawing.Point(164, 160);
            this.dateTimePickerReferent.Name = "dateTimePickerReferent";
            this.dateTimePickerReferent.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerReferent.TabIndex = 7;
            // 
            // buttonAnnulerReferent
            // 
            this.buttonAnnulerReferent.Location = new System.Drawing.Point(65, 248);
            this.buttonAnnulerReferent.Name = "buttonAnnulerReferent";
            this.buttonAnnulerReferent.Size = new System.Drawing.Size(100, 25);
            this.buttonAnnulerReferent.TabIndex = 8;
            this.buttonAnnulerReferent.Text = "Annuler";
            this.buttonAnnulerReferent.UseVisualStyleBackColor = true;
            this.buttonAnnulerReferent.Click += new System.EventHandler(this.buttonAnnulerReferent_Click);
            // 
            // buttonAjouterReferent
            // 
            this.buttonAjouterReferent.Location = new System.Drawing.Point(174, 248);
            this.buttonAjouterReferent.Name = "buttonAjouterReferent";
            this.buttonAjouterReferent.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterReferent.TabIndex = 9;
            this.buttonAjouterReferent.Text = "Ajouter";
            this.buttonAjouterReferent.UseVisualStyleBackColor = true;
            this.buttonAjouterReferent.Click += new System.EventHandler(this.buttonAjouterReferent_Click);
            // 
            // FormAjouterReferent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.buttonAjouterReferent);
            this.Controls.Add(this.buttonAnnulerReferent);
            this.Controls.Add(this.dateTimePickerReferent);
            this.Controls.Add(this.comboBoxSponsorReferent);
            this.Controls.Add(this.comboBoxNomPrenomReferent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSponsorReferent);
            this.Controls.Add(this.labelNomPrenomReferent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 360);
            this.MinimumSize = new System.Drawing.Size(360, 360);
            this.Name = "FormAjouterReferent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un référent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomPrenomReferent;
        private System.Windows.Forms.Label labelSponsorReferent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNomPrenomReferent;
        private System.Windows.Forms.ComboBox comboBoxSponsorReferent;
        private System.Windows.Forms.DateTimePicker dateTimePickerReferent;
        private System.Windows.Forms.Button buttonAnnulerReferent;
        private System.Windows.Forms.Button buttonAjouterReferent;
    }
}