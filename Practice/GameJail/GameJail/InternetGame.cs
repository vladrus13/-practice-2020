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
            dataBase.SendAction(id, person.name, isAccuse ? 2 : 1);
            StatusBox.Text += "Waiting opponent...";
            
        }

        private void goToResults()
        {
            if (time % 10 == 0)
            {
                Tuple<Tuple<String, int>, Tuple<String, int>> answer = dataBase.GetResult(id);
                if (answer.Item1.Item2 != 0 && answer.Item2.Item2 != 0)
                {
                    string nameSecond = (answer.Item1.Item1 != person.name ? answer.Item1.Item1 : answer.Item2.Item1);
                    if (result == null)
                    {
                        result = new Result(this, nameSecond, person, (answer.Item1.Item2 == 1 ? false : true), (answer.Item2.Item2 == 1 ? false : true));
                    } else
                    {
                        result.clear();
                        result.judge(person.name, nameSecond, (answer.Item1.Item2 == 1 ? false : true), (answer.Item2.Item2 == 1 ? false : true));
                    }
                    this.Hide();
                    result.Show();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time >= 0)
            {
                TimerBox.Text = time.ToString();
            }
            if (time == 0)
            {
                answer(false);
            }
            goToResults();
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
