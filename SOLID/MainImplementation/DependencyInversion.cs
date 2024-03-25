using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.MainImplementation
{
    public class DependencyInversion
    {

    }

    public class CarController
    {
        private readonly ICarService _carService; 
        public CarController(ICarService carService)
        {
            _carService = carService;
            _carService.Beep(); 
        }
    }

    public interface ICarService
    {
        void Blink();
        void Beep();
    }

    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository; 
        public CarService(ICarRepository repo)
        {
           _carRepository = repo;
        }

        public void Beep()
        {
            _carRepository.Blink();
        }

        public void Blink()
        {
            _carRepository.Beep(); 
        }
    }

    public interface ICarRepository
    {
        void Blink();
        void Beep(); 
    }

    public class CarRepository : ICarRepository
    {
        public void Beep()
        {
            Console.WriteLine("Beep"); 
        }

        public void Blink()
        {
            Console.WriteLine("Blink");
        }
    }
}
