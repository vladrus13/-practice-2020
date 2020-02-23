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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void OneComputerGameButton_Click(object sender, EventArgs e)
        {
            OneComputerProfile oneComputerProfile = new OneComputerProfile();
            oneComputerProfile.Show();
            this.Hide();
        }

        private void InternetGameButton_Click(object sender, EventArgs e)
        {
            InternetProfile internetProfile = new InternetProfile();
            internetProfile.Show();
            this.Hide();
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
