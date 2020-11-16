using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_pop
{
    class Battery
    {
        private static int batteryLevel;
        private static int batteryLife;

        public Battery(int batteryLevel, int batteryLife)
        {
            BatteryLevel = batteryLevel;
            BatteryLife = batteryLife;
        }

        public Battery(int batteryLevel, int batteryLife) : this(0, 0)
        {
        }

        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Battery level can't be negative");
                }
                batteryLevel = value;
            }
        }

        public int BatteryLife
        {
            get { return batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Battery life can't be negative");
                }
                batteryLife = value;
            }
        }

    }
}
