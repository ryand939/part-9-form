using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_9
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string email;
        private int studentNumber;


        public Student(string firstName, string lastName)
        {
            Random random = new Random();
            this.firstName = char.ToUpper(firstName[0]) + firstName.Substring(1); ;
            this.lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
            studentNumber = random.Next(0, 1000) + 555000;
            GenerateEmail();
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = char.ToUpper(value[0]) + value.Substring(1);
                GenerateEmail();
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
                GenerateEmail();
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
        }
        public int StudentNumber
        {
            get
            {
                return studentNumber;
            }
        }
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
        public void reset()
        {
            Random random = new Random();
            studentNumber = random.Next(0, 1000) + 555000;
            GenerateEmail();
        }
        private void GenerateEmail()
        {
            string fName3, lName3;
            fName3 = (firstName.Length <= 3) ? firstName : firstName.Substring(0, 3);
            lName3 = (lastName.Length <= 3) ? lastName : lastName.Substring(0, 3);
            email = firstName + lastName + (studentNumber + "").Substring(3) + "@ICS4U.com";
        }
    }
}
