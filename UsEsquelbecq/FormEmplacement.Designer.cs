namespace UsEsquelbecq
{
    partial class FormEmplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmplacement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxLogoEmplacement = new System.Windows.Forms.PictureBox();
            this.labelEmplacements = new System.Windows.Forms.Label();
            this.dataGridViewEmplacement = new System.Windows.Forms.DataGridView();
            this.ColumnTypeEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDispoEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterEmplacement = new System.Windows.Forms.Button();
            this.buttonModifierEmplacement = new System.Windows.Forms.Button();
            this.buttonSupprimerEmplacement = new System.Windows.Forms.Button();
            this.buttonRetourEmplacement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmplacement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmplacement)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoEmplacement
            // 
            this.pictureBoxLogoEmplacement.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoEmplacement.Image")));
            this.pictureBoxLogoEmplacement.Location = new System.Drawing.Point(24, 24);
            this.pictureBoxLogoEmplacement.Name = "pictureBoxLogoEmplacement";
            this.pictureBoxLogoEmplacement.Size = new System.Drawing.Size(264, 120);
            this.pictureBoxLogoEmplacement.TabIndex = 0;
            this.pictureBoxLogoEmplacement.TabStop = false;
            // 
            // labelEmplacements
            // 
            this.labelEmplacements.AutoSize = true;
            this.labelEmplacements.Font = new System.Drawing.Font("Tahoma", 32.25F, System.Drawing.FontStyle.Bold);
            this.labelEmplacements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.labelEmplacements.Location = new System.Drawing.Point(480, 80);
            this.labelEmplacements.Name = "labelEmplacements";
            this.labelEmplacements.Size = new System.Drawing.Size(340, 52);
            this.labelEmplacements.TabIndex = 1;
            this.labelEmplacements.Text = "Emplacements";
            // 
            // dataGridViewEmplacement
            // 
            this.dataGridViewEmplacement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmplacement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmplacement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmplacement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTypeEmplacement,
            this.ColumnDispoEmplacement,
            this.ColumnTotalEmplacement});
            this.dataGridViewEmplacement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(129)))));
            this.dataGridViewEmplacement.Location = new System.Drawing.Point(24, 219);
            this.dataGridViewEmplacement.MaximumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewEmplacement.MinimumSize = new System.Drawing.Size(1236, 450);
            this.dataGridViewEmplacement.MultiSelect = false;
            this.dataGridViewEmplacement.Name = "dataGridViewEmplacement";
            this.dataGridViewEmplacement.ReadOnly = true;
            this.dataGridViewEmplacement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmplacement.Size = new System.Drawing.Size(1236, 450);
            this.dataGridViewEmplacement.TabIndex = 2;
            // 
            // ColumnTypeEmplacement
            // 
            this.ColumnTypeEmplacement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTypeEmplacement.HeaderText = "Type d\'emplacement";
            this.ColumnTypeEmplacement.Name = "ColumnTypeEmplacement";
            this.ColumnTypeEmplacement.ReadOnly = true;
            this.ColumnTypeEmplacement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDispoEmplacement
            // 
            this.ColumnDispoEmplacement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDispoEmplacement.HeaderText = "Nombre d\'emplacements disponible";
            this.ColumnDispoEmplacement.Name = "ColumnDispoEmplacement";
            this.ColumnDispoEmplacement.ReadOnly = true;
            this.ColumnDispoEmplacement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnTotalEmplacement
            // 
            this.ColumnTotalEmplacement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTotalEmplacement.HeaderText = "Nombre d\'emplacements total";
            this.ColumnTotalEmplacement.Name = "ColumnTotalEmplacement";
            this.ColumnTotalEmplacement.ReadOnly = true;
            this.ColumnTotalEmplacement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonAjouterEmplacement
            // 
            this.buttonAjouterEmplacement.Location = new System.Drawing.Point(940, 707);
            this.buttonAjouterEmplacement.Margin = new System.Windows.Forms.Padding(10);
            this.buttonAjouterEmplacement.Name = "buttonAjouterEmplacement";
            this.buttonAjouterEmplacement.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterEmplacement.TabIndex = 3;
            this.buttonAjouterEmplacement.Text = "Ajouter";
            this.buttonAjouterEmplacement.UseVisualStyleBackColor = true;
            this.buttonAjouterEmplacement.Click += new System.EventHandler(this.buttonAjouterEmplacement_Click);
            // 
            // buttonModifierEmplacement
            // 
            this.buttonModifierEmplacement.Location = new System.Drawing.Point(1050, 707);
            this.buttonModifierEmplacement.Margin = new System.Windows.Forms.Padding(10);
            this.buttonModifierEmplacement.Name = "buttonModifierEmplacement";
            this.buttonModifierEmplacement.Size = new System.Drawing.Size(100, 25);
            this.buttonModifierEmplacement.TabIndex = 4;
            this.buttonModifierEmplacement.Text = "Modifier";
            this.buttonModifierEmplacement.UseVisualStyleBackColor = true;
            this.buttonModifierEmplacement.Click += new System.EventHandler(this.buttonModifierEmplacement_Click);
            // 
            // buttonSupprimerEmplacement
            // 
            this.buttonSupprimerEmplacement.Location = new System.Drawing.Point(1160, 707);
            this.buttonSupprimerEmplacement.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSupprimerEmplacement.Name = "buttonSupprimerEmplacement";
            this.buttonSupprimerEmplacement.Size = new System.Drawing.Size(100, 25);
            this.buttonSupprimerEmplacement.TabIndex = 5;
            this.buttonSupprimerEmplacement.Text = "Supprimer";
            this.buttonSupprimerEmplacement.UseVisualStyleBackColor = true;
            this.buttonSupprimerEmplacement.Click += new System.EventHandler(this.buttonSupprimerEmplacement_Click);
            // 
            // buttonRetourEmplacement
            // 
            this.buttonRetourEmplacement.Location = new System.Drawing.Point(24, 707);
            this.buttonRetourEmplacement.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRetourEmplacement.Name = "buttonRetourEmplacement";
            this.buttonRetourEmplacement.Size = new System.Drawing.Size(100, 25);
            this.buttonRetourEmplacement.TabIndex = 6;
            this.buttonRetourEmplacement.Text = "Retour";
            this.buttonRetourEmplacement.UseVisualStyleBackColor = true;
            this.buttonRetourEmplacement.Click += new System.EventHandler(this.buttonRetourEmplacement_Click);
            // 
            // FormEmplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.buttonRetourEmplacement);
            this.Controls.Add(this.buttonSupprimerEmplacement);
            this.Controls.Add(this.buttonModifierEmplacement);
            this.Controls.Add(this.buttonAjouterEmplacement);
            this.Controls.Add(this.dataGridViewEmplacement);
            this.Controls.Add(this.labelEmplacements);
            this.Controls.Add(this.pictureBoxLogoEmplacement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormEmplacement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "US Esquelbecq - Emplacements";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmplacement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmplacement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoEmplacement;
        private System.Windows.Forms.Label labelEmplacements;
        private System.Windows.Forms.DataGridView dataGridViewEmplacement;
        private System.Windows.Forms.Button buttonAjouterEmplacement;
        private System.Windows.Forms.Button buttonModifierEmplacement;
        private System.Windows.Forms.Button buttonSupprimerEmplacement;
        private System.Windows.Forms.Button buttonRetourEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDispoEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalEmplacement;
    }
}