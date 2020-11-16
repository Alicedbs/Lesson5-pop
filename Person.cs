using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_pop
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {
        }


        public string Name
        {
            get { return name; }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name can not be empty");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0 || value > 100) 
                {
                    throw new ArgumentOutOfRangeException("The age must be between 0 and 100 yo");
                }
                age = value; 
            }
        }

        public string Email
        {
            get => email; set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new FormatException("the format of email is not correct");
                }
             this.email = value; 
            }
        }

        public override string ToString()
        {
            return "The person name is " + Name + " his name is " + Age + " and his email is " + Email ;
        }
    }

}
