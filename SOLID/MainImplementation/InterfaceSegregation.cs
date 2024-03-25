using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.MainImplementation
{
    public class InterfaceSegregation
    {
        //public InterfaceSegregation(IBeepingCar bmw, ICar honda, ICar2 porsche)
        public InterfaceSegregation(IBeepingCar bmw, HondaService honda, ICar2 porsche) 
        {
            //bmw.Blink(); 
            bmw.Beep(); 

            honda.Blink();
            honda.Beep(); 

            porsche.Blink();
            porsche.Beep();
        }
    }

    public interface ICar
    {
        void Blink();
        void Beep();
    }

    public interface ICar2 : IBlinkingCar, IBeepingCar { }

    public interface IBlinkingCar
    {
        void Blink();
    }

    public interface IBeepingCar
    {
        void Beep();
    }

    //public class BmwService : IBeepingCar
    public class BmwService : ICar
    {
        public void Beep()
        {
            Console.WriteLine("I'm beeping");
        }

        public void Blink()
        {
            throw new NotImplementedException();
        }
    }

    //public class HondaService : IBeepingCar, IBlinkingCar
    public class HondaService : ICar
    {
        public void Beep()
        {
            Console.WriteLine("I'm beeping");
        }

        public void Blink()
        {
            Console.WriteLine("I'm blinking");
        }
    }

    //public class PorscheService : ICar2 
    public class PorscheService : ICar
    {
        public void Blink()
        {
            Console.WriteLine($"{nameof(PorscheService)} blinking");
        }

        public void Beep()
        {
            Console.Write($"{nameof(PorscheService)} beeping");
        }
    }
}
