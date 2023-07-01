using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            double carHorsePowerSum = 0;
            double truckHorsePowerSum = 0;
            int carsCount = 0;
            int truuckCount = 0;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;
                string[] input = command.Split();
                string type = input[0];
                string model = input[1];
                string color = input[2];
                int horsePower = int.Parse(input[3]);

                switch (type)
                {
                    case "car":
                        Car car = new Car(type, model, color, horsePower);
                        cars.Add(car);
                        carHorsePowerSum += horsePower;
                        carsCount++;
                        break;
                    case "truck":
                        Truck truck = new Truck(type, model, color, horsePower);
                        trucks.Add(truck);
                        truckHorsePowerSum += horsePower;
                        truuckCount++;
                        break;
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close the Catalogue") break;
                foreach (var curentCar in cars)
                {
                    if (curentCar.Model == command)
                    {
                        //Type: Car
                        //Model: Ferrari
                        //Color: red
                        //Horsepower: 550

                        Console.WriteLine($"Type: {curentCar.Type}");
                        Console.WriteLine($"Model: {curentCar.Model}");
                        Console.WriteLine($"Color: {curentCar.Color}");
                        Console.WriteLine($"Horsepower: {curentCar.HorsePower}");
                        break;
                    }
                }
                foreach (var curentTruck in trucks)
                {
                    if (curentTruck.Model == command)
                    {
                        //Type: Car
                        //Model: Ferrari
                        //Color: red
                        //Horsepower: 550

                        Console.WriteLine($"Type: {curentTruck.Type.Substring(0)}");
                        Console.WriteLine($"Model: {curentTruck.Model}");
                        Console.WriteLine($"Color: {curentTruck.Color}");
                        Console.WriteLine($"Horsepower: {curentTruck.HorsePower}");
                        break;
                    }
                }
            }
            Console.WriteLine($"Cars have average horsepower of: {(carHorsePowerSum / carsCount):f2}.");
            Console.WriteLine($"Truks have average horsepower of: {(truckHorsePowerSum / truuckCount):f2}.");
        }
    }
    class Car
    {
        public Car(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public Truck(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}

