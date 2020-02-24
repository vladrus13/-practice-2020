using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameJail
{
    public partial class OneComputerProfile : Form
    {
        public OneComputerProfile()
        {
            InitializeComponent();
            StartGameButton.Enabled = false;
        }

        private Person person1, person2;

        private void clearDataLoginPassword()
        {
            LoginBox.Text = "";
            LoginBox2.Text = "";
            PasswordBox.Text = "";
            PasswordBox2.Text = "";
        }

        public void clear(Person person1, Person person2)
        {
            this.person1 = person1;
            this.person2 = person2;
            clearDataLoginPassword();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            OneComputerGame OneComputerGame = new OneComputerGame(this, person1, person2);
            OneComputerGame.Show();
            this.Hide();
        }

        private void OneComputerProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadProfileButton_Click(object sender, EventArgs e)
        {
            StatusBox.Text = "";
            String name1 = LoginBox.Text;
            String name2 = LoginBox2.Text;
            String password1 = PasswordBox.Text;
            String password2 = PasswordBox2.Text;
            try
            {
                person1 = new Person(name1, password1);
            }
            catch (FileSaveException ex)
            {
                StatusBox.Text = "First user incorrect data: " + ex.Message + "\n";
            }
            try
            {
                person2 = new Person(name2, password2);
            }
            catch (FileSaveException ex)
            {
                StatusBox.Text += "Second user incorrect data: " + ex.Message + "\n";
            }
            if (person1 != null && person1.games == 0)
            {
                StatusBox.Text += person1.name + " successful register!\n";
            }
            if (person2 != null && person2.games == 0)
            {
                StatusBox.Text += person2.name + " successful register!\n";
            }
            if (person1 != null && person2 != null)
            {
                if (person1.name == person2.name)
                {
                    StatusBox.Text += "It's so fun to play with yourself?";
                }
                else
                {
                    StatusBox.Text += "Loaded!!!";
                    // start game
                    clearDataLoginPassword();
                    StartGameButton.Enabled = true;
                }
            }
        }

    }
}
