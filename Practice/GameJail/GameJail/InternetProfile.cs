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

        public InternetProfile()
        {
            dataBase = new DataBase();
            StartGameButton.Enabled = false;
            InitializeComponent();
        }
       

        private void LoadProfileButton_Click(object sender, EventArgs e)
        {
            StatusBox.Text = "";
            string name = LoginBox.Text;
            string password = PasswordBox.Text;
            try
            {
                person = dataBase.GetPerson(name, password);
            } catch (DataBaseException ex)
            {
                StatusBox.Text += "Load failed: " + ex.Message;
            }
            if (person != null)
            {
                if (person.games == 0)
                {
                    StatusBox.Text += person.name + " successful register!\n";
                }
                StatusBox.Text += "Loaded!!!";
                // start game
                clearDataLoginPassword();
                StartGameButton.Enabled = true;
            }
        }

        private void clearDataLoginPassword()
        {
            LoginBox.Text = "";
            PasswordBox.Text = "";
        }

        private void InternetProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StartGameButton_Click_1(object sender, EventArgs e)
        {
            long id = dataBase.FindGame(person.name);
            while (!dataBase.IsOpponentFound(id))
            {
                System.Threading.Thread.Sleep(500);
            }

            InternetGame internetGame = new InternetGame(person, dataBase, id);
            internetGame.Show();
            this.Hide();
        }
    }
}
