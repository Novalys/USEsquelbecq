using System.Drawing.Text;

namespace UsEsquelbecq
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLoginMail = new System.Windows.Forms.Label();
            this.labelLoginPass = new System.Windows.Forms.Label();
            this.textBoxLoginMail = new System.Windows.Forms.TextBox();
            this.textBoxLoginPass = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(485, 20);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(330, 150);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(200, 145);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(120, 25);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Se connecter";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLoginMail
            // 
            this.labelLoginMail.AutoSize = true;
            this.labelLoginMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginMail.Location = new System.Drawing.Point(70, 40);
            this.labelLoginMail.Name = "labelLoginMail";
            this.labelLoginMail.Size = new System.Drawing.Size(40, 20);
            this.labelLoginMail.TabIndex = 1;
            this.labelLoginMail.Text = "Mail";
            // 
            // labelLoginPass
            // 
            this.labelLoginPass.AutoSize = true;
            this.labelLoginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPass.Location = new System.Drawing.Point(70, 90);
            this.labelLoginPass.Name = "labelLoginPass";
            this.labelLoginPass.Size = new System.Drawing.Size(110, 20);
            this.labelLoginPass.TabIndex = 2;
            this.labelLoginPass.Text = "Mot de passe";
            // 
            // textBoxLoginMail
            // 
            this.textBoxLoginMail.Location = new System.Drawing.Point(230, 40);
            this.textBoxLoginMail.Name = "textBoxLoginMail";
            this.textBoxLoginMail.Size = new System.Drawing.Size(200, 20);
            this.textBoxLoginMail.TabIndex = 3;
            // 
            // textBoxLoginPass
            // 
            this.textBoxLoginPass.Location = new System.Drawing.Point(230, 90);
            this.textBoxLoginPass.Name = "textBoxLoginPass";
            this.textBoxLoginPass.Size = new System.Drawing.Size(200, 20);
            this.textBoxLoginPass.TabIndex = 4;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxLoginPass);
            this.panelLogin.Controls.Add(this.labelLoginMail);
            this.panelLogin.Controls.Add(this.labelLoginPass);
            this.panelLogin.Controls.Add(this.textBoxLoginMail);
            this.panelLogin.Location = new System.Drawing.Point(400, 300);
            this.panelLogin.MaximumSize = new System.Drawing.Size(500, 200);
            this.panelLogin.MinimumSize = new System.Drawing.Size(500, 200);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(500, 200);
            this.panelLogin.TabIndex = 2;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(226)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "US Esquelbecq - Connexion";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLoginMail;
        private System.Windows.Forms.Label labelLoginPass;
        private System.Windows.Forms.TextBox textBoxLoginMail;
        private System.Windows.Forms.TextBox textBoxLoginPass;
        private System.Windows.Forms.Panel panelLogin;
    }
}

