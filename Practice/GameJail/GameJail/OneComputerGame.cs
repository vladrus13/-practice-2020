﻿using System;
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
    public partial class OneComputerGame : Form
    {
        private Person person1, person2;
        private bool isAccuse1 = false, isAccuse2 = false;
        private Result result;
        OneComputerProfile OneComputerProfile;

        public OneComputerGame(OneComputerProfile OneComputerProfile, Person person1, Person person2)
        {
            this.OneComputerProfile = OneComputerProfile;
            this.person1 = person1;
            this.person2 = person2;
            InitializeComponent();
        }

        private int status = 0;

        // status = 
        //          0 - nobody is answer
        //          1 - first answer
        //          2 - second answer

        public void clear()
        {
            status = 0;
            isAccuse1 = false;
            isAccuse2 = false;
        }

        private void call()
        {
            if (result == null)
            {
                result = new Result(OneComputerProfile, person1, person2, isAccuse1, isAccuse2);
            }
            else
            {
                result.clear();
                result.judge(person1.name, person2.name, isAccuse1, isAccuse2);
            }
            result.Show();
            this.Hide();
        }

        private void OneComputerGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AccuseButton_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                isAccuse1 = true;
                status++;
            }
            else
            {
                if (status == 1)
                {
                    isAccuse2 = true;
                    status++;
                    call();
                }
            }
        }

        private void SilenceButton_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                isAccuse1 = false;
                status++;
            }
            else
            {
                if (status == 1)
                {
                    isAccuse2 = false;
                    status++;
                    call();
                }
            }
        }
    }
}
