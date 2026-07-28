using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IVehicleControl
    {
        void Start();
        void Stop();

    }

    class Car : IVehicleControl
    {
        public void Start() { Console.WriteLine("Car Starts"); }
        public void Stop() { Console.WriteLine("Car Stops"); }

    }

    class Drone : IVehicleControl
    {
        public void Start() { Console.WriteLine("Drone Starts"); }
        public void Stop() { Console.WriteLine("Drone Stops"); }
    }

    class Bicycle : IVehicleControl
    {
        public void Start() { Console.WriteLine("Bicycle Start"); }
        public void Stop() { Console.WriteLine("Bicycle Stops"); }

    }

}

