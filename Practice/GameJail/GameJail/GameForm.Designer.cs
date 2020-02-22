namespace GameJail
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.NameGame = new System.Windows.Forms.Label();
            this.OneComputerGameButton = new System.Windows.Forms.Button();
            this.InternetGameButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoadProfileButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.TurnButton = new System.Windows.Forms.Button();
            this.PasswordBox2 = new System.Windows.Forms.TextBox();
            this.LoginBox2 = new System.Windows.Forms.TextBox();
            this.PasswordLabel2 = new System.Windows.Forms.Label();
            this.LoginLabel2 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.Label();
            this.AccuseButton = new System.Windows.Forms.Button();
            this.SilenceButton = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameGame
            // 
            this.NameGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameGame.Location = new System.Drawing.Point(16, 11);
            this.NameGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameGame.Name = "NameGame";
            this.NameGame.Size = new System.Drawing.Size(640, 59);
            this.NameGame.TabIndex = 0;
            this.NameGame.Text = "JailGame";
            this.NameGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OneComputerGameButton
            // 
            this.OneComputerGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneComputerGameButton.Location = new System.Drawing.Point(96, 185);
            this.OneComputerGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.OneComputerGameButton.Name = "OneComputerGameButton";
            this.OneComputerGameButton.Size = new System.Drawing.Size(416, 79);
            this.OneComputerGameButton.TabIndex = 1;
            this.OneComputerGameButton.Text = "Игра на одном компьютере";
            this.OneComputerGameButton.UseVisualStyleBackColor = true;
            this.OneComputerGameButton.Click += new System.EventHandler(this.OneComputerGameButton_Click);
            // 
            // InternetGameButton
            // 
            this.InternetGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InternetGameButton.Location = new System.Drawing.Point(96, 330);
            this.InternetGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.InternetGameButton.Name = "InternetGameButton";
            this.InternetGameButton.Size = new System.Drawing.Size(416, 79);
            this.InternetGameButton.TabIndex = 2;
            this.InternetGameButton.Text = "Игра по сети";
            this.InternetGameButton.UseVisualStyleBackColor = true;
            this.InternetGameButton.Click += new System.EventHandler(this.InternetGameButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(9, 87);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(73, 29);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(9, 138);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(120, 29);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(144, 84);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(224, 34);
            this.LoginBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(144, 134);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(224, 34);
            this.PasswordBox.TabIndex = 6;
            // 
            // LoadProfileButton
            // 
            this.LoadProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadProfileButton.Location = new System.Drawing.Point(453, 84);
            this.LoadProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadProfileButton.Name = "LoadProfileButton";
            this.LoadProfileButton.Size = new System.Drawing.Size(201, 85);
            this.LoadProfileButton.TabIndex = 7;
            this.LoadProfileButton.Text = "Загрузить";
            this.LoadProfileButton.UseVisualStyleBackColor = true;
            this.LoadProfileButton.Click += new System.EventHandler(this.LoadProfileButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.Location = new System.Drawing.Point(12, 405);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(641, 102);
            this.StartGameButton.TabIndex = 8;
            this.StartGameButton.Text = "Начать игру";
            this.StartGameButton.UseVisualStyleBackColor = true;
            // 
            // TurnButton
            // 
            this.TurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnButton.Location = new System.Drawing.Point(15, 17);
            this.TurnButton.Margin = new System.Windows.Forms.Padding(4);
            this.TurnButton.Name = "TurnButton";
            this.TurnButton.Size = new System.Drawing.Size(81, 52);
            this.TurnButton.TabIndex = 9;
            this.TurnButton.Text = "Назад";
            this.TurnButton.UseVisualStyleBackColor = true;
            this.TurnButton.Click += new System.EventHandler(this.TurnButton_Click);
            // 
            // PasswordBox2
            // 
            this.PasswordBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox2.Location = new System.Drawing.Point(144, 282);
            this.PasswordBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox2.Name = "PasswordBox2";
            this.PasswordBox2.PasswordChar = '*';
            this.PasswordBox2.Size = new System.Drawing.Size(224, 34);
            this.PasswordBox2.TabIndex = 13;
            // 
            // LoginBox2
            // 
            this.LoginBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox2.Location = new System.Drawing.Point(144, 232);
            this.LoginBox2.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox2.Name = "LoginBox2";
            this.LoginBox2.Size = new System.Drawing.Size(224, 34);
            this.LoginBox2.TabIndex = 12;
            // 
            // PasswordLabel2
            // 
            this.PasswordLabel2.AutoSize = true;
            this.PasswordLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel2.Location = new System.Drawing.Point(9, 286);
            this.PasswordLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel2.Name = "PasswordLabel2";
            this.PasswordLabel2.Size = new System.Drawing.Size(120, 29);
            this.PasswordLabel2.TabIndex = 11;
            this.PasswordLabel2.Text = "Password";
            // 
            // LoginLabel2
            // 
            this.LoginLabel2.AutoSize = true;
            this.LoginLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel2.Location = new System.Drawing.Point(9, 235);
            this.LoginLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel2.Name = "LoginLabel2";
            this.LoginLabel2.Size = new System.Drawing.Size(73, 29);
            this.LoginLabel2.TabIndex = 10;
            this.LoginLabel2.Text = "Login";
            // 
            // StatusBox
            // 
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBox.Location = new System.Drawing.Point(453, 179);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(199, 168);
            this.StatusBox.TabIndex = 14;
            // 
            // AccuseButton
            // 
            this.AccuseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccuseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccuseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AccuseButton.Location = new System.Drawing.Point(5, 78);
            this.AccuseButton.Name = "AccuseButton";
            this.AccuseButton.Size = new System.Drawing.Size(419, 90);
            this.AccuseButton.TabIndex = 15;
            this.AccuseButton.Text = "ОБВИНИТЬ";
            this.AccuseButton.UseVisualStyleBackColor = false;
            this.AccuseButton.Click += new System.EventHandler(this.AccuseButton_Click);
            // 
            // SilenceButton
            // 
            this.SilenceButton.BackColor = System.Drawing.SystemColors.Control;
            this.SilenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SilenceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SilenceButton.Location = new System.Drawing.Point(5, 330);
            this.SilenceButton.Name = "SilenceButton";
            this.SilenceButton.Size = new System.Drawing.Size(419, 90);
            this.SilenceButton.TabIndex = 16;
            this.SilenceButton.Text = "МОЛЧАТЬ";
            this.SilenceButton.UseVisualStyleBackColor = false;
            this.SilenceButton.Click += new System.EventHandler(this.SilenceButton_Click);
            // 
            // Rules
            // 
            this.Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rules.Location = new System.Drawing.Point(5, 191);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(419, 124);
            this.Rules.TabIndex = 17;
            this.Rules.Text = resources.GetString("Rules.Text");
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 588);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.SilenceButton);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.PasswordBox2);
            this.Controls.Add(this.LoginBox2);
            this.Controls.Add(this.PasswordLabel2);
            this.Controls.Add(this.LoginLabel2);
            this.Controls.Add(this.TurnButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.LoadProfileButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.InternetGameButton);
            this.Controls.Add(this.OneComputerGameButton);
            this.Controls.Add(this.NameGame);
            this.Controls.Add(this.AccuseButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "JailGame";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameGame;
        private System.Windows.Forms.Button OneComputerGameButton;
        private System.Windows.Forms.Button InternetGameButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button LoadProfileButton;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button TurnButton;
        private System.Windows.Forms.TextBox PasswordBox2;
        private System.Windows.Forms.TextBox LoginBox2;
        private System.Windows.Forms.Label PasswordLabel2;
        private System.Windows.Forms.Label LoginLabel2;
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.Button AccuseButton;
        private System.Windows.Forms.Button SilenceButton;
        private System.Windows.Forms.Label Rules;
    }
}

