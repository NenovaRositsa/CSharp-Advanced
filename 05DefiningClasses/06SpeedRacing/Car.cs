using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
      
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuel, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TravelledDistance = 0.00;
        }

        public static void CalculateWhetherCanCarMove(Car currentCar, double distance)
        {
            if (currentCar.FuelConsumptionPerKilometer * distance <= currentCar.FuelAmount)
            {
                currentCar.TravelledDistance += distance;
                currentCar.FuelAmount -= currentCar.FuelConsumptionPerKilometer * distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
