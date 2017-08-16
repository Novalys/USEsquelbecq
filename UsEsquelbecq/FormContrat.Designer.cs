namespace UsEsquelbecq
{
    partial class FormContrat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContrat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelContrats = new System.Windows.Forms.Label();
            this.dataGridViewContrat = new System.Windows.Forms.DataGridView();
            this.ColumnIdContrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeContrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrixIniContrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrixRenContrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTailleContrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterContrat = new System.Windows.Forms.Button();
            this.buttonModifierContrat = new System.Windows.Forms.Button();
            this.buttonSupprimerContrat = new System.Windows.Forms.Button();
            this.buttonRetourContrat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelContrats
            // 
            this.labelContrats.AutoSize = true;
            this.labelContrats.Font = new System.Drawing.Font("Tahoma", 32.75F, System.Drawing.FontStyle.Bold);
            this.labelContrats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelContrats.Location = new System.Drawing.Point(544, 80);
            this.labelContrats.Name = "labelContrats";
            this.labelContrats.Size = new System.Drawing.Size(211, 53);
            this.labelContrats.TabIndex = 1;
            this.labelContrats.Text = "Contrats";
            // 
            // dataGridViewContrat
            // 
            this.dataGridViewContrat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContrat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContrat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContrat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdContrat,
            this.ColumnTypeContrat,
            this.ColumnPrixIniContrat,
            this.ColumnPrixRenContrat,
            this.ColumnTailleContrat});
            this.dataGridViewContrat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewContrat.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewContrat.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewContrat.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewContrat.MultiSelect = false;
            this.dataGridViewContrat.Name = "dataGridViewContrat";
            this.dataGridViewContrat.ReadOnly = true;
            this.dataGridViewContrat.RowTemplate.ReadOnly = true;
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
            // ColumnTypeContrat
            // 
            this.ColumnTypeContrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTypeContrat.HeaderText = "Type";
            this.ColumnTypeContrat.Name = "ColumnTypeContrat";
            this.ColumnTypeContrat.ReadOnly = true;
            this.ColumnTypeContrat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPrixIniContrat
            // 
            this.ColumnPrixIniContrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrixIniContrat.HeaderText = "Prix initial";
            this.ColumnPrixIniContrat.Name = "ColumnPrixIniContrat";
            this.ColumnPrixIniContrat.ReadOnly = true;
            this.ColumnPrixIniContrat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPrixRenContrat
            // 
            this.ColumnPrixRenContrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrixRenContrat.HeaderText = "Prix renouvellement";
            this.ColumnPrixRenContrat.Name = "ColumnPrixRenContrat";
            this.ColumnPrixRenContrat.ReadOnly = true;
            this.ColumnPrixRenContrat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTailleContrat
            // 
            this.ColumnTailleContrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTailleContrat.HeaderText = "Taille du panneau";
            this.ColumnTailleContrat.Name = "ColumnTailleContrat";
            this.ColumnTailleContrat.ReadOnly = true;
            this.ColumnTailleContrat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonAjouterContrat
            // 
            this.buttonAjouterContrat.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterContrat.Name = "buttonAjouterContrat";
            this.buttonAjouterContrat.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterContrat.TabIndex = 3;
            this.buttonAjouterContrat.Text = "Ajouter";
            this.buttonAjouterContrat.UseVisualStyleBackColor = true;
            this.buttonAjouterContrat.Click += new System.EventHandler(this.buttonAjouterContrat_Click);
            // 
            // buttonModifierContrat
            // 
            this.buttonModifierContrat.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierContrat.Name = "buttonModifierContrat";
            this.buttonModifierContrat.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierContrat.TabIndex = 4;
            this.buttonModifierContrat.Text = "Modifier";
            this.buttonModifierContrat.UseVisualStyleBackColor = true;
            this.buttonModifierContrat.Click += new System.EventHandler(this.buttonModifierContrat_Click);
            // 
            // buttonSupprimerContrat
            // 
            this.buttonSupprimerContrat.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerContrat.Name = "buttonSupprimerContrat";
            this.buttonSupprimerContrat.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerContrat.TabIndex = 5;
            this.buttonSupprimerContrat.Text = "Supprimer";
            this.buttonSupprimerContrat.UseVisualStyleBackColor = true;
            this.buttonSupprimerContrat.Click += new System.EventHandler(this.buttonSupprimerContrat_Click);
            // 
            // buttonRetourContrat
            // 
            this.buttonRetourContrat.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourContrat.Name = "buttonRetourContrat";
            this.buttonRetourContrat.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourContrat.TabIndex = 6;
            this.buttonRetourContrat.Text = "Retour";
            this.buttonRetourContrat.UseVisualStyleBackColor = true;
            this.buttonRetourContrat.Click += new System.EventHandler(this.buttonRetourContrat_Click);
            // 
            // FormContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourContrat);
            this.Controls.Add(this.buttonSupprimerContrat);
            this.Controls.Add(this.buttonModifierContrat);
            this.Controls.Add(this.buttonAjouterContrat);
            this.Controls.Add(this.dataGridViewContrat);
            this.Controls.Add(this.labelContrats);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormContrat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq - Contrats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelContrats;
        private System.Windows.Forms.DataGridView dataGridViewContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrixIniContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrixRenContrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTailleContrat;
        private System.Windows.Forms.Button buttonAjouterContrat;
        private System.Windows.Forms.Button buttonModifierContrat;
        private System.Windows.Forms.Button buttonSupprimerContrat;
        private System.Windows.Forms.Button buttonRetourContrat;
    }
}