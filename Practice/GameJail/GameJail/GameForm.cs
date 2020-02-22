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
    public partial class GameForm : Form
    {
        private Person person1, person2;

        //////// Item display control ////////

        private int STATUS_GAME = 0;
        private int TYPE_GAME = -1;

        private void GameForm_Load(object sender, EventArgs e)
        {
            buttons = new HashSet<Control>[]{ new HashSet<Control>{ NameGame, OneComputerGameButton, InternetGameButton},
                new HashSet<Control>{ LoginLabel, LoginBox, PasswordBox, PasswordLabel, LoadProfileButton, StartGameButton, TurnButton, StatusBox},
                new HashSet<Control>{ LoginLabel, LoginBox, PasswordBox, PasswordLabel, LoginLabel2, LoginBox2, PasswordBox2, PasswordLabel2, LoadProfileButton, StartGameButton, TurnButton, StatusBox },
                new HashSet<Control>{ StatusBox, Rules, SilenceButton, AccuseButton} };
            turnStatus(0);
        }

        // STATUS_GAME
        //             = 0 - start menu. Only buttons play and name of game label visible.
        //             = 1 - profile menu. Name and password box and play button visible.
        //             = 2 - profile menu solo computer. Name and password box (second too) and play button visible.
        //             = 3 - game. Only timer and games buttons visible.

        // TYPE_GAME
        //           = 1 - solo computer game
        //           = 0 - internet mode
        //           WARNING: on STATUS_GAME = 0 - -1

        HashSet<Control>[] buttons;

        void turnStatus(int status)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                foreach (Control control in buttons[i])
                {
                    control.Visible = false;
                }
            }
            foreach (Control control in buttons[status])
            {
                control.Visible = true;
            }
            STATUS_GAME = status;
        }

        //////// END Item display control ////////

        private void clearDataLoginPassword()
        {
            LoginBox.Text = "";
            LoginBox2.Text = "";
            PasswordBox.Text = "";
            PasswordBox2.Text = "";
        }
        
        private void OneComputerGameButton_Click(object sender, EventArgs e)
        {
            TYPE_GAME = 1;
            turnStatus(2);
        }

        private void InternetGameButton_Click(object sender, EventArgs e)
        {
            TYPE_GAME = 0;
            turnStatus(1);
        }

        private void TurnButton_Click(object sender, EventArgs e)
        {
            TYPE_GAME = -1;
            turnStatus(0);
            person1 = null;
            person2 = null;
        }

        private void LoadProfileButton_Click(object sender, EventArgs e)
        {
            StatusBox.Text = "";
            if (TYPE_GAME == 0)
            {
                // internet TODO
            }
            if (TYPE_GAME == 1)
            {
                String name1 = LoginBox.Text;
                String name2 = LoginBox2.Text;
                String password1 = PasswordBox.Text;
                String password2 = PasswordBox2.Text;
                try
                {
                    person1 = new Person(name1, password1);
                } catch (PersonException ex)
                {
                    StatusBox.Text = "First user incorrect data" + ex.Message + "\n";
                }
                try
                {
                    person2 = new Person(name2, password2);
                }
                catch (PersonException ex)
                {
                    StatusBox.Text += "Second user incorrect data" + ex.Message + "\n";
                }
                if (person1 != null && person2 != null)
                {
                    // start game
                    clearDataLoginPassword();
                    turnStatus(3);
                }
            }
        }

        ////////////// GAME //////////////////
        int choose1 = -1, choose2 = -1;

        private void SilenceButton_Click(object sender, EventArgs e)
        {
            if (choose1 == -1)
            {
                choose1 = 0;
            } else
            {
                choose2 = 0;
                judge();
            }
        }

        private void AccuseButton_Click(object sender, EventArgs e)
        {
            if (choose1 == -1)
            {
                choose1 = 1;
            } else
            {
                choose2 = 1;
                judge();
            }
            turnStatus(0);
        }

        private void judge()
        {
            if (choose1 == 0)
            {
                if (choose2 == 0)
                {
                    person1.incWon();
                    person2.incWon();
                    person1.incHours(1);
                    person2.incHours(1);
                }
                else
                {
                    person1.incLosses();
                    person2.incWon();
                    person1.incHours(10);
                }
            } else
            {
                if (choose2 == 0)
                {
                    person1.incWon();
                    person2.incLosses();
                    person2.incHours(10);
                } else
                {
                    person1.incLosses();
                    person2.incLosses();
                    person1.incHours(2);
                    person2.incHours(2);
                }
            }
            savePerson(person1);
            savePerson(person2);
        }

        private void savePerson(Person person)
        {
            if (TYPE_GAME == 1)
            {
                person.saveToFile();
            }
            if (TYPE_GAME == 0)
            {
                // INTERNET TODO
            }
        }

    }
}
