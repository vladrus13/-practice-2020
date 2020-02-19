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
    public partial class Form1 : Form
    {
        private Person person;
        public Form1()
        {
            InitializeComponent();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        

        private void reload()
        {
            label1.Text = "Побед: " + person.won;
            label2.Text = "Поражений: " + person.lose;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            person.incWon();
            reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            person.incLosses();
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            person = new Person(textBox1.Text, "123456");
            button3.Enabled = true;
            button4.Enabled = true;
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (person == null)
            {
                person = new Person(textBox1.Text, "123456");
                reload();
            }
            person.saveToFile();
        }
    }
}
