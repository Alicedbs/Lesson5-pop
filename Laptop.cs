using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_pop
{
    class Laptop
    {
        //model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
        private string model;
        private static int price;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicCard;
        private string hdd;
        private int screen;
        

        public Laptop(string model, int price, string manufacturer, string processor, string ram, string graphicCard, string hdd, int screen)
        {
            Model = model;
            Price = price;
            Manufacturer = manufacturer;
            Processor = processor;
            Ram = ram;
            GraphicCard = graphicCard;
            Hdd = hdd;
            Screen = screen;
        }

        public Laptop(string model, int price) : this(model, price, null, null, null, null, null, 0)
        {
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("model can not be empty");
                }
                model = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("The price can't be negative");
                }
                price = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer can not be empty");
                }
                manufacturer = value;
            }
        }

        public string Processor
        {
            get { return processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name can not be empty");
                }
                processor = value;
            }
        }

        public string Ram
        {
            get { return ram; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("processor can not be empty");
                }
                ram = value;
            }
        }

        public string GraphicCard
        {
            get { return graphicCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name can not be empty");
                }
                graphicCard = value;
            }
        }

        public string Hdd
        {
            get { return hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name can not be empty");
                }
                hdd = value;
            }
        }

        public int Screen
        {
            get { return screen; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The screen size can't be negative");
                }
                screen = value;
            }
        }

        public override string ToString()
        {
            return "laptop model: " + Model + " /n its manufacturer is " + Manufacturer + "/n its price is " + Price + "/n its processor:" + Processor;
        }
    }
}
