namespace UsEsquelbecq
{
    partial class FormAjouterPanneau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterPanneau));
            this.labelSponsorPanneau = new System.Windows.Forms.Label();
            this.labelTaillePanneau = new System.Windows.Forms.Label();
            this.labelEtatPanneau = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.buttonAnnulerPanneau = new System.Windows.Forms.Button();
            this.buttonAjouterPanneau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSponsorPanneau
            // 
            this.labelSponsorPanneau.AutoSize = true;
            this.labelSponsorPanneau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSponsorPanneau.Location = new System.Drawing.Point(20, 40);
            this.labelSponsorPanneau.Name = "labelSponsorPanneau";
            this.labelSponsorPanneau.Size = new System.Drawing.Size(67, 19);
            this.labelSponsorPanneau.TabIndex = 0;
            this.labelSponsorPanneau.Text = "Sponsor";
            // 
            // labelTaillePanneau
            // 
            this.labelTaillePanneau.AutoSize = true;
            this.labelTaillePanneau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaillePanneau.Location = new System.Drawing.Point(20, 100);
            this.labelTaillePanneau.Name = "labelTaillePanneau";
            this.labelTaillePanneau.Size = new System.Drawing.Size(47, 19);
            this.labelTaillePanneau.TabIndex = 1;
            this.labelTaillePanneau.Text = "Taille";
            // 
            // labelEtatPanneau
            // 
            this.labelEtatPanneau.AutoSize = true;
            this.labelEtatPanneau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtatPanneau.Location = new System.Drawing.Point(20, 160);
            this.labelEtatPanneau.Name = "labelEtatPanneau";
            this.labelEtatPanneau.Size = new System.Drawing.Size(36, 19);
            this.labelEtatPanneau.TabIndex = 2;
            this.labelEtatPanneau.Text = "État";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(154, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(154, 160);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // buttonAnnulerPanneau
            // 
            this.buttonAnnulerPanneau.Location = new System.Drawing.Point(45, 248);
            this.buttonAnnulerPanneau.Name = "buttonAnnulerPanneau";
            this.buttonAnnulerPanneau.Size = new System.Drawing.Size(100, 25);
            this.buttonAnnulerPanneau.TabIndex = 6;
            this.buttonAnnulerPanneau.Text = "Annuler";
            this.buttonAnnulerPanneau.UseVisualStyleBackColor = true;
            this.buttonAnnulerPanneau.Click += new System.EventHandler(this.buttonAnnulerPanneau_Click);
            // 
            // buttonAjouterPanneau
            // 
            this.buttonAjouterPanneau.Location = new System.Drawing.Point(154, 248);
            this.buttonAjouterPanneau.Name = "buttonAjouterPanneau";
            this.buttonAjouterPanneau.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterPanneau.TabIndex = 7;
            this.buttonAjouterPanneau.Text = "Ajouter";
            this.buttonAjouterPanneau.UseVisualStyleBackColor = true;
            this.buttonAjouterPanneau.Click += new System.EventHandler(this.buttonAjouterPanneau_Click);
            // 
            // FormAjouterPanneau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(304, 321);
            this.Controls.Add(this.buttonAjouterPanneau);
            this.Controls.Add(this.buttonAnnulerPanneau);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelEtatPanneau);
            this.Controls.Add(this.labelTaillePanneau);
            this.Controls.Add(this.labelSponsorPanneau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 360);
            this.MinimumSize = new System.Drawing.Size(320, 360);
            this.Name = "FormAjouterPanneau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSponsorPanneau;
        private System.Windows.Forms.Label labelTaillePanneau;
        private System.Windows.Forms.Label labelEtatPanneau;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button buttonAnnulerPanneau;
        private System.Windows.Forms.Button buttonAjouterPanneau;
    }
}