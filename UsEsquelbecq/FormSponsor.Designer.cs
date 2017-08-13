namespace UsEsquelbecq
{
    partial class FormSponsor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSponsor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogoContrat = new System.Windows.Forms.PictureBox();
            this.labelSponsors = new System.Windows.Forms.Label();
            this.dataGridViewContrat = new System.Windows.Forms.DataGridView();
            this.ColumnIdContrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResponsableSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdresseSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContactSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReferentSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContratSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMontantSponsor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterSponsor = new System.Windows.Forms.Button();
            this.buttonModifierSponsor = new System.Windows.Forms.Button();
            this.buttonSupprimerSponsor = new System.Windows.Forms.Button();
            this.buttonRetourSponsor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoContrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoContrat
            // 
            this.pictureBoxLogoContrat.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoContrat.Image")));
            this.pictureBoxLogoContrat.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxLogoContrat.Name = "pictureBoxLogoContrat";
            this.pictureBoxLogoContrat.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxLogoContrat.TabIndex = 0;
            this.pictureBoxLogoContrat.TabStop = false;
            // 
            // labelSponsors
            // 
            this.labelSponsors.AutoSize = true;
            this.labelSponsors.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelSponsors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelSponsors.Location = new System.Drawing.Point(539, 80);
            this.labelSponsors.Name = "labelSponsors";
            this.labelSponsors.Size = new System.Drawing.Size(222, 52);
            this.labelSponsors.TabIndex = 1;
            this.labelSponsors.Text = "Sponsors";
            // 
            // dataGridViewContrat
            // 
            this.dataGridViewContrat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContrat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContrat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdContrat,
            this.ColumnNomSponsor,
            this.ColumnResponsableSponsor,
            this.ColumnAdresseSponsor,
            this.ColumnContactSponsor,
            this.ColumnReferentSponsor,
            this.ColumnContratSponsor,
            this.ColumnDateSponsor,
            this.ColumnMontantSponsor});
            this.dataGridViewContrat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewContrat.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewContrat.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewContrat.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewContrat.MultiSelect = false;
            this.dataGridViewContrat.Name = "dataGridViewContrat";
            this.dataGridViewContrat.ReadOnly = true;
            this.dataGridViewContrat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContrat.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewContrat.TabIndex = 2;
            // 
            // ColumnIdContrat
            // 
            this.ColumnIdContrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnIdContrat.HeaderText = "ID";
            this.ColumnIdContrat.Name = "ColumnIdContrat";
            this.ColumnIdContrat.ReadOnly = true;
            this.ColumnIdContrat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIdContrat.Width = 43;
            // 
            // ColumnNomSponsor
            // 
            this.ColumnNomSponsor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomSponsor.HeaderText = "Nom";
            this.ColumnNomSponsor.Name = "ColumnNomSponsor";
            this.ColumnNomSponsor.ReadOnly = true;
            this.ColumnNomSponsor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnResponsableSponsor
            // 
            this.ColumnResponsableSponsor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnResponsableSponsor.HeaderText = "Responsable";
            this.ColumnResponsableSponsor.Name = "ColumnResponsableSponsor";
            this.ColumnResponsableSponsor.ReadOnly = true;
            this.ColumnResponsableSponsor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnAdresseSponsor
            // 
            this.ColumnAdresseSponsor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAdresseSponsor.HeaderText = "Adresse";
            this.ColumnAdresseSponsor.Name = "ColumnAdresseSponsor";
            this.ColumnAdresseSponsor.ReadOnly = true;
            this.ColumnAdresseSponsor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnContactSponsor
            // 
            this.ColumnContactSponsor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnContactSponsor.HeaderText = "Contact";
            this.ColumnContactSponsor.Name = "ColumnContactSponsor";
            this.ColumnContactSponsor.ReadOnly = true;
            this.ColumnContactSponsor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnReferentSponsor
            // 
            this.ColumnReferentSponsor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnReferentSponsor.HeaderText = "Référent";
            this.ColumnReferentSponsor.Name = "ColumnReferentSponsor";
            this.ColumnReferentSponsor.ReadOnly = true;
            this.ColumnReferentSponsor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnContratSponsor
            // 
            this.ColumnContratSponsor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnContratSponsor.HeaderText = "Contrat";
            this.ColumnContratSponsor.Name = "ColumnContratSponsor";
            this.ColumnContratSponsor.ReadOnly = true;
            this.ColumnContratSponsor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDateSponsor
            // 
            this.ColumnDateSponsor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateSponsor.HeaderText = "Date de paiement";
            this.ColumnDateSponsor.Name = "ColumnDateSponsor";
            this.ColumnDateSponsor.ReadOnly = true;
            this.ColumnDateSponsor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnMontantSponsor
            // 
            this.ColumnMontantSponsor.HeaderText = "Montant à payer";
            this.ColumnMontantSponsor.Name = "ColumnMontantSponsor";
            this.ColumnMontantSponsor.ReadOnly = true;
            // 
            // buttonAjouterSponsor
            // 
            this.buttonAjouterSponsor.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterSponsor.Name = "buttonAjouterSponsor";
            this.buttonAjouterSponsor.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterSponsor.TabIndex = 3;
            this.buttonAjouterSponsor.Text = "Ajouter";
            this.buttonAjouterSponsor.UseVisualStyleBackColor = true;
            this.buttonAjouterSponsor.Click += new System.EventHandler(this.buttonAjouterSponsor_Click);
            // 
            // buttonModifierSponsor
            // 
            this.buttonModifierSponsor.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierSponsor.Name = "buttonModifierSponsor";
            this.buttonModifierSponsor.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierSponsor.TabIndex = 4;
            this.buttonModifierSponsor.Text = "Modifier";
            this.buttonModifierSponsor.UseVisualStyleBackColor = true;
            this.buttonModifierSponsor.Click += new System.EventHandler(this.buttonModifierSponsor_Click);
            // 
            // buttonSupprimerSponsor
            // 
            this.buttonSupprimerSponsor.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerSponsor.Name = "buttonSupprimerSponsor";
            this.buttonSupprimerSponsor.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerSponsor.TabIndex = 5;
            this.buttonSupprimerSponsor.Text = "Supprimer";
            this.buttonSupprimerSponsor.UseVisualStyleBackColor = true;
            this.buttonSupprimerSponsor.Click += new System.EventHandler(this.buttonSupprimerSponsor_Click);
            // 
            // buttonRetourSponsor
            // 
            this.buttonRetourSponsor.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourSponsor.Name = "buttonRetourSponsor";
            this.buttonRetourSponsor.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourSponsor.TabIndex = 6;
            this.buttonRetourSponsor.Text = "Retour";
            this.buttonRetourSponsor.UseVisualStyleBackColor = true;
            this.buttonRetourSponsor.Click += new System.EventHandler(this.buttonRetourSponsor_Click);
            // 
            // FormSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourSponsor);
            this.Controls.Add(this.buttonSupprimerSponsor);
            this.Controls.Add(this.buttonModifierSponsor);
            this.Controls.Add(this.buttonAjouterSponsor);
            this.Controls.Add(this.dataGridViewContrat);
            this.Controls.Add(this.labelSponsors);
            this.Controls.Add(this.pictureBoxLogoContrat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormSponsor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoContrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoContrat;
        private System.Windows.Forms.Label labelSponsors;
        private System.Windows.Forms.DataGridView dataGridViewContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResponsableSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdresseSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContactSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReferentSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContratSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateSponsor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMontantSponsor;
        private System.Windows.Forms.Button buttonAjouterSponsor;
        private System.Windows.Forms.Button buttonModifierSponsor;
        private System.Windows.Forms.Button buttonSupprimerSponsor;
        private System.Windows.Forms.Button buttonRetourSponsor;
    }
}