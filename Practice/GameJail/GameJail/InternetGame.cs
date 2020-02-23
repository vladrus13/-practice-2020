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
    public partial class InternetGame : Form
    {
        Person person;
        IDataBase dataBase;
        int time = 30;
        long id;
        Result result;

        public InternetGame(Person person, IDataBase dataBase, long id)
        {
            this.person = person;
            this.dataBase = dataBase;
            this.id = id;
            time = 30;
            InitializeComponent();
            timer1.Start();
        }

        public void clear()
        {
            StatusBox.Text = "";
            time = 30;
            timer1.Start();
            AccuseButton.Enabled = true;
            SilenceButton.Enabled = true;
        }

        private void answer(bool isAccuse)
        {
            long hours = person.hours;
            long games = person.games;
            AccuseButton.Enabled = false;
            SilenceButton.Enabled = false;
            timer1.Stop();
            dataBase.SendAction(id, person.name, isAccuse ? 2 : 1);
            StatusBox.Text += "Waiting opponent...";
            while (dataBase.GetPerson(person.name, person.password).games == games)
            {
                System.Threading.Thread.Sleep(5000);
            }
            person = dataBase.GetPerson(person.name, person.password);
            bool isAccuse1 = false, isAccuse2 = false;
            switch (person.hours - hours)
            {
                case 0: isAccuse1 = true; isAccuse2 = false; break;
                case 1: isAccuse1 = false; isAccuse2 = false; break;
                case 2: isAccuse1 = true; isAccuse2 = true; break;
                case 10: isAccuse1 = false; isAccuse2 = true; break;
            }
            result = new Result(this, person, isAccuse1, isAccuse2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            TimerBox.Text = time.ToString();
            if (time == 0)
            {
                answer(false);
            }
        }

        private void AccuseButton_Click(object sender, EventArgs e)
        {
            answer(true);
        }

        private void SilenceButton_Click(object sender, EventArgs e)
        {
            answer(false);
        }
    }
}
