using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_pop
{
    public class Dog
    {
        private string name;
        private string breed;

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
        public string Name
        {
            get{ return this.name; }
            set{ this.name = value; }
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public void Bark()
        {
            Console.WriteLine("Waouff");
        }

    }
}
