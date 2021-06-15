
namespace ExamenProgrammation
{
    partial class AddLanguageForm
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
            this.TextboxNomShort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonValidate = new System.Windows.Forms.Button();
            this.TextboxNomLong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextboxNomShort
            // 
            this.TextboxNomShort.Location = new System.Drawing.Point(327, 85);
            this.TextboxNomShort.Name = "TextboxNomShort";
            this.TextboxNomShort.Size = new System.Drawing.Size(166, 29);
            this.TextboxNomShort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom court";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom long";
            // 
            // ButtonValidate
            // 
            this.ButtonValidate.Location = new System.Drawing.Point(327, 225);
            this.ButtonValidate.Name = "ButtonValidate";
            this.ButtonValidate.Size = new System.Drawing.Size(124, 31);
            this.ButtonValidate.TabIndex = 4;
            this.ButtonValidate.Text = "Valider";
            this.ButtonValidate.UseVisualStyleBackColor = true;
            this.ButtonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // TextboxNomLong
            // 
            this.TextboxNomLong.Location = new System.Drawing.Point(333, 152);
            this.TextboxNomLong.Name = "TextboxNomLong";
            this.TextboxNomLong.Size = new System.Drawing.Size(160, 29);
            this.TextboxNomLong.TabIndex = 5;
            // 
            // AddLanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextboxNomLong);
            this.Controls.Add(this.ButtonValidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxNomShort);
            this.Name = "AddLanguageForm";
            this.Text = "AddLanguageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxNomShort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonValidate;
        private System.Windows.Forms.TextBox TextboxNomLong;
    }
}