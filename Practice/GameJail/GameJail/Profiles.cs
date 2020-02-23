using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameJail
{

    class FileSaveException : Exception
    {
        public FileSaveException(string message)
         : base(message)
        { }
    }

    public class Person // main class for profile. Contain name, password, number of wins and losses, number of hours spent in prison.
    {
        private IDataBase dataBase;
        public string name, password;
        public Int64 games = 0, hours = 0;

        public Person(string name, string password, Int64 games, Int64 hours, IDataBase dataBase)
        {
            this.name = name;
            this.password = password;
            this.games = games;
            this.hours = hours;
            this.dataBase = dataBase;
        }

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
                this.games = 0;
                hours = 0;
                return;
            } catch (Exception e)
            {
                throw new FileSaveException("Can't load or read profile file" + e.StackTrace);
            }
            if (line1 == null || line2 == null) {
                throw new FileSaveException("Person file was modified");
            }
            string[] data = line1.Split(new char[] { ' ' });
            if (data.Length != 4)
            {
                throw new FileSaveException("Person file was modified");
            }
            this.name = data[0];
            this.password = data[1];
            int checksum;
            try
            {
                this.games = Int64.Parse(data[2]);
                this.hours = Int64.Parse(data[3]);
                checksum = int.Parse(line2);
            } catch (Exception)
            {
                throw new FileSaveException("Person file was modified");
            }
            if (games + hours != checksum)
            {
                throw new FileSaveException("Person file was modified");
            }
            if (password != this.password)
            {
                throw new FileSaveException("Incorrect login or password");
            }
        }

        public void incWon()
        {
            games++;
        }

        public void incHours(int added)
        {
            hours += added;
        }

        public string toString()
        {
            return name + ' ' + password + ' ' + games.ToString() + ' ' + hours.ToString() + '\n' +
                (games + hours).ToString(); // last is checksum.
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
                throw new FileSaveException("Can't load profile " + name + "\nException: " + e.Message);
            }
        }

    }
}
