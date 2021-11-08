using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            

            for (int i = 0; i < countCars; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split()
                    .ToArray();
                string nameCar = carsInfo[0];
                double fuel = double.Parse(carsInfo[1]);
                double consumption = double.Parse(carsInfo[2]);

                Car cuurentCar = new Car(nameCar, fuel, consumption);
                cars.Add(nameCar, cuurentCar);

            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitedInput = input
                    .Split()
                    .ToArray();

                string carModel = splitedInput[1];
                double amountOfKm = double.Parse(splitedInput[2]);

                Car carForCheck = cars[carModel];
                Car.CalculateWhetherCanCarMove(carForCheck, amountOfKm);

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:F2} {car.Value.TravelledDistance}");
            }
        }
    }
}
