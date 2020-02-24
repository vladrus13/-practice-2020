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
        OneComputerProfile OneComputerProfile;
        InternetProfile InternetProfile;

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (person2 != null)
            {
                OneComputerProfile.clear(person1, person2);
                OneComputerProfile.Show();
                this.Hide();
            } else
            {
                InternetProfile.clear(person1);
                InternetProfile.Show();
                this.Hide();
            }
        }

        private void setResultLabel(String s)
        {
            ResultLabel.Text = s;
        }

        public void clear()
        {
            ResultLabel.Text = "";
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

        public void judge(string login1, string login2, bool isAccuse1, bool isAccuse2)
        {
            Tuple<int, int> addedToHouse;
            if (!isAccuse1)
            {
                if (!isAccuse2)
                {
                    setResultLabel("Вы и ваш товарищ по несчастью не выдвинули против друг друга обвинительных показаний. Вам дали по году тюрьмы.");
                    addedToHouse = new Tuple<int, int>(1, 1);
                } else
                {
                    setResultLabel(login2 + " выдвинул обвинительные показания против другого! Итог: " + login1 + " - 10 лет тюрьмы! " + login2 + " - свободен!");
                    addedToHouse = new Tuple<int, int>(10, 0);
                }
            } else
            {
                if (!isAccuse2)
                {
                    setResultLabel(login1 + " выдвинул обвинительные показания против другого! Итог: " + login1 + " - свободен! " + login2 + " - 10 лет тюрьмы!");
                    addedToHouse = new Tuple<int, int>(0, 10);
                } else
                {
                    setResultLabel("Вы и ваш товарищ (или совсем не товарищ) по несчастью выдвинули против друг друга обвинительных показаний. Вам дали по два года тюрьмы.");
                    addedToHouse = new Tuple<int, int>(2, 2);
                }
            }
            person1.incWon();
            person1.incHours(addedToHouse.Item1);
            if (OneComputerProfile != null)
            {
                person2.incWon();
                person2.incHours(addedToHouse.Item2);
                person1.saveToFile();
                person2.saveToFile();
            }
            showResultPerson();
        }

        public Result(OneComputerProfile oneComputerProfile, Person person1, Person person2, bool isAccuse1, bool isAccuse2)
        {
            this.OneComputerProfile = oneComputerProfile;
            this.person1 = person1;
            this.person2 = person2;
            this.isAccuse1 = isAccuse1;
            this.isAccuse2 = isAccuse2;
            InitializeComponent();
            judge(person1.name, person2.name, isAccuse1, isAccuse2);
        }

        public Result(InternetProfile internetProfile, string login2, Person person, bool isAccuse1, bool isAccuse2)
        {
            this.InternetProfile = internetProfile;
            this.person1 = person;
            this.isAccuse1 = isAccuse1;
            this.isAccuse2 = isAccuse2;
            InitializeComponent();
            judge(person.name, login2, isAccuse1, isAccuse2);
        }
    }
}
