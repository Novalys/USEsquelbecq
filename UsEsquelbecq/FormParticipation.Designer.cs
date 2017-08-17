namespace UsEsquelbecq
{
    partial class FormParticipation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParticipation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogoEvenement = new System.Windows.Forms.PictureBox();
            this.labelEvenements = new System.Windows.Forms.Label();
            this.dataGridViewParticipation = new System.Windows.Forms.DataGridView();
            this.ColumnNomEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSponsorEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterParticpation = new System.Windows.Forms.Button();
            this.buttonModifierParticpation = new System.Windows.Forms.Button();
            this.buttonSupprimerParticpation = new System.Windows.Forms.Button();
            this.buttonRetourParticpation = new System.Windows.Forms.Button();
            this.buttonEvenement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEvenement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipation)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoEvenement
            // 
            this.pictureBoxLogoEvenement.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoEvenement.Image")));
            this.pictureBoxLogoEvenement.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxLogoEvenement.Name = "pictureBoxLogoEvenement";
            this.pictureBoxLogoEvenement.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxLogoEvenement.TabIndex = 0;
            this.pictureBoxLogoEvenement.TabStop = false;
            // 
            // labelEvenements
            // 
            this.labelEvenements.AutoSize = true;
            this.labelEvenements.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelEvenements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelEvenements.Location = new System.Drawing.Point(488, 80);
            this.labelEvenements.Name = "labelEvenements";
            this.labelEvenements.Size = new System.Drawing.Size(324, 52);
            this.labelEvenements.TabIndex = 1;
            this.labelEvenements.Text = "Participations";
            // 
            // dataGridViewParticipation
            // 
            this.dataGridViewParticipation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParticipation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomEvenement,
            this.ColumnTypeEvenement,
            this.ColumnSponsorEvenement,
            this.ColumnDateEvenement});
            this.dataGridViewParticipation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewParticipation.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewParticipation.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewParticipation.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewParticipation.MultiSelect = false;
            this.dataGridViewParticipation.Name = "dataGridViewParticipation";
            this.dataGridViewParticipation.ReadOnly = true;
            this.dataGridViewParticipation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticipation.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewParticipation.TabIndex = 2;
            // 
            // ColumnNomEvenement
            // 
            this.ColumnNomEvenement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomEvenement.HeaderText = "Nom";
            this.ColumnNomEvenement.Name = "ColumnNomEvenement";
            this.ColumnNomEvenement.ReadOnly = true;
            this.ColumnNomEvenement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTypeEvenement
            // 
            this.ColumnTypeEvenement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTypeEvenement.HeaderText = "Type";
            this.ColumnTypeEvenement.Name = "ColumnTypeEvenement";
            this.ColumnTypeEvenement.ReadOnly = true;
            this.ColumnTypeEvenement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnSponsorEvenement
            // 
            this.ColumnSponsorEvenement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSponsorEvenement.HeaderText = "Sponsor";
            this.ColumnSponsorEvenement.Name = "ColumnSponsorEvenement";
            this.ColumnSponsorEvenement.ReadOnly = true;
            this.ColumnSponsorEvenement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDateEvenement
            // 
            this.ColumnDateEvenement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateEvenement.HeaderText = "Date";
            this.ColumnDateEvenement.Name = "ColumnDateEvenement";
            this.ColumnDateEvenement.ReadOnly = true;
            this.ColumnDateEvenement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonAjouterParticpation
            // 
            this.buttonAjouterParticpation.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterParticpation.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAjouterParticpation.Name = "buttonAjouterParticpation";
            this.buttonAjouterParticpation.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterParticpation.TabIndex = 3;
            this.buttonAjouterParticpation.Text = "Ajouter";
            this.buttonAjouterParticpation.UseVisualStyleBackColor = true;
            this.buttonAjouterParticpation.Click += new System.EventHandler(this.buttonAjouterParticpation_Click);
            // 
            // buttonModifierParticpation
            // 
            this.buttonModifierParticpation.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierParticpation.Margin = new System.Windows.Forms.Padding(10);
            this.buttonModifierParticpation.Name = "buttonModifierParticpation";
            this.buttonModifierParticpation.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierParticpation.TabIndex = 4;
            this.buttonModifierParticpation.Text = "Modifier";
            this.buttonModifierParticpation.UseVisualStyleBackColor = true;
            this.buttonModifierParticpation.Click += new System.EventHandler(this.buttonModifierParticpation_Click);
            // 
            // buttonSupprimerParticpation
            // 
            this.buttonSupprimerParticpation.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerParticpation.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSupprimerParticpation.Name = "buttonSupprimerParticpation";
            this.buttonSupprimerParticpation.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerParticpation.TabIndex = 5;
            this.buttonSupprimerParticpation.Text = "Supprimer";
            this.buttonSupprimerParticpation.UseVisualStyleBackColor = true;
            this.buttonSupprimerParticpation.Click += new System.EventHandler(this.buttonSupprimerParticpation_Click);
            // 
            // buttonRetourParticpation
            // 
            this.buttonRetourParticpation.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourParticpation.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRetourParticpation.Name = "buttonRetourParticpation";
            this.buttonRetourParticpation.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourParticpation.TabIndex = 6;
            this.buttonRetourParticpation.Text = "Retour";
            this.buttonRetourParticpation.UseVisualStyleBackColor = true;
            this.buttonRetourParticpation.Click += new System.EventHandler(this.buttonRetourParticpation_Click);
            // 
            // buttonEvenement
            // 
            this.buttonEvenement.Location = new System.Drawing.Point(1160, 160);
            this.buttonEvenement.Name = "buttonEvenement";
            this.buttonEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonEvenement.TabIndex = 7;
            this.buttonEvenement.Text = "Événements";
            this.buttonEvenement.UseVisualStyleBackColor = true;
            this.buttonEvenement.Click += new System.EventHandler(this.buttonEvenement_Click);
            // 
            // FormParticipation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonEvenement);
            this.Controls.Add(this.buttonRetourParticpation);
            this.Controls.Add(this.buttonSupprimerParticpation);
            this.Controls.Add(this.buttonModifierParticpation);
            this.Controls.Add(this.buttonAjouterParticpation);
            this.Controls.Add(this.dataGridViewParticipation);
            this.Controls.Add(this.labelEvenements);
            this.Controls.Add(this.pictureBoxLogoEvenement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormParticipation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq - Participations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEvenement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoEvenement;
        private System.Windows.Forms.Label labelEvenements;
        private System.Windows.Forms.DataGridView dataGridViewParticipation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSponsorEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateEvenement;
        private System.Windows.Forms.Button buttonAjouterParticpation;
        private System.Windows.Forms.Button buttonModifierParticpation;
        private System.Windows.Forms.Button buttonSupprimerParticpation;
        private System.Windows.Forms.Button buttonRetourParticpation;
        private System.Windows.Forms.Button buttonEvenement;
    }
}