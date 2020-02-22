namespace GameJail
{
    partial class MainScreen
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
            this.NameGame = new System.Windows.Forms.Label();
            this.OneComputerGameButton = new System.Windows.Forms.Button();
            this.InternetGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameGame
            // 
            this.NameGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameGame.Location = new System.Drawing.Point(13, 32);
            this.NameGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameGame.Name = "NameGame";
            this.NameGame.Size = new System.Drawing.Size(640, 59);
            this.NameGame.TabIndex = 1;
            this.NameGame.Text = "JailGame";
            this.NameGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OneComputerGameButton
            // 
            this.OneComputerGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneComputerGameButton.Location = new System.Drawing.Point(109, 203);
            this.OneComputerGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.OneComputerGameButton.Name = "OneComputerGameButton";
            this.OneComputerGameButton.Size = new System.Drawing.Size(416, 79);
            this.OneComputerGameButton.TabIndex = 2;
            this.OneComputerGameButton.Text = "Игра на одном компьютере";
            this.OneComputerGameButton.UseVisualStyleBackColor = true;
            this.OneComputerGameButton.Click += new System.EventHandler(this.OneComputerGameButton_Click);
            // 
            // InternetGameButton
            // 
            this.InternetGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InternetGameButton.Location = new System.Drawing.Point(109, 363);
            this.InternetGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.InternetGameButton.Name = "InternetGameButton";
            this.InternetGameButton.Size = new System.Drawing.Size(416, 79);
            this.InternetGameButton.TabIndex = 3;
            this.InternetGameButton.Text = "Игра по сети";
            this.InternetGameButton.UseVisualStyleBackColor = true;
            this.InternetGameButton.Click += new System.EventHandler(this.InternetGameButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 588);
            this.Controls.Add(this.InternetGameButton);
            this.Controls.Add(this.OneComputerGameButton);
            this.Controls.Add(this.NameGame);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameGame;
        private System.Windows.Forms.Button OneComputerGameButton;
        private System.Windows.Forms.Button InternetGameButton;
    }
}