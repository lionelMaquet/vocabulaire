
namespace ExamenProgrammation
{
    partial class playSerieForm
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
            this.LabelMotATraduire = new System.Windows.Forms.Label();
            this.TextboxTraductionInputUser = new System.Windows.Forms.TextBox();
            this.ButtonValiderReponse = new System.Windows.Forms.Button();
            this.LabelCurrentQuestionNumber = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelMotATraduire
            // 
            this.LabelMotATraduire.AutoSize = true;
            this.LabelMotATraduire.Location = new System.Drawing.Point(364, 70);
            this.LabelMotATraduire.Name = "LabelMotATraduire";
            this.LabelMotATraduire.Size = new System.Drawing.Size(60, 24);
            this.LabelMotATraduire.TabIndex = 0;
            this.LabelMotATraduire.Text = "label1";
            // 
            // TextboxTraductionInputUser
            // 
            this.TextboxTraductionInputUser.Location = new System.Drawing.Point(271, 140);
            this.TextboxTraductionInputUser.Name = "TextboxTraductionInputUser";
            this.TextboxTraductionInputUser.Size = new System.Drawing.Size(266, 29);
            this.TextboxTraductionInputUser.TabIndex = 1;
            // 
            // ButtonValiderReponse
            // 
            this.ButtonValiderReponse.Location = new System.Drawing.Point(338, 214);
            this.ButtonValiderReponse.Name = "ButtonValiderReponse";
            this.ButtonValiderReponse.Size = new System.Drawing.Size(110, 35);
            this.ButtonValiderReponse.TabIndex = 2;
            this.ButtonValiderReponse.Text = "button1";
            this.ButtonValiderReponse.UseVisualStyleBackColor = true;
            this.ButtonValiderReponse.Click += new System.EventHandler(this.ButtonValiderReponse_Click);
            // 
            // LabelCurrentQuestionNumber
            // 
            this.LabelCurrentQuestionNumber.AutoSize = true;
            this.LabelCurrentQuestionNumber.Location = new System.Drawing.Point(728, 9);
            this.LabelCurrentQuestionNumber.Name = "LabelCurrentQuestionNumber";
            this.LabelCurrentQuestionNumber.Size = new System.Drawing.Size(60, 24);
            this.LabelCurrentQuestionNumber.TabIndex = 3;
            this.LabelCurrentQuestionNumber.Text = "label1";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 402);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(154, 36);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "ButtonBack";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // playSerieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelCurrentQuestionNumber);
            this.Controls.Add(this.ButtonValiderReponse);
            this.Controls.Add(this.TextboxTraductionInputUser);
            this.Controls.Add(this.LabelMotATraduire);
            this.Name = "playSerieForm";
            this.Text = "playSerieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMotATraduire;
        private System.Windows.Forms.TextBox TextboxTraductionInputUser;
        private System.Windows.Forms.Button ButtonValiderReponse;
        private System.Windows.Forms.Label LabelCurrentQuestionNumber;
        private System.Windows.Forms.Button ButtonBack;
    }
}