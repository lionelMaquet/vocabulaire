
namespace ExamenProgrammation
{
    partial class LanguagesForm
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
            this.ButtonAddLanguage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddLanguage
            // 
            this.ButtonAddLanguage.Location = new System.Drawing.Point(276, 352);
            this.ButtonAddLanguage.Name = "ButtonAddLanguage";
            this.ButtonAddLanguage.Size = new System.Drawing.Size(230, 51);
            this.ButtonAddLanguage.TabIndex = 0;
            this.ButtonAddLanguage.Text = "Ajouter une langue";
            this.ButtonAddLanguage.UseVisualStyleBackColor = true;
            this.ButtonAddLanguage.Click += new System.EventHandler(this.ButtonAddLanguage_Click);
            // 
            // LanguagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAddLanguage);
            this.Name = "LanguagesForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddLanguage;
    }
}

