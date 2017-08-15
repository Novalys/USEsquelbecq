namespace UsEsquelbecq
{
    partial class FormReferent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReferent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogoReferent = new System.Windows.Forms.PictureBox();
            this.labelReferents = new System.Windows.Forms.Label();
            this.dataGridViewReferent = new System.Windows.Forms.DataGridView();
            this.ColumnNomReferent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrenomReferent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSponsorReferent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateReferent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterReferent = new System.Windows.Forms.Button();
            this.buttonModifierReferent = new System.Windows.Forms.Button();
            this.buttonSupprimerReferent = new System.Windows.Forms.Button();
            this.buttonRetourReferent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoReferent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoReferent
            // 
            this.pictureBoxLogoReferent.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoReferent.Image")));
            this.pictureBoxLogoReferent.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxLogoReferent.Name = "pictureBoxLogoReferent";
            this.pictureBoxLogoReferent.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxLogoReferent.TabIndex = 0;
            this.pictureBoxLogoReferent.TabStop = false;
            // 
            // labelReferents
            // 
            this.labelReferents.AutoSize = true;
            this.labelReferents.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelReferents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelReferents.Location = new System.Drawing.Point(532, 80);
            this.labelReferents.Name = "labelReferents";
            this.labelReferents.Size = new System.Drawing.Size(235, 52);
            this.labelReferents.TabIndex = 1;
            this.labelReferents.Text = "Référents";
            // 
            // dataGridViewReferent
            // 
            this.dataGridViewReferent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReferent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewReferent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReferent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomReferent,
            this.ColumnPrenomReferent,
            this.ColumnSponsorReferent,
            this.ColumnDateReferent});
            this.dataGridViewReferent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewReferent.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewReferent.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewReferent.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewReferent.MultiSelect = false;
            this.dataGridViewReferent.Name = "dataGridViewReferent";
            this.dataGridViewReferent.ReadOnly = true;
            this.dataGridViewReferent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReferent.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewReferent.TabIndex = 2;
            // 
            // ColumnNomReferent
            // 
            this.ColumnNomReferent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomReferent.HeaderText = "Nom du référent";
            this.ColumnNomReferent.Name = "ColumnNomReferent";
            this.ColumnNomReferent.ReadOnly = true;
            this.ColumnNomReferent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPrenomReferent
            // 
            this.ColumnPrenomReferent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrenomReferent.HeaderText = "Prénom du référent";
            this.ColumnPrenomReferent.Name = "ColumnPrenomReferent";
            this.ColumnPrenomReferent.ReadOnly = true;
            this.ColumnPrenomReferent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnSponsorReferent
            // 
            this.ColumnSponsorReferent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSponsorReferent.HeaderText = "Sponsor";
            this.ColumnSponsorReferent.Name = "ColumnSponsorReferent";
            this.ColumnSponsorReferent.ReadOnly = true;
            this.ColumnSponsorReferent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDateReferent
            // 
            this.ColumnDateReferent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateReferent.HeaderText = "Date";
            this.ColumnDateReferent.Name = "ColumnDateReferent";
            this.ColumnDateReferent.ReadOnly = true;
            this.ColumnDateReferent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonAjouterReferent
            // 
            this.buttonAjouterReferent.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterReferent.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAjouterReferent.Name = "buttonAjouterReferent";
            this.buttonAjouterReferent.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterReferent.TabIndex = 3;
            this.buttonAjouterReferent.Text = "Ajouter";
            this.buttonAjouterReferent.UseVisualStyleBackColor = true;
            this.buttonAjouterReferent.Click += new System.EventHandler(this.buttonAjouterReferent_Click);
            // 
            // buttonModifierReferent
            // 
            this.buttonModifierReferent.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierReferent.Margin = new System.Windows.Forms.Padding(10);
            this.buttonModifierReferent.Name = "buttonModifierReferent";
            this.buttonModifierReferent.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierReferent.TabIndex = 4;
            this.buttonModifierReferent.Text = "Modifier";
            this.buttonModifierReferent.UseVisualStyleBackColor = true;
            this.buttonModifierReferent.Click += new System.EventHandler(this.buttonModifierReferent_Click);
            // 
            // buttonSupprimerReferent
            // 
            this.buttonSupprimerReferent.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerReferent.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSupprimerReferent.Name = "buttonSupprimerReferent";
            this.buttonSupprimerReferent.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerReferent.TabIndex = 5;
            this.buttonSupprimerReferent.Text = "Supprimer";
            this.buttonSupprimerReferent.UseVisualStyleBackColor = true;
            this.buttonSupprimerReferent.Click += new System.EventHandler(this.buttonSupprimerReferent_Click);
            // 
            // buttonRetourReferent
            // 
            this.buttonRetourReferent.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourReferent.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRetourReferent.Name = "buttonRetourReferent";
            this.buttonRetourReferent.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourReferent.TabIndex = 6;
            this.buttonRetourReferent.Text = "Retour";
            this.buttonRetourReferent.UseVisualStyleBackColor = true;
            this.buttonRetourReferent.Click += new System.EventHandler(this.buttonRetourReferent_Click);
            // 
            // FormReferent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourReferent);
            this.Controls.Add(this.buttonSupprimerReferent);
            this.Controls.Add(this.buttonModifierReferent);
            this.Controls.Add(this.buttonAjouterReferent);
            this.Controls.Add(this.dataGridViewReferent);
            this.Controls.Add(this.labelReferents);
            this.Controls.Add(this.pictureBoxLogoReferent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormReferent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoReferent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoReferent;
        private System.Windows.Forms.Label labelReferents;
        private System.Windows.Forms.DataGridView dataGridViewReferent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomReferent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrenomReferent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSponsorReferent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateReferent;
        private System.Windows.Forms.Button buttonAjouterReferent;
        private System.Windows.Forms.Button buttonModifierReferent;
        private System.Windows.Forms.Button buttonSupprimerReferent;
        private System.Windows.Forms.Button buttonRetourReferent;
    }
}