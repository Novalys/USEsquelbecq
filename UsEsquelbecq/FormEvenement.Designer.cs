namespace UsEsquelbecq
{
    partial class FormEvenement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvenement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxEvenementLogo = new System.Windows.Forms.PictureBox();
            this.labelEvenement = new System.Windows.Forms.Label();
            this.dataGridViewEvenement = new System.Windows.Forms.DataGridView();
            this.ColumnIdEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomEvenement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterEvenement = new System.Windows.Forms.Button();
            this.buttonModifierEvenement = new System.Windows.Forms.Button();
            this.buttonSupprimerEvenement = new System.Windows.Forms.Button();
            this.buttonRetourEvenement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvenementLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvenement)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEvenementLogo
            // 
            this.pictureBoxEvenementLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEvenementLogo.Image")));
            this.pictureBoxEvenementLogo.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxEvenementLogo.Name = "pictureBoxEvenementLogo";
            this.pictureBoxEvenementLogo.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxEvenementLogo.TabIndex = 0;
            this.pictureBoxEvenementLogo.TabStop = false;
            // 
            // labelEvenement
            // 
            this.labelEvenement.AutoSize = true;
            this.labelEvenement.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelEvenement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelEvenement.Location = new System.Drawing.Point(505, 80);
            this.labelEvenement.Name = "labelEvenement";
            this.labelEvenement.Size = new System.Drawing.Size(289, 52);
            this.labelEvenement.TabIndex = 1;
            this.labelEvenement.Text = "Événements";
            // 
            // dataGridViewEvenement
            // 
            this.dataGridViewEvenement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvenement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvenement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdEvenement,
            this.ColumnTypeEvenement,
            this.ColumnNomEvenement});
            this.dataGridViewEvenement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewEvenement.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewEvenement.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewEvenement.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewEvenement.MultiSelect = false;
            this.dataGridViewEvenement.Name = "dataGridViewEvenement";
            this.dataGridViewEvenement.ReadOnly = true;
            this.dataGridViewEvenement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvenement.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewEvenement.TabIndex = 2;
            // 
            // ColumnIdEvenement
            // 
            this.ColumnIdEvenement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnIdEvenement.HeaderText = "ID";
            this.ColumnIdEvenement.Name = "ColumnIdEvenement";
            this.ColumnIdEvenement.ReadOnly = true;
            this.ColumnIdEvenement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIdEvenement.Width = 43;
            // 
            // ColumnTypeEvenement
            // 
            this.ColumnTypeEvenement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTypeEvenement.HeaderText = "Type";
            this.ColumnTypeEvenement.Name = "ColumnTypeEvenement";
            this.ColumnTypeEvenement.ReadOnly = true;
            this.ColumnTypeEvenement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnNomEvenement
            // 
            this.ColumnNomEvenement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomEvenement.HeaderText = "Nom";
            this.ColumnNomEvenement.Name = "ColumnNomEvenement";
            this.ColumnNomEvenement.ReadOnly = true;
            this.ColumnNomEvenement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonAjouterEvenement
            // 
            this.buttonAjouterEvenement.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterEvenement.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAjouterEvenement.Name = "buttonAjouterEvenement";
            this.buttonAjouterEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterEvenement.TabIndex = 3;
            this.buttonAjouterEvenement.Text = "Ajouter";
            this.buttonAjouterEvenement.UseVisualStyleBackColor = true;
            this.buttonAjouterEvenement.Click += new System.EventHandler(this.buttonAjouterEvenement_Click);
            // 
            // buttonModifierEvenement
            // 
            this.buttonModifierEvenement.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierEvenement.Margin = new System.Windows.Forms.Padding(10);
            this.buttonModifierEvenement.Name = "buttonModifierEvenement";
            this.buttonModifierEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierEvenement.TabIndex = 4;
            this.buttonModifierEvenement.Text = "Modifier";
            this.buttonModifierEvenement.UseVisualStyleBackColor = true;
            this.buttonModifierEvenement.Click += new System.EventHandler(this.buttonModifierEvenement_Click);
            // 
            // buttonSupprimerEvenement
            // 
            this.buttonSupprimerEvenement.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerEvenement.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSupprimerEvenement.Name = "buttonSupprimerEvenement";
            this.buttonSupprimerEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerEvenement.TabIndex = 5;
            this.buttonSupprimerEvenement.Text = "Supprimer";
            this.buttonSupprimerEvenement.UseVisualStyleBackColor = true;
            this.buttonSupprimerEvenement.Click += new System.EventHandler(this.buttonSupprimerEvenement_Click);
            // 
            // buttonRetourEvenement
            // 
            this.buttonRetourEvenement.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourEvenement.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRetourEvenement.Name = "buttonRetourEvenement";
            this.buttonRetourEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourEvenement.TabIndex = 6;
            this.buttonRetourEvenement.Text = "Retour";
            this.buttonRetourEvenement.UseVisualStyleBackColor = true;
            this.buttonRetourEvenement.Click += new System.EventHandler(this.buttonRetourEvenement_Click);
            // 
            // FormEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourEvenement);
            this.Controls.Add(this.buttonSupprimerEvenement);
            this.Controls.Add(this.buttonModifierEvenement);
            this.Controls.Add(this.buttonAjouterEvenement);
            this.Controls.Add(this.dataGridViewEvenement);
            this.Controls.Add(this.labelEvenement);
            this.Controls.Add(this.pictureBoxEvenementLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormEvenement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq - Événements";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvenementLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvenement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEvenementLogo;
        private System.Windows.Forms.Label labelEvenement;
        private System.Windows.Forms.DataGridView dataGridViewEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomEvenement;
        private System.Windows.Forms.Button buttonAjouterEvenement;
        private System.Windows.Forms.Button buttonModifierEvenement;
        private System.Windows.Forms.Button buttonSupprimerEvenement;
        private System.Windows.Forms.Button buttonRetourEvenement;
    }
}