using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.MainImplementation
{
    public class LiscovSubstitution
    {
    }

    public abstract class Car
    {
        public abstract void Blink();
    }

    public class Honda : Car
    {
        public override void Blink()
        {
            Console.WriteLine("I am blinking as Honda");
        }

        public void Click() { Console.WriteLine("I am Honda, so I click often and you have to take me to a garage."); }
    }

    public class Mazda : Car
    {
        public override void Blink()
        {
            Console.WriteLine("I am blinking as Mazda");
        }
    }

    //public class Bmw : Car
    public class Bmw : CarThatDoesntBlink
    {
        /*        public override void Blink()
                {
                    throw new NotImplementedException();
                }*/
        public override void Beep()
        {
            Console.WriteLine("I am beeping at you, because I can't blink!!");
        }
    }

    public abstract class CarThatDoesntBlink
    {
        public abstract void Beep();
    }

    public class NullCar : Car
    {
        public override void Blink()
        {
            Console.WriteLine("I am not a car, so I don't blink!!");
        }
    }
}
