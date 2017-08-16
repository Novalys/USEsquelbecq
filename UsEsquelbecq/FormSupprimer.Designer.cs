namespace UsEsquelbecq
{
    partial class FormSupprimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupprimer));
            this.labelValidationSuppression = new System.Windows.Forms.Label();
            this.buttonNonSupprimer = new System.Windows.Forms.Button();
            this.buttonOuiSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValidationSuppression
            // 
            this.labelValidationSuppression.AutoSize = true;
            this.labelValidationSuppression.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValidationSuppression.Location = new System.Drawing.Point(209, 34);
            this.labelValidationSuppression.Name = "labelValidationSuppression";
            this.labelValidationSuppression.Size = new System.Drawing.Size(117, 19);
            this.labelValidationSuppression.TabIndex = 0;
            this.labelValidationSuppression.Text = "Êtes-vous sûr ?";
            // 
            // buttonNonSupprimer
            // 
            this.buttonNonSupprimer.Location = new System.Drawing.Point(82, 86);
            this.buttonNonSupprimer.Name = "buttonNonSupprimer";
            this.buttonNonSupprimer.Size = new System.Drawing.Size(100, 25);
            this.buttonNonSupprimer.TabIndex = 1;
            this.buttonNonSupprimer.Text = "Non";
            this.buttonNonSupprimer.UseVisualStyleBackColor = true;
            this.buttonNonSupprimer.Click += new System.EventHandler(this.buttonNonSupprimer_Click);
            // 
            // buttonOuiSupprimer
            // 
            this.buttonOuiSupprimer.Location = new System.Drawing.Point(342, 86);
            this.buttonOuiSupprimer.Name = "buttonOuiSupprimer";
            this.buttonOuiSupprimer.Size = new System.Drawing.Size(100, 25);
            this.buttonOuiSupprimer.TabIndex = 2;
            this.buttonOuiSupprimer.Text = "Oui";
            this.buttonOuiSupprimer.UseVisualStyleBackColor = true;
            this.buttonOuiSupprimer.Click += new System.EventHandler(this.buttonOuiSupprimer_Click);
            // 
            // FormSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(519, 141);
            this.Controls.Add(this.buttonOuiSupprimer);
            this.Controls.Add(this.buttonNonSupprimer);
            this.Controls.Add(this.labelValidationSuppression);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(535, 180);
            this.MinimumSize = new System.Drawing.Size(535, 180);
            this.Name = "FormSupprimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValidationSuppression;
        private System.Windows.Forms.Button buttonNonSupprimer;
        private System.Windows.Forms.Button buttonOuiSupprimer;
    }
}