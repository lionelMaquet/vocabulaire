
namespace ExamenProgrammation
{
    partial class AddSerieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxSerieName = new System.Windows.Forms.TextBox();
            this.ButtonValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la série";
            // 
            // TextboxSerieName
            // 
            this.TextboxSerieName.Location = new System.Drawing.Point(356, 148);
            this.TextboxSerieName.Name = "TextboxSerieName";
            this.TextboxSerieName.Size = new System.Drawing.Size(100, 29);
            this.TextboxSerieName.TabIndex = 1;
            // 
            // ButtonValidate
            // 
            this.ButtonValidate.Location = new System.Drawing.Point(305, 224);
            this.ButtonValidate.Name = "ButtonValidate";
            this.ButtonValidate.Size = new System.Drawing.Size(126, 43);
            this.ButtonValidate.TabIndex = 2;
            this.ButtonValidate.Text = "Valider";
            this.ButtonValidate.UseVisualStyleBackColor = true;
            this.ButtonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // AddSerieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonValidate);
            this.Controls.Add(this.TextboxSerieName);
            this.Controls.Add(this.label1);
            this.Name = "AddSerieForm";
            this.Text = "AddSerieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxSerieName;
        private System.Windows.Forms.Button ButtonValidate;
    }
}