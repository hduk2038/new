using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2


{

    public class Account
    {
        private string username, password, userType, firstName, lastName, dob;

        public Account()
        {

        }

        public Account(string username, string password, string userType, string firstName, string lastName, string dob)
        {
            this.username = username;
            this.password = password;
            this.userType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;

        }
        public bool check(string username, string password)
        {
            StreamReader reader = new StreamReader("login.txt");

            string record = reader.ReadLine();

            while (record != null)
            {
                string[] data = record.Split(',');
                if (data.Length >= 2)
                {
                    if (data[0] == username && data[1] == password)
                    {
                        userType = data[2];
                        return true;
                    }
                }
                record = reader.ReadLine();
            }
            return false;
        }
        public string getUserType()
        {
            return userType;
        }

        public void write()

        {
            StreamWriter streamWriter = new StreamWriter("login.txt", true);
            StringWriter stringWriter = new StringWriter();
            stringWriter.WriteLine("{0},{1},{2},{3},{4},{5}", username, password, userType, firstName, lastName, dob);
            streamWriter.Write(stringWriter);

            streamWriter.Close();
        }



    }
}
