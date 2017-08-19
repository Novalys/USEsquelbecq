namespace UsEsquelbecq
{
    partial class FormMDP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDP));
            this.labelNouveauMDP = new System.Windows.Forms.Label();
            this.labelConfirmerMDP = new System.Windows.Forms.Label();
            this.textBoxNouveauMDP = new System.Windows.Forms.TextBox();
            this.textBoxConfirmerMDP = new System.Windows.Forms.TextBox();
            this.buttonAnnulerMDP = new System.Windows.Forms.Button();
            this.buttonAssignerMDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNouveauMDP
            // 
            this.labelNouveauMDP.AutoSize = true;
            this.labelNouveauMDP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNouveauMDP.Location = new System.Drawing.Point(20, 40);
            this.labelNouveauMDP.Name = "labelNouveauMDP";
            this.labelNouveauMDP.Size = new System.Drawing.Size(170, 19);
            this.labelNouveauMDP.TabIndex = 0;
            this.labelNouveauMDP.Text = "Nouveau mot de passe";
            // 
            // labelConfirmerMDP
            // 
            this.labelConfirmerMDP.AutoSize = true;
            this.labelConfirmerMDP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmerMDP.Location = new System.Drawing.Point(20, 100);
            this.labelConfirmerMDP.Name = "labelConfirmerMDP";
            this.labelConfirmerMDP.Size = new System.Drawing.Size(179, 19);
            this.labelConfirmerMDP.TabIndex = 1;
            this.labelConfirmerMDP.Text = "Confirmer mot de passe";
            // 
            // textBoxNouveauMDP
            // 
            this.textBoxNouveauMDP.Location = new System.Drawing.Point(254, 40);
            this.textBoxNouveauMDP.Name = "textBoxNouveauMDP";
            this.textBoxNouveauMDP.Size = new System.Drawing.Size(160, 20);
            this.textBoxNouveauMDP.TabIndex = 2;
            // 
            // textBoxConfirmerMDP
            // 
            this.textBoxConfirmerMDP.Location = new System.Drawing.Point(254, 100);
            this.textBoxConfirmerMDP.Name = "textBoxConfirmerMDP";
            this.textBoxConfirmerMDP.Size = new System.Drawing.Size(160, 20);
            this.textBoxConfirmerMDP.TabIndex = 3;
            // 
            // buttonAnnulerMDP
            // 
            this.buttonAnnulerMDP.Location = new System.Drawing.Point(115, 188);
            this.buttonAnnulerMDP.Name = "buttonAnnulerMDP";
            this.buttonAnnulerMDP.Size = new System.Drawing.Size(100, 25);
            this.buttonAnnulerMDP.TabIndex = 4;
            this.buttonAnnulerMDP.Text = "Annuler";
            this.buttonAnnulerMDP.UseVisualStyleBackColor = true;
            this.buttonAnnulerMDP.Click += new System.EventHandler(this.buttonAnnulerMDP_Click);
            // 
            // buttonAssignerMDP
            // 
            this.buttonAssignerMDP.Location = new System.Drawing.Point(224, 188);
            this.buttonAssignerMDP.Name = "buttonAssignerMDP";
            this.buttonAssignerMDP.Size = new System.Drawing.Size(100, 25);
            this.buttonAssignerMDP.TabIndex = 5;
            this.buttonAssignerMDP.Text = "Assigner";
            this.buttonAssignerMDP.UseVisualStyleBackColor = true;
            this.buttonAssignerMDP.Click += new System.EventHandler(this.buttonAssignerMDP_Click);
            // 
            // FormMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.buttonAssignerMDP);
            this.Controls.Add(this.buttonAnnulerMDP);
            this.Controls.Add(this.textBoxConfirmerMDP);
            this.Controls.Add(this.textBoxNouveauMDP);
            this.Controls.Add(this.labelConfirmerMDP);
            this.Controls.Add(this.labelNouveauMDP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 300);
            this.MinimumSize = new System.Drawing.Size(460, 300);
            this.Name = "FormMDP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assigner un mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNouveauMDP;
        private System.Windows.Forms.Label labelConfirmerMDP;
        private System.Windows.Forms.TextBox textBoxNouveauMDP;
        private System.Windows.Forms.TextBox textBoxConfirmerMDP;
        private System.Windows.Forms.Button buttonAnnulerMDP;
        private System.Windows.Forms.Button buttonAssignerMDP;
    }
}