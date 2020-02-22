namespace GameJail
{
    partial class OneComputerGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneComputerGame));
            this.AccuseButton = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Label();
            this.SilenceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccuseButton
            // 
            this.AccuseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccuseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccuseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AccuseButton.Location = new System.Drawing.Point(12, 12);
            this.AccuseButton.Name = "AccuseButton";
            this.AccuseButton.Size = new System.Drawing.Size(648, 200);
            this.AccuseButton.TabIndex = 16;
            this.AccuseButton.Text = "ОБВИНИТЬ";
            this.AccuseButton.UseVisualStyleBackColor = false;
            this.AccuseButton.Click += new System.EventHandler(this.AccuseButton_Click);
            // 
            // Rules
            // 
            this.Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rules.Location = new System.Drawing.Point(12, 215);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(648, 158);
            this.Rules.TabIndex = 18;
            this.Rules.Text = resources.GetString("Rules.Text");
            // 
            // SilenceButton
            // 
            this.SilenceButton.BackColor = System.Drawing.SystemColors.Control;
            this.SilenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SilenceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SilenceButton.Location = new System.Drawing.Point(12, 376);
            this.SilenceButton.Name = "SilenceButton";
            this.SilenceButton.Size = new System.Drawing.Size(648, 200);
            this.SilenceButton.TabIndex = 19;
            this.SilenceButton.Text = "МОЛЧАТЬ";
            this.SilenceButton.UseVisualStyleBackColor = false;
            this.SilenceButton.Click += new System.EventHandler(this.SilenceButton_Click);
            // 
            // OneComputerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 588);
            this.Controls.Add(this.SilenceButton);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.AccuseButton);
            this.Name = "OneComputerGame";
            this.Text = "OneComputerGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OneComputerGame_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AccuseButton;
        private System.Windows.Forms.Label Rules;
        private System.Windows.Forms.Button SilenceButton;
    }
}