namespace UsEsquelbecq
{
    partial class FormPanneau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanneau));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogoPanneau = new System.Windows.Forms.PictureBox();
            this.labelPanneaux = new System.Windows.Forms.Label();
            this.dataGridViewPanneau = new System.Windows.Forms.DataGridView();
            this.buttonAjouterPanneau = new System.Windows.Forms.Button();
            this.buttonModifierPanneau = new System.Windows.Forms.Button();
            this.buttonSupprimerPanneau = new System.Windows.Forms.Button();
            this.buttonRetourPanneau = new System.Windows.Forms.Button();
            this.ColumnIdPanneau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomSponsorPanneau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaillePanneau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEtatPanneau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoPanneau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanneau)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoPanneau
            // 
            this.pictureBoxLogoPanneau.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoPanneau.Image")));
            this.pictureBoxLogoPanneau.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxLogoPanneau.Name = "pictureBoxLogoPanneau";
            this.pictureBoxLogoPanneau.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxLogoPanneau.TabIndex = 0;
            this.pictureBoxLogoPanneau.TabStop = false;
            // 
            // labelPanneaux
            // 
            this.labelPanneaux.AutoSize = true;
            this.labelPanneaux.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelPanneaux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelPanneaux.Location = new System.Drawing.Point(530, 80);
            this.labelPanneaux.Name = "labelPanneaux";
            this.labelPanneaux.Size = new System.Drawing.Size(239, 52);
            this.labelPanneaux.TabIndex = 1;
            this.labelPanneaux.Text = "Panneaux";
            // 
            // dataGridViewPanneau
            // 
            this.dataGridViewPanneau.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPanneau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPanneau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPanneau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdPanneau,
            this.ColumnNomSponsorPanneau,
            this.ColumnTaillePanneau,
            this.ColumnEtatPanneau});
            this.dataGridViewPanneau.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewPanneau.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewPanneau.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewPanneau.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewPanneau.MultiSelect = false;
            this.dataGridViewPanneau.Name = "dataGridViewPanneau";
            this.dataGridViewPanneau.ReadOnly = true;
            this.dataGridViewPanneau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPanneau.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewPanneau.TabIndex = 2;
            // 
            // buttonAjouterPanneau
            // 
            this.buttonAjouterPanneau.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterPanneau.Name = "buttonAjouterPanneau";
            this.buttonAjouterPanneau.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterPanneau.TabIndex = 3;
            this.buttonAjouterPanneau.Text = "Ajouter";
            this.buttonAjouterPanneau.UseVisualStyleBackColor = true;
            this.buttonAjouterPanneau.Click += new System.EventHandler(this.buttonAjouterPanneau_Click);
            // 
            // buttonModifierPanneau
            // 
            this.buttonModifierPanneau.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierPanneau.Name = "buttonModifierPanneau";
            this.buttonModifierPanneau.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierPanneau.TabIndex = 4;
            this.buttonModifierPanneau.Text = "Modifier";
            this.buttonModifierPanneau.UseVisualStyleBackColor = true;
            this.buttonModifierPanneau.Click += new System.EventHandler(this.buttonModifierPanneau_Click);
            // 
            // buttonSupprimerPanneau
            // 
            this.buttonSupprimerPanneau.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerPanneau.Name = "buttonSupprimerPanneau";
            this.buttonSupprimerPanneau.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerPanneau.TabIndex = 5;
            this.buttonSupprimerPanneau.Text = "Supprimer";
            this.buttonSupprimerPanneau.UseVisualStyleBackColor = true;
            this.buttonSupprimerPanneau.Click += new System.EventHandler(this.buttonSupprimerPanneau_Click);
            // 
            // buttonRetourPanneau
            // 
            this.buttonRetourPanneau.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourPanneau.Name = "buttonRetourPanneau";
            this.buttonRetourPanneau.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourPanneau.TabIndex = 6;
            this.buttonRetourPanneau.Text = "Retour";
            this.buttonRetourPanneau.UseVisualStyleBackColor = true;
            this.buttonRetourPanneau.Click += new System.EventHandler(this.buttonRetourPanneau_Click);
            // 
            // ColumnIdPanneau
            // 
            this.ColumnIdPanneau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnIdPanneau.HeaderText = "ID";
            this.ColumnIdPanneau.Name = "ColumnIdPanneau";
            this.ColumnIdPanneau.ReadOnly = true;
            this.ColumnIdPanneau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIdPanneau.Width = 43;
            // 
            // ColumnNomSponsorPanneau
            // 
            this.ColumnNomSponsorPanneau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomSponsorPanneau.HeaderText = "Sponsor";
            this.ColumnNomSponsorPanneau.Name = "ColumnNomSponsorPanneau";
            this.ColumnNomSponsorPanneau.ReadOnly = true;
            this.ColumnNomSponsorPanneau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTaillePanneau
            // 
            this.ColumnTaillePanneau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTaillePanneau.HeaderText = "Taille";
            this.ColumnTaillePanneau.Name = "ColumnTaillePanneau";
            this.ColumnTaillePanneau.ReadOnly = true;
            this.ColumnTaillePanneau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnEtatPanneau
            // 
            this.ColumnEtatPanneau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEtatPanneau.HeaderText = "État";
            this.ColumnEtatPanneau.Name = "ColumnEtatPanneau";
            this.ColumnEtatPanneau.ReadOnly = true;
            this.ColumnEtatPanneau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormPanneau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourPanneau);
            this.Controls.Add(this.buttonSupprimerPanneau);
            this.Controls.Add(this.buttonModifierPanneau);
            this.Controls.Add(this.buttonAjouterPanneau);
            this.Controls.Add(this.dataGridViewPanneau);
            this.Controls.Add(this.labelPanneaux);
            this.Controls.Add(this.pictureBoxLogoPanneau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormPanneau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoPanneau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPanneau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoPanneau;
        private System.Windows.Forms.Label labelPanneaux;
        private System.Windows.Forms.DataGridView dataGridViewPanneau;
        private System.Windows.Forms.Button buttonAjouterPanneau;
        private System.Windows.Forms.Button buttonModifierPanneau;
        private System.Windows.Forms.Button buttonSupprimerPanneau;
        private System.Windows.Forms.Button buttonRetourPanneau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPanneau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomSponsorPanneau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaillePanneau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEtatPanneau;
    }
}