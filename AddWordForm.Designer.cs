
namespace ExamenProgrammation
{
    partial class AddWordForm
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
            this.textbox_motFR = new System.Windows.Forms.TextBox();
            this.textbox_traduction = new System.Windows.Forms.TextBox();
            this.button_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_motFR
            // 
            this.textbox_motFR.Location = new System.Drawing.Point(157, 153);
            this.textbox_motFR.Name = "textbox_motFR";
            this.textbox_motFR.Size = new System.Drawing.Size(375, 29);
            this.textbox_motFR.TabIndex = 0;
            this.textbox_motFR.Text = "Mot FR";
            // 
            // textbox_traduction
            // 
            this.textbox_traduction.Location = new System.Drawing.Point(157, 198);
            this.textbox_traduction.Name = "textbox_traduction";
            this.textbox_traduction.Size = new System.Drawing.Size(375, 29);
            this.textbox_traduction.TabIndex = 1;
            this.textbox_traduction.Text = "Traduction";
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(279, 251);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(124, 38);
            this.button_valider.TabIndex = 2;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.textbox_traduction);
            this.Controls.Add(this.textbox_motFR);
            this.Name = "AddWordForm";
            this.Text = "AddWordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_motFR;
        private System.Windows.Forms.TextBox textbox_traduction;
        private System.Windows.Forms.Button button_valider;
    }
}