namespace UsEsquelbecq
{
    partial class FormSouscriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSouscriptions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogoSouscription = new System.Windows.Forms.PictureBox();
            this.labelSouscriptions = new System.Windows.Forms.Label();
            this.dataGridViewSouscription = new System.Windows.Forms.DataGridView();
            this.ColumnSponsorSouscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContratSouscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateContratSouscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDatePaiementSouscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMontantSouscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCommentaireSouscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterSouscription = new System.Windows.Forms.Button();
            this.buttonModifierSouscription = new System.Windows.Forms.Button();
            this.buttonSupprimerSouscription = new System.Windows.Forms.Button();
            this.buttonRetourSouscription = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSouscription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSouscription)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoSouscription
            // 
            this.pictureBoxLogoSouscription.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoSouscription.Image")));
            this.pictureBoxLogoSouscription.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxLogoSouscription.Name = "pictureBoxLogoSouscription";
            this.pictureBoxLogoSouscription.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxLogoSouscription.TabIndex = 0;
            this.pictureBoxLogoSouscription.TabStop = false;
            // 
            // labelSouscriptions
            // 
            this.labelSouscriptions.AutoSize = true;
            this.labelSouscriptions.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelSouscriptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelSouscriptions.Location = new System.Drawing.Point(491, 80);
            this.labelSouscriptions.Name = "labelSouscriptions";
            this.labelSouscriptions.Size = new System.Drawing.Size(317, 52);
            this.labelSouscriptions.TabIndex = 1;
            this.labelSouscriptions.Text = "Souscriptions";
            // 
            // dataGridViewSouscription
            // 
            this.dataGridViewSouscription.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSouscription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSouscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSouscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSponsorSouscription,
            this.ColumnContratSouscription,
            this.ColumnDateContratSouscription,
            this.ColumnDatePaiementSouscription,
            this.ColumnMontantSouscription,
            this.ColumnCommentaireSouscription});
            this.dataGridViewSouscription.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewSouscription.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewSouscription.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewSouscription.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewSouscription.MultiSelect = false;
            this.dataGridViewSouscription.Name = "dataGridViewSouscription";
            this.dataGridViewSouscription.ReadOnly = true;
            this.dataGridViewSouscription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSouscription.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewSouscription.TabIndex = 2;
            // 
            // ColumnSponsorSouscription
            // 
            this.ColumnSponsorSouscription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSponsorSouscription.HeaderText = "Sponsor";
            this.ColumnSponsorSouscription.Name = "ColumnSponsorSouscription";
            this.ColumnSponsorSouscription.ReadOnly = true;
            this.ColumnSponsorSouscription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnContratSouscription
            // 
            this.ColumnContratSouscription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnContratSouscription.HeaderText = "Contrat";
            this.ColumnContratSouscription.Name = "ColumnContratSouscription";
            this.ColumnContratSouscription.ReadOnly = true;
            this.ColumnContratSouscription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDateContratSouscription
            // 
            this.ColumnDateContratSouscription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateContratSouscription.HeaderText = "Date de souscription";
            this.ColumnDateContratSouscription.Name = "ColumnDateContratSouscription";
            this.ColumnDateContratSouscription.ReadOnly = true;
            this.ColumnDateContratSouscription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDatePaiementSouscription
            // 
            this.ColumnDatePaiementSouscription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDatePaiementSouscription.HeaderText = "Date de paiement";
            this.ColumnDatePaiementSouscription.Name = "ColumnDatePaiementSouscription";
            this.ColumnDatePaiementSouscription.ReadOnly = true;
            this.ColumnDatePaiementSouscription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnMontantSouscription
            // 
            this.ColumnMontantSouscription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMontantSouscription.HeaderText = "Montant à payer";
            this.ColumnMontantSouscription.Name = "ColumnMontantSouscription";
            this.ColumnMontantSouscription.ReadOnly = true;
            this.ColumnMontantSouscription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnCommentaireSouscription
            // 
            this.ColumnCommentaireSouscription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCommentaireSouscription.HeaderText = "Commentaire";
            this.ColumnCommentaireSouscription.Name = "ColumnCommentaireSouscription";
            this.ColumnCommentaireSouscription.ReadOnly = true;
            this.ColumnCommentaireSouscription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonAjouterSouscription
            // 
            this.buttonAjouterSouscription.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterSouscription.Name = "buttonAjouterSouscription";
            this.buttonAjouterSouscription.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterSouscription.TabIndex = 3;
            this.buttonAjouterSouscription.Text = "Ajouter";
            this.buttonAjouterSouscription.UseVisualStyleBackColor = true;
            this.buttonAjouterSouscription.Click += new System.EventHandler(this.buttonAjouterSouscription_Click);
            // 
            // buttonModifierSouscription
            // 
            this.buttonModifierSouscription.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierSouscription.Name = "buttonModifierSouscription";
            this.buttonModifierSouscription.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierSouscription.TabIndex = 4;
            this.buttonModifierSouscription.Text = "Modifier";
            this.buttonModifierSouscription.UseVisualStyleBackColor = true;
            this.buttonModifierSouscription.Click += new System.EventHandler(this.buttonModifierSouscription_Click);
            // 
            // buttonSupprimerSouscription
            // 
            this.buttonSupprimerSouscription.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerSouscription.Name = "buttonSupprimerSouscription";
            this.buttonSupprimerSouscription.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerSouscription.TabIndex = 5;
            this.buttonSupprimerSouscription.Text = "Supprimer";
            this.buttonSupprimerSouscription.UseVisualStyleBackColor = true;
            this.buttonSupprimerSouscription.Click += new System.EventHandler(this.buttonSupprimerSouscription_Click);
            // 
            // buttonRetourSouscription
            // 
            this.buttonRetourSouscription.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourSouscription.Name = "buttonRetourSouscription";
            this.buttonRetourSouscription.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourSouscription.TabIndex = 6;
            this.buttonRetourSouscription.Text = "Retour";
            this.buttonRetourSouscription.UseVisualStyleBackColor = true;
            this.buttonRetourSouscription.Click += new System.EventHandler(this.buttonRetourSouscription_Click);
            // 
            // FormSouscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourSouscription);
            this.Controls.Add(this.buttonSupprimerSouscription);
            this.Controls.Add(this.buttonModifierSouscription);
            this.Controls.Add(this.buttonAjouterSouscription);
            this.Controls.Add(this.dataGridViewSouscription);
            this.Controls.Add(this.labelSouscriptions);
            this.Controls.Add(this.pictureBoxLogoSouscription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormSouscriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq - Souscriptions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSouscription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSouscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoSouscription;
        private System.Windows.Forms.Label labelSouscriptions;
        private System.Windows.Forms.DataGridView dataGridViewSouscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSponsorSouscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContratSouscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateContratSouscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDatePaiementSouscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMontantSouscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCommentaireSouscription;
        private System.Windows.Forms.Button buttonAjouterSouscription;
        private System.Windows.Forms.Button buttonModifierSouscription;
        private System.Windows.Forms.Button buttonSupprimerSouscription;
        private System.Windows.Forms.Button buttonRetourSouscription;
    }
}