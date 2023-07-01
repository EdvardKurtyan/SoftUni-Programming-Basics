﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> allTrucks = new List<Truck>();
            List<Car> allCars = new List<Car>();

            while (true)
            {
                string[] vehicle = Console.ReadLine().Split('/').ToArray();
                string action = vehicle[0];
                if (action == "end") break;

                if (action == "Truck")
                {
                    Truck truck = new Truck
                    {
                        Brand = vehicle[1],
                        Model = vehicle[2],
                        Weight = double.Parse(vehicle[3])
                    };
                    allTrucks.Add(truck);
                }
                else if (action == "Car")
                {
                    Car car = new Car
                    {
                        Brand = vehicle[1],
                        Model = vehicle[2],
                        HP = int.Parse(vehicle[3])
                    };
                    allCars.Add(car);
                }
            }

            if (allCars.Count > 0)
            {
                List<Car> sortedCars = allCars.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (var curentCar in sortedCars)
                {
                    // Audi: A3 - 110hp
                    Console.WriteLine($"{curentCar.Brand}: {curentCar.Model} - {curentCar.HP}hp");
                }
            }
            if (allTrucks.Count > 0)
            {
                List<Truck> sortedTrucks = allTrucks.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (var curentTruck in sortedTrucks)
                {
                    // Mercedes: Actros - 9019kg
                    Console.WriteLine($"{curentTruck.Brand}: {curentTruck.Model} - {curentTruck.Weight}kg");
                }
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }
}

