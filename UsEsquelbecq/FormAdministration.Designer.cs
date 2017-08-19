namespace UsEsquelbecq
{
    partial class FormAdministration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogoAdministration = new System.Windows.Forms.PictureBox();
            this.labelAdministration = new System.Windows.Forms.Label();
            this.dataGridViewAdministration = new System.Windows.Forms.DataGridView();
            this.ColumnIdUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrenomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMailUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosteUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdresseUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoleUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMDP = new System.Windows.Forms.Button();
            this.buttonRetourAdministration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAdministration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministration)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoAdministration
            // 
            this.pictureBoxLogoAdministration.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoAdministration.Image")));
            this.pictureBoxLogoAdministration.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxLogoAdministration.Name = "pictureBoxLogoAdministration";
            this.pictureBoxLogoAdministration.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxLogoAdministration.TabIndex = 0;
            this.pictureBoxLogoAdministration.TabStop = false;
            // 
            // labelAdministration
            // 
            this.labelAdministration.AutoSize = true;
            this.labelAdministration.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelAdministration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelAdministration.Location = new System.Drawing.Point(477, 80);
            this.labelAdministration.Name = "labelAdministration";
            this.labelAdministration.Size = new System.Drawing.Size(345, 52);
            this.labelAdministration.TabIndex = 1;
            this.labelAdministration.Text = "Administration";
            // 
            // dataGridViewAdministration
            // 
            this.dataGridViewAdministration.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdministration.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAdministration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdministration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdUtilisateur,
            this.ColumnNomUtilisateur,
            this.ColumnPrenomUtilisateur,
            this.ColumnTelUtilisateur,
            this.ColumnMailUtilisateur,
            this.ColumnPosteUtilisateur,
            this.ColumnAdresseUtilisateur,
            this.ColumnRoleUtilisateur});
            this.dataGridViewAdministration.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewAdministration.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewAdministration.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewAdministration.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewAdministration.MultiSelect = false;
            this.dataGridViewAdministration.Name = "dataGridViewAdministration";
            this.dataGridViewAdministration.ReadOnly = true;
            this.dataGridViewAdministration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdministration.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewAdministration.TabIndex = 2;
            // 
            // ColumnIdUtilisateur
            // 
            this.ColumnIdUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnIdUtilisateur.HeaderText = "ID";
            this.ColumnIdUtilisateur.Name = "ColumnIdUtilisateur";
            this.ColumnIdUtilisateur.ReadOnly = true;
            this.ColumnIdUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIdUtilisateur.Width = 43;
            // 
            // ColumnNomUtilisateur
            // 
            this.ColumnNomUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomUtilisateur.HeaderText = "Nom";
            this.ColumnNomUtilisateur.Name = "ColumnNomUtilisateur";
            this.ColumnNomUtilisateur.ReadOnly = true;
            this.ColumnNomUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPrenomUtilisateur
            // 
            this.ColumnPrenomUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrenomUtilisateur.HeaderText = "Prénom";
            this.ColumnPrenomUtilisateur.Name = "ColumnPrenomUtilisateur";
            this.ColumnPrenomUtilisateur.ReadOnly = true;
            this.ColumnPrenomUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTelUtilisateur
            // 
            this.ColumnTelUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTelUtilisateur.HeaderText = "Téléphone";
            this.ColumnTelUtilisateur.Name = "ColumnTelUtilisateur";
            this.ColumnTelUtilisateur.ReadOnly = true;
            this.ColumnTelUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnMailUtilisateur
            // 
            this.ColumnMailUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMailUtilisateur.HeaderText = "Mail";
            this.ColumnMailUtilisateur.Name = "ColumnMailUtilisateur";
            this.ColumnMailUtilisateur.ReadOnly = true;
            this.ColumnMailUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPosteUtilisateur
            // 
            this.ColumnPosteUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPosteUtilisateur.HeaderText = "Poste";
            this.ColumnPosteUtilisateur.Name = "ColumnPosteUtilisateur";
            this.ColumnPosteUtilisateur.ReadOnly = true;
            this.ColumnPosteUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnAdresseUtilisateur
            // 
            this.ColumnAdresseUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAdresseUtilisateur.HeaderText = "Adresse";
            this.ColumnAdresseUtilisateur.Name = "ColumnAdresseUtilisateur";
            this.ColumnAdresseUtilisateur.ReadOnly = true;
            this.ColumnAdresseUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnRoleUtilisateur
            // 
            this.ColumnRoleUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRoleUtilisateur.HeaderText = "Rôle";
            this.ColumnRoleUtilisateur.Name = "ColumnRoleUtilisateur";
            this.ColumnRoleUtilisateur.ReadOnly = true;
            this.ColumnRoleUtilisateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonMDP
            // 
            this.buttonMDP.Location = new System.Drawing.Point(1110, 707);
            this.buttonMDP.Name = "buttonMDP";
            this.buttonMDP.Size = new System.Drawing.Size(150, 25);
            this.buttonMDP.TabIndex = 3;
            this.buttonMDP.Text = "Assigner un mot de passe";
            this.buttonMDP.UseVisualStyleBackColor = true;
            this.buttonMDP.Click += new System.EventHandler(this.buttonMDP_Click);
            // 
            // buttonRetourAdministration
            // 
            this.buttonRetourAdministration.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourAdministration.Name = "buttonRetourAdministration";
            this.buttonRetourAdministration.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourAdministration.TabIndex = 4;
            this.buttonRetourAdministration.Text = "Retour";
            this.buttonRetourAdministration.UseVisualStyleBackColor = true;
            this.buttonRetourAdministration.Click += new System.EventHandler(this.buttonRetourAdministration_Click);
            // 
            // FormAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourAdministration);
            this.Controls.Add(this.buttonMDP);
            this.Controls.Add(this.dataGridViewAdministration);
            this.Controls.Add(this.labelAdministration);
            this.Controls.Add(this.pictureBoxLogoAdministration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq - Administration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoAdministration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoAdministration;
        private System.Windows.Forms.Label labelAdministration;
        private System.Windows.Forms.DataGridView dataGridViewAdministration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrenomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMailUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosteUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdresseUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoleUtilisateur;
        private System.Windows.Forms.Button buttonMDP;
        private System.Windows.Forms.Button buttonRetourAdministration;
    }
}