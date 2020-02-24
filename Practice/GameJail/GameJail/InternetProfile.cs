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
    public partial class InternetProfile : Form
    {
        IDataBase dataBase;
        Person person;
        InternetGame internetGame;

        public InternetProfile()
        {
            dataBase = new DataBase();
            InitializeComponent();
            StartGameButton.Enabled = false;
        }

        public void clear(Person person)
        {
            this.person = person;
            StatusBox.Text = "";
            clearDataLoginPassword();
            timer1.Stop();
        }


        private void LoadProfileButton_Click(object sender, EventArgs e)
        {
            StatusBox.Text = "";
            string name = LoginBox.Text;
            string password = PasswordBox.Text;
            try
            {
                person = dataBase.GetPerson(name, password);
            }
            catch (DataBaseException ex)
            {
                StatusBox.Text += "Load failed: " + ex.Message;
            }
            if (person != null)
            {
                if (person.games == 0)
                {
                    StatusBox.Text += person.name + " successful register!\n";
                }
                StatusBox.Text += "Loaded!!!\n";
                // start game
                clearDataLoginPassword();
                StartGameButton.Enabled = true;
            }
        }

        private void clearDataLoginPassword()
        {
            LoginBox.Text = "";
            PasswordBox.Text = "";
            StartGameButton.Enabled = true;
            LoadProfileButton.Enabled = true;
        }

        private void InternetProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        long id;

        private void StartGameButton_Click_1(object sender, EventArgs e)
        {
            StatusBox.Text += "Waiting opponent...\n";
            id = dataBase.FindGame(person.name);
            timer1.Start();
            StartGameButton.Enabled = false;
            LoadProfileButton.Enabled = false;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dataBase.IsOpponentFound(id))
            {
                timer1.Stop();
                if (internetGame == null)
                {
                    internetGame = new InternetGame(this, person, dataBase, id);
                }
                else
                {
                    internetGame.clear(id);
                }
                internetGame.Show();
                this.Hide();
            }

        }
    }
}
