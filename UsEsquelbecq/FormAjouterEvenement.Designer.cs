namespace UsEsquelbecq
{
    partial class FormAjouterEvenement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterEvenement));
            this.labelTypeEvenement = new System.Windows.Forms.Label();
            this.labelNomEvenement = new System.Windows.Forms.Label();
            this.textBoxTypeEvenement = new System.Windows.Forms.TextBox();
            this.textBoxNomEvenement = new System.Windows.Forms.TextBox();
            this.buttonAnnulerEvenement = new System.Windows.Forms.Button();
            this.buttonAjouterEvenement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeEvenement
            // 
            this.labelTypeEvenement.AutoSize = true;
            this.labelTypeEvenement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeEvenement.Location = new System.Drawing.Point(20, 40);
            this.labelTypeEvenement.Name = "labelTypeEvenement";
            this.labelTypeEvenement.Size = new System.Drawing.Size(44, 19);
            this.labelTypeEvenement.TabIndex = 0;
            this.labelTypeEvenement.Text = "Type";
            // 
            // labelNomEvenement
            // 
            this.labelNomEvenement.AutoSize = true;
            this.labelNomEvenement.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEvenement.Location = new System.Drawing.Point(20, 100);
            this.labelNomEvenement.Name = "labelNomEvenement";
            this.labelNomEvenement.Size = new System.Drawing.Size(43, 19);
            this.labelNomEvenement.TabIndex = 1;
            this.labelNomEvenement.Text = "Nom";
            // 
            // textBoxTypeEvenement
            // 
            this.textBoxTypeEvenement.Location = new System.Drawing.Point(154, 40);
            this.textBoxTypeEvenement.Name = "textBoxTypeEvenement";
            this.textBoxTypeEvenement.Size = new System.Drawing.Size(120, 20);
            this.textBoxTypeEvenement.TabIndex = 2;
            // 
            // textBoxNomEvenement
            // 
            this.textBoxNomEvenement.Location = new System.Drawing.Point(154, 100);
            this.textBoxNomEvenement.Name = "textBoxNomEvenement";
            this.textBoxNomEvenement.Size = new System.Drawing.Size(120, 20);
            this.textBoxNomEvenement.TabIndex = 3;
            // 
            // buttonAnnulerEvenement
            // 
            this.buttonAnnulerEvenement.Location = new System.Drawing.Point(45, 188);
            this.buttonAnnulerEvenement.Name = "buttonAnnulerEvenement";
            this.buttonAnnulerEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonAnnulerEvenement.TabIndex = 4;
            this.buttonAnnulerEvenement.Text = "Annuler";
            this.buttonAnnulerEvenement.UseVisualStyleBackColor = true;
            this.buttonAnnulerEvenement.Click += new System.EventHandler(this.buttonAnnulerEvenement_Click);
            // 
            // buttonAjouterEvenement
            // 
            this.buttonAjouterEvenement.Location = new System.Drawing.Point(154, 188);
            this.buttonAjouterEvenement.Name = "buttonAjouterEvenement";
            this.buttonAjouterEvenement.Size = new System.Drawing.Size(100, 25);
            this.buttonAjouterEvenement.TabIndex = 5;
            this.buttonAjouterEvenement.Text = "Ajouter";
            this.buttonAjouterEvenement.UseVisualStyleBackColor = true;
            this.buttonAjouterEvenement.Click += new System.EventHandler(this.buttonAjouterEvenement_Click);
            // 
            // FormAjouterEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.buttonAjouterEvenement);
            this.Controls.Add(this.buttonAnnulerEvenement);
            this.Controls.Add(this.textBoxNomEvenement);
            this.Controls.Add(this.textBoxTypeEvenement);
            this.Controls.Add(this.labelNomEvenement);
            this.Controls.Add(this.labelTypeEvenement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 300);
            this.MinimumSize = new System.Drawing.Size(320, 300);
            this.Name = "FormAjouterEvenement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un événement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeEvenement;
        private System.Windows.Forms.Label labelNomEvenement;
        private System.Windows.Forms.TextBox textBoxTypeEvenement;
        private System.Windows.Forms.TextBox textBoxNomEvenement;
        private System.Windows.Forms.Button buttonAnnulerEvenement;
        private System.Windows.Forms.Button buttonAjouterEvenement;
    }
}