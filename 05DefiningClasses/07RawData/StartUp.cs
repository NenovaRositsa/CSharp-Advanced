using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp


    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<Tire> tiresOfCurrentCar = new List<Tire>();

                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                double[] infoTires = input.Skip(5).Select(double.Parse).ToArray();

                Engine currentEngine = new Engine(engineSpeed, enginePower);
                Cargo currentcargo = new Cargo(cargoWeight, cargoType);

                for (int j = 0; j < infoTires.Length; j+=2)
                {
                    double currentTirePressure = infoTires[j];
                    double currentTireAge = infoTires[j + 1];

                    Tire currentTire = new Tire(currentTirePressure, currentTireAge);
                    tiresOfCurrentCar.Add(currentTire);
                }

                Car currentCar = new Car(model, currentEngine, currentcargo, tiresOfCurrentCar);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    FilterForPressureAndType(car);
                }
            }
            else if(command == "flamable")
            {
                foreach (var car in cars)
                {
                    FilterForPowerAndType(car);
                }
            }

        }

        public static void FilterForPressureAndType(Car car)
        {
            bool isItForPrinting = false;

            if (car.Cargo.Type == "fragile")
            {
                foreach (var tire in car.Tires)
                {
                    if (tire.Pressure < 1)
                    {
                        isItForPrinting = true;
                        break;
                    }
                }
            }

            if (isItForPrinting)
            {
                Console.WriteLine(car.Model);
            }
        }

        public static void FilterForPowerAndType(Car car)
        {
            bool isItForPrinting = false;

            if (car.Cargo.Type == "flamable")
            {
                if (car.Engine.Power > 250)
                {
                    isItForPrinting = true;
                    
                }
            }

            if (isItForPrinting)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
