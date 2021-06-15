
namespace ExamenProgrammation
{
    partial class PlaylistEndForm
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ButtonShowDetails = new System.Windows.Forms.Button();
            this.ButtonReplay = new System.Windows.Forms.Button();
            this.ButtonReplayWrongResults = new System.Windows.Forms.Button();
            this.ButtonRejouerSerieEntiere = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(358, 75);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(60, 24);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "label1";
            // 
            // ButtonShowDetails
            // 
            this.ButtonShowDetails.Location = new System.Drawing.Point(191, 202);
            this.ButtonShowDetails.Name = "ButtonShowDetails";
            this.ButtonShowDetails.Size = new System.Drawing.Size(417, 33);
            this.ButtonShowDetails.TabIndex = 1;
            this.ButtonShowDetails.Text = "button1";
            this.ButtonShowDetails.UseVisualStyleBackColor = true;
            this.ButtonShowDetails.Click += new System.EventHandler(this.ButtonShowDetails_Click);
            // 
            // ButtonReplay
            // 
            this.ButtonReplay.Location = new System.Drawing.Point(191, 280);
            this.ButtonReplay.Name = "ButtonReplay";
            this.ButtonReplay.Size = new System.Drawing.Size(417, 33);
            this.ButtonReplay.TabIndex = 2;
            this.ButtonReplay.Text = "button1";
            this.ButtonReplay.UseVisualStyleBackColor = true;
            this.ButtonReplay.Click += new System.EventHandler(this.ButtonReplay_Click);
            // 
            // ButtonReplayWrongResults
            // 
            this.ButtonReplayWrongResults.Location = new System.Drawing.Point(191, 319);
            this.ButtonReplayWrongResults.Name = "ButtonReplayWrongResults";
            this.ButtonReplayWrongResults.Size = new System.Drawing.Size(417, 33);
            this.ButtonReplayWrongResults.TabIndex = 3;
            this.ButtonReplayWrongResults.Text = "button1";
            this.ButtonReplayWrongResults.UseVisualStyleBackColor = true;
            this.ButtonReplayWrongResults.Click += new System.EventHandler(this.ButtonReplayWrongResults_Click);
            // 
            // ButtonRejouerSerieEntiere
            // 
            this.ButtonRejouerSerieEntiere.Location = new System.Drawing.Point(191, 241);
            this.ButtonRejouerSerieEntiere.Name = "ButtonRejouerSerieEntiere";
            this.ButtonRejouerSerieEntiere.Size = new System.Drawing.Size(417, 33);
            this.ButtonRejouerSerieEntiere.TabIndex = 4;
            this.ButtonRejouerSerieEntiere.Text = "ButtonRejouerSerieEntiere";
            this.ButtonRejouerSerieEntiere.UseVisualStyleBackColor = true;
            this.ButtonRejouerSerieEntiere.Click += new System.EventHandler(this.ButtonRejouerSerieEntiere_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(12, 396);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(136, 42);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "ButtonBack";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // PlaylistEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonRejouerSerieEntiere);
            this.Controls.Add(this.ButtonReplayWrongResults);
            this.Controls.Add(this.ButtonReplay);
            this.Controls.Add(this.ButtonShowDetails);
            this.Controls.Add(this.ResultLabel);
            this.Name = "PlaylistEndForm";
            this.Text = "PlaylistEndForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ButtonShowDetails;
        private System.Windows.Forms.Button ButtonReplay;
        private System.Windows.Forms.Button ButtonReplayWrongResults;
        private System.Windows.Forms.Button ButtonRejouerSerieEntiere;
        private System.Windows.Forms.Button ButtonBack;
    }
}