using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7library
{
    class Overridings
    {
    }

    public class Armorsuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    public class IronMan : Armorsuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    public class WarMachine : Armorsuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }
}
