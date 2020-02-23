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
    public partial class Result : Form
    {

        private Person person1, person2;
        bool isAccuse1, isAccuse2;
        OneComputerGame OneComputerGame;
        InternetGame InternetGame;

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (person2 != null)
            {
                OneComputerGame.clear();
                OneComputerGame.Show();
                this.Hide();
            } else
            {
                InternetGame.Show();
                this.Hide();
            }
        }

        private void setResultLabel(String s)
        {
            ResultLabel.Text = s;
        }

        public void clear()
        {
            Name1.Text = "";
            Name2.Text = "";
            Game1.Text = "";
            Game2.Text = "";
            Time1.Text = "";
            Time2.Text = "";
        }

        private void showResultPerson()
        {
            Name1.Text = person1.name;
            Game1.Text = person1.games.ToString();
            Time1.Text = person1.hours.ToString();
            if (person2 == null)
            {
                Name2.Visible = false;
                Game2.Visible = false;
                Time2.Visible = false;
            } else
            {
                Name2.Text = person2.name;
                Game2.Text = person2.games.ToString();
                Time2.Text = person2.hours.ToString();
            }
        }

        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void judge(bool isAccuse1, bool isAccuse2)
        {
            person1.incWon();
            person2.incWon();
            if (!isAccuse1)
            {
                if (!isAccuse2)
                {
                    setResultLabel("Вы и ваш товарищ по несчастью не выдвинули против друг друга обвинительных показаний. Вам дали по году тюрьмы.");
                    person1.incHours(1);
                    person2.incHours(1);
                } else
                {
                    setResultLabel(person2.name + " выдвинул обвинительные показания против другого! Итог: " + person1.name + " - 10 лет тюрьмы! " + person2.name + " - свободен!");
                    person1.incHours(10);
                }
            } else
            {
                if (!isAccuse2)
                {
                    setResultLabel(person1.name + " выдвинул обвинительные показания против другого! Итог: " + person1.name + " - свободен! " + person2.name + " - 10 лет тюрьмы!");
                    person2.incHours(10);
                } else
                {
                    setResultLabel("Вы и ваш товарищ (или совсем не товарищ) по несчастью выдвинули против друг друга обвинительных показаний. Вам дали по два года тюрьмы.");
                    person1.incHours(2);
                    person2.incHours(2);
                }
            }
            showResultPerson();
            if (OneComputerGame != null)
            {
                person1.saveToFile();
                person2.saveToFile();
            }
        }

        public Result(OneComputerGame oneComputerGame, Person person1, Person person2, bool isAccuse1, bool isAccuse2)
        {
            this.OneComputerGame = oneComputerGame;
            this.person1 = person1;
            this.person2 = person2;
            this.isAccuse1 = isAccuse1;
            this.isAccuse2 = isAccuse2;
            InitializeComponent();
            judge(isAccuse1, isAccuse2);
        }

        public Result(InternetGame internetGame, Person person, bool isAccuse1, bool isAccuse2)
        {
            this.InternetGame = internetGame;
            this.person1 = person;
            this.isAccuse1 = isAccuse1;
            this.isAccuse2 = isAccuse2;
            InitializeComponent();
            judge(isAccuse1, isAccuse2);
        }
    }
}
