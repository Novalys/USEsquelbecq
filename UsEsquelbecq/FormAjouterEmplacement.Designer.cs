namespace UsEsquelbecq
{
    partial class FormAjouterEmplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterEmplacement));
            this.labelTypeEmplacement = new System.Windows.Forms.Label();
            this.labelDispoEmplacement = new System.Windows.Forms.Label();
            this.labelTotalEmplacement = new System.Windows.Forms.Label();
            this.textBoxTypeEmplacement = new System.Windows.Forms.TextBox();
            this.textBoxDispoEmplacement = new System.Windows.Forms.TextBox();
            this.textBoxTotalEmplacement = new System.Windows.Forms.TextBox();
            this.buttonAnnulerEmplacement = new System.Windows.Forms.Button();
            this.buttonAjouterEmplacement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeEmplacement
            // 
            this.labelTypeEmplacement.AutoSize = true;
            this.labelTypeEmplacement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeEmplacement.Location = new System.Drawing.Point(20, 40);
            this.labelTypeEmplacement.Name = "labelTypeEmplacement";
            this.labelTypeEmplacement.Size = new System.Drawing.Size(155, 19);
            this.labelTypeEmplacement.TabIndex = 0;
            this.labelTypeEmplacement.Text = "Type d\'emplacement";
            // 
            // labelDispoEmplacement
            // 
            this.labelDispoEmplacement.AutoSize = true;
            this.labelDispoEmplacement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDispoEmplacement.Location = new System.Drawing.Point(20, 100);
            this.labelDispoEmplacement.Name = "labelDispoEmplacement";
            this.labelDispoEmplacement.Size = new System.Drawing.Size(261, 19);
            this.labelDispoEmplacement.TabIndex = 1;
            this.labelDispoEmplacement.Text = "Nombre d\'emplacements disponible";
            // 
            // labelTotalEmplacement
            // 
            this.labelTotalEmplacement.AutoSize = true;
            this.labelTotalEmplacement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEmplacement.Location = new System.Drawing.Point(20, 160);
            this.labelTotalEmplacement.Name = "labelTotalEmplacement";
            this.labelTotalEmplacement.Size = new System.Drawing.Size(220, 19);
            this.labelTotalEmplacement.TabIndex = 2;
            this.labelTotalEmplacement.Text = "Nombre d\'emplacements total";
            // 
            // textBoxTypeEmplacement
            // 
            this.textBoxTypeEmplacement.Location = new System.Drawing.Point(314, 40);
            this.textBoxTypeEmplacement.Name = "textBoxTypeEmplacement";
            this.textBoxTypeEmplacement.Size = new System.Drawing.Size(121, 20);
            this.textBoxTypeEmplacement.TabIndex = 3;
            // 
            // textBoxDispoEmplacement
            // 
            this.textBoxDispoEmplacement.Location = new System.Drawing.Point(314, 100);
            this.textBoxDispoEmplacement.Name = "textBoxDispoEmplacement";
            this.textBoxDispoEmplacement.Size = new System.Drawing.Size(121, 20);
            this.textBoxDispoEmplacement.TabIndex = 4;
            // 
            // textBoxTotalEmplacement
            // 
            this.textBoxTotalEmplacement.Location = new System.Drawing.Point(314, 160);
            this.textBoxTotalEmplacement.Name = "textBoxTotalEmplacement";
            this.textBoxTotalEmplacement.Size = new System.Drawing.Size(121, 20);
            this.textBoxTotalEmplacement.TabIndex = 5;
            // 
            // buttonAnnulerEmplacement
            // 
            this.buttonAnnulerEmplacement.Location = new System.Drawing.Point(125, 248);
            this.buttonAnnulerEmplacement.Name = "buttonAnnulerEmplacement";
            this.buttonAnnulerEmplacement.Size = new System.Drawing.Size(100, 25);
            this.buttonAnnulerEmplacement.TabIndex = 6;
            this.buttonAnnulerEmplacement.Text = "Annuler";
            this.buttonAnnulerEmplacement.UseVisualStyleBackColor = true;
            this.buttonAnnulerEmplacement.Click += new System.EventHandler(this.buttonAnnulerEmplacement_Click);
            // 
            // buttonAjouterEmplacement
            // 
            this.buttonAjouterEmplacement.Location = new System.Drawing.Point(235, 248);
            this.buttonAjouterEmplacement.Name = "buttonAjouterEmplacement";
            this.buttonAjouterEmplacement.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterEmplacement.TabIndex = 7;
            this.buttonAjouterEmplacement.Text = "Ajouter";
            this.buttonAjouterEmplacement.UseVisualStyleBackColor = true;
            this.buttonAjouterEmplacement.Click += new System.EventHandler(this.buttonAjouterEmplacement_Click);
            // 
            // FormAjouterEmplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.buttonAjouterEmplacement);
            this.Controls.Add(this.buttonAnnulerEmplacement);
            this.Controls.Add(this.textBoxTotalEmplacement);
            this.Controls.Add(this.textBoxDispoEmplacement);
            this.Controls.Add(this.textBoxTypeEmplacement);
            this.Controls.Add(this.labelTotalEmplacement);
            this.Controls.Add(this.labelDispoEmplacement);
            this.Controls.Add(this.labelTypeEmplacement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "FormAjouterEmplacement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un emplacement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeEmplacement;
        private System.Windows.Forms.Label labelDispoEmplacement;
        private System.Windows.Forms.Label labelTotalEmplacement;
        private System.Windows.Forms.TextBox textBoxTypeEmplacement;
        private System.Windows.Forms.TextBox textBoxDispoEmplacement;
        private System.Windows.Forms.TextBox textBoxTotalEmplacement;
        private System.Windows.Forms.Button buttonAnnulerEmplacement;
        private System.Windows.Forms.Button buttonAjouterEmplacement;
    }
}