namespace UsEsquelbecq
{
    partial class FormUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtilisateur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogoUtilisateur = new System.Windows.Forms.PictureBox();
            this.labelUtilisateurs = new System.Windows.Forms.Label();
            this.dataGridViewUtilisateur = new System.Windows.Forms.DataGridView();
            this.ColumnIdUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrenomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMailUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosteUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdresseUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoleUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterUtilisateur = new System.Windows.Forms.Button();
            this.buttonModifierUtilisateur = new System.Windows.Forms.Button();
            this.buttonSupprimerUtilisateur = new System.Windows.Forms.Button();
            this.buttonRetourUtilisateur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoUtilisateur
            // 
            this.pictureBoxLogoUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoUtilisateur.Image")));
            this.pictureBoxLogoUtilisateur.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxLogoUtilisateur.Name = "pictureBoxLogoUtilisateur";
            this.pictureBoxLogoUtilisateur.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxLogoUtilisateur.TabIndex = 8;
            this.pictureBoxLogoUtilisateur.TabStop = false;
            // 
            // labelUtilisateurs
            // 
            this.labelUtilisateurs.AutoSize = true;
            this.labelUtilisateurs.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelUtilisateurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelUtilisateurs.Location = new System.Drawing.Point(513, 80);
            this.labelUtilisateurs.Name = "labelUtilisateurs";
            this.labelUtilisateurs.Size = new System.Drawing.Size(273, 52);
            this.labelUtilisateurs.TabIndex = 9;
            this.labelUtilisateurs.Text = "Utilisateurs";
            // 
            // dataGridViewUtilisateur
            // 
            this.dataGridViewUtilisateur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUtilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdUtilisateur,
            this.ColumnNomUtilisateur,
            this.ColumnPrenomUtilisateur,
            this.ColumnTelUtilisateur,
            this.ColumnMailUtilisateur,
            this.ColumnPosteUtilisateur,
            this.ColumnAdresseUtilisateur,
            this.ColumnRoleUtilisateur});
            this.dataGridViewUtilisateur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewUtilisateur.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewUtilisateur.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewUtilisateur.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewUtilisateur.MultiSelect = false;
            this.dataGridViewUtilisateur.Name = "dataGridViewUtilisateur";
            this.dataGridViewUtilisateur.ReadOnly = true;
            this.dataGridViewUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUtilisateur.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewUtilisateur.TabIndex = 10;
            // 
            // ColumnIdUtilisateur
            // 
            this.ColumnIdUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnIdUtilisateur.HeaderText = "ID";
            this.ColumnIdUtilisateur.Name = "ColumnIdUtilisateur";
            this.ColumnIdUtilisateur.ReadOnly = true;
            this.ColumnIdUtilisateur.Width = 43;
            // 
            // ColumnNomUtilisateur
            // 
            this.ColumnNomUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomUtilisateur.FillWeight = 99.82608F;
            this.ColumnNomUtilisateur.HeaderText = "Nom";
            this.ColumnNomUtilisateur.Name = "ColumnNomUtilisateur";
            this.ColumnNomUtilisateur.ReadOnly = true;
            this.ColumnNomUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPrenomUtilisateur
            // 
            this.ColumnPrenomUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrenomUtilisateur.FillWeight = 100.4597F;
            this.ColumnPrenomUtilisateur.HeaderText = "Prénom";
            this.ColumnPrenomUtilisateur.Name = "ColumnPrenomUtilisateur";
            this.ColumnPrenomUtilisateur.ReadOnly = true;
            this.ColumnPrenomUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTelUtilisateur
            // 
            this.ColumnTelUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTelUtilisateur.FillWeight = 99.78532F;
            this.ColumnTelUtilisateur.HeaderText = "Téléphone";
            this.ColumnTelUtilisateur.Name = "ColumnTelUtilisateur";
            this.ColumnTelUtilisateur.ReadOnly = true;
            this.ColumnTelUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnMailUtilisateur
            // 
            this.ColumnMailUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMailUtilisateur.FillWeight = 99.81593F;
            this.ColumnMailUtilisateur.HeaderText = "Mail";
            this.ColumnMailUtilisateur.Name = "ColumnMailUtilisateur";
            this.ColumnMailUtilisateur.ReadOnly = true;
            this.ColumnMailUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPosteUtilisateur
            // 
            this.ColumnPosteUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPosteUtilisateur.FillWeight = 99.84217F;
            this.ColumnPosteUtilisateur.HeaderText = "Poste";
            this.ColumnPosteUtilisateur.Name = "ColumnPosteUtilisateur";
            this.ColumnPosteUtilisateur.ReadOnly = true;
            this.ColumnPosteUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnAdresseUtilisateur
            // 
            this.ColumnAdresseUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAdresseUtilisateur.FillWeight = 100.4736F;
            this.ColumnAdresseUtilisateur.HeaderText = "Adresse";
            this.ColumnAdresseUtilisateur.Name = "ColumnAdresseUtilisateur";
            this.ColumnAdresseUtilisateur.ReadOnly = true;
            this.ColumnAdresseUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnRoleUtilisateur
            // 
            this.ColumnRoleUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRoleUtilisateur.FillWeight = 99.79713F;
            this.ColumnRoleUtilisateur.HeaderText = "Rôle";
            this.ColumnRoleUtilisateur.Name = "ColumnRoleUtilisateur";
            this.ColumnRoleUtilisateur.ReadOnly = true;
            this.ColumnRoleUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonAjouterUtilisateur
            // 
            this.buttonAjouterUtilisateur.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterUtilisateur.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAjouterUtilisateur.Name = "buttonAjouterUtilisateur";
            this.buttonAjouterUtilisateur.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterUtilisateur.TabIndex = 11;
            this.buttonAjouterUtilisateur.Text = "Ajouter";
            this.buttonAjouterUtilisateur.UseVisualStyleBackColor = true;
            this.buttonAjouterUtilisateur.Click += new System.EventHandler(this.buttonAjouterUtilisateur_Click);
            // 
            // buttonModifierUtilisateur
            // 
            this.buttonModifierUtilisateur.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierUtilisateur.Margin = new System.Windows.Forms.Padding(10);
            this.buttonModifierUtilisateur.Name = "buttonModifierUtilisateur";
            this.buttonModifierUtilisateur.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierUtilisateur.TabIndex = 12;
            this.buttonModifierUtilisateur.Text = "Modifier";
            this.buttonModifierUtilisateur.UseVisualStyleBackColor = true;
            this.buttonModifierUtilisateur.Click += new System.EventHandler(this.buttonModifierUtilisateur_Click);
            // 
            // buttonSupprimerUtilisateur
            // 
            this.buttonSupprimerUtilisateur.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerUtilisateur.Name = "buttonSupprimerUtilisateur";
            this.buttonSupprimerUtilisateur.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerUtilisateur.TabIndex = 13;
            this.buttonSupprimerUtilisateur.Text = "Supprimer";
            this.buttonSupprimerUtilisateur.UseVisualStyleBackColor = true;
            this.buttonSupprimerUtilisateur.Click += new System.EventHandler(this.buttonSupprimerUtilisateur_Click);
            // 
            // buttonRetourUtilisateur
            // 
            this.buttonRetourUtilisateur.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourUtilisateur.Name = "buttonRetourUtilisateur";
            this.buttonRetourUtilisateur.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourUtilisateur.TabIndex = 14;
            this.buttonRetourUtilisateur.Text = "Retour";
            this.buttonRetourUtilisateur.UseVisualStyleBackColor = true;
            this.buttonRetourUtilisateur.Click += new System.EventHandler(this.buttonRetourUtilisateur_Click);
            // 
            // FormUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourUtilisateur);
            this.Controls.Add(this.buttonSupprimerUtilisateur);
            this.Controls.Add(this.buttonModifierUtilisateur);
            this.Controls.Add(this.buttonAjouterUtilisateur);
            this.Controls.Add(this.dataGridViewUtilisateur);
            this.Controls.Add(this.labelUtilisateurs);
            this.Controls.Add(this.pictureBoxLogoUtilisateur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoUtilisateur;
        private System.Windows.Forms.Label labelUtilisateurs;
        private System.Windows.Forms.DataGridView dataGridViewUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrenomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMailUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosteUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdresseUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoleUtilisateur;
        private System.Windows.Forms.Button buttonAjouterUtilisateur;
        private System.Windows.Forms.Button buttonModifierUtilisateur;
        private System.Windows.Forms.Button buttonSupprimerUtilisateur;
        private System.Windows.Forms.Button buttonRetourUtilisateur;
    }
}