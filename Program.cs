using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_pop
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task1();
            //Task2();
            Task3();
            Console.ReadKey();
        }

        private static void Task1()
        {
            Dog myDog = new Dog("FELIX", "Doberman");
            Console.WriteLine("Hello " + myDog.Name);
            myDog.Bark();
        }

        private static void Task2()
        {
            Person person1 = new Person("Alice", 19);
            Person person2 = new Person("Martin", 23, "martin@gmail.com");
            Person person3 = new Person("Corinne", 20, "corinne@gmail.com");
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
        }
        private static void Task3()
        {
            Laptop laptop1 = new Laptop("HD253", 28);
            Console.WriteLine(laptop1.ToString());
        }
    } 
}
