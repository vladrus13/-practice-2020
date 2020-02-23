namespace GameJail
{
    partial class InternetGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetGame));
            this.SilenceButton = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Label();
            this.AccuseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TimerBox = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SilenceButton
            // 
            this.SilenceButton.BackColor = System.Drawing.SystemColors.Control;
            this.SilenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SilenceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SilenceButton.Location = new System.Drawing.Point(12, 431);
            this.SilenceButton.Name = "SilenceButton";
            this.SilenceButton.Size = new System.Drawing.Size(390, 145);
            this.SilenceButton.TabIndex = 22;
            this.SilenceButton.Text = "МОЛЧАТЬ";
            this.SilenceButton.UseVisualStyleBackColor = false;
            this.SilenceButton.Click += new System.EventHandler(this.SilenceButton_Click);
            // 
            // Rules
            // 
            this.Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rules.Location = new System.Drawing.Point(8, 186);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(394, 224);
            this.Rules.TabIndex = 21;
            this.Rules.Text = resources.GetString("Rules.Text");
            // 
            // AccuseButton
            // 
            this.AccuseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccuseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccuseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AccuseButton.Location = new System.Drawing.Point(12, 12);
            this.AccuseButton.Name = "AccuseButton";
            this.AccuseButton.Size = new System.Drawing.Size(390, 145);
            this.AccuseButton.TabIndex = 20;
            this.AccuseButton.Text = "ОБВИНИТЬ";
            this.AccuseButton.UseVisualStyleBackColor = false;
            this.AccuseButton.Click += new System.EventHandler(this.AccuseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(446, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "Осталось:";
            // 
            // TimerBox
            // 
            this.TimerBox.AutoSize = true;
            this.TimerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.TimerBox.Location = new System.Drawing.Point(453, 99);
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(160, 113);
            this.TimerBox.TabIndex = 24;
            this.TimerBox.Text = "30";
            // 
            // StatusBox
            // 
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBox.Location = new System.Drawing.Point(448, 266);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(199, 168);
            this.StatusBox.TabIndex = 25;
            // 
            // InternetGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 588);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SilenceButton);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.AccuseButton);
            this.Name = "InternetGame";
            this.Text = "InternetGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SilenceButton;
        private System.Windows.Forms.Label Rules;
        private System.Windows.Forms.Button AccuseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimerBox;
        private System.Windows.Forms.Label StatusBox;
    }
}