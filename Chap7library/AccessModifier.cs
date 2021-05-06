using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7library
{
    public class AccessModifier
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if (temperature<-5 || temperature>42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temperature = temperature;
        }

        public void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }
}
