using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameJail
{

    class PersonException : Exception
    {
        public PersonException(string message)
         : base(message)
        { }
    }

    class Person // main class for profile. Contain name, password, number of wins and losses, number of hours spent in prison.
    {
        public string name, password;
        public int won = 0, lose = 0, hours = 0;

        public Person(string name, string password)
        {
            // load from files
            string readPath = Environment.CurrentDirectory + "\\assets\\profiles\\" + name + ".txt";
            string line1, line2;
            try
            {
                StreamReader reader = new StreamReader(readPath, Encoding.Default);
                line1 = reader.ReadLine();
                line2 = reader.ReadLine();
                reader.Close();
            } catch (FileNotFoundException)
            {
                this.name = name;
                this.password = password;
                this.won = 0;
                lose = 0;
                hours = 0;
                return;
            } catch (Exception e)
            {
                throw new PersonException("Can't load or read profile file" + e.StackTrace);
            }
            if (line1 == null || line2 == null) {
                throw new PersonException("Person file was modified");
            }
            string[] data = line1.Split(new char[] { ' ' });
            if (data.Length != 5)
            {
                throw new PersonException("Person file was modified");
            }
            this.name = data[0];
            this.password = data[1];
            int checksum;
            try
            {
                this.won = int.Parse(data[2]);
                this.lose = int.Parse(data[3]);
                this.hours = int.Parse(data[4]);
                checksum = int.Parse(line2);
            } catch (Exception)
            {
                throw new PersonException("Person file was modified");
            }
            if (won + lose + hours != checksum)
            {
                throw new PersonException("Person file was modified");
            }
        }

        public void incWon()
        {
            won++;
        }

        public void incLosses()
        {
            lose++;
        }

        public void incHours(int added)
        {
            hours += added;
        }

        public string toString()
        {
            return name + ' ' + password + ' ' + won.ToString() + ' ' + lose.ToString() + ' ' + hours.ToString() + '\n' +
                (won + lose + hours).ToString(); // last is checksum.
        }

        public void saveToFile() // can throw PersonException
        {
            string writed = this.toString();
            string writePath = Environment.CurrentDirectory + "\\assets\\profiles\\" + name + ".txt";
            try
            {
                StreamWriter writer = new StreamWriter(writePath, false, Encoding.Default);
                writer.WriteLine(writed);
                writer.Close();
            } catch (Exception e)
            {
                throw new PersonException("Can't load profile " + name + "\nException: " + e.Message);
            }
        }

    }
}
