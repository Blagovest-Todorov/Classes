﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {

        public Car() 
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year )
              :this()  // this calls the empty Ctor
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        
        //Properties
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        //Methods 
        public void Drive(double distance) 
        {
            double fuelToConsume = distance * FuelConsumption;

            if (FuelQuantity - fuelToConsume >= 0)
            {
                
                FuelQuantity -= fuelToConsume;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI() 
        {
           return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }
    }
}
