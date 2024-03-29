﻿using System;

namespace My33rdProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //                rather than to any specific object


            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Lambo");

            //Console.WriteLine(car1.numberOfCars); //none static way
            //Console.WriteLine(car2.numberOfCars);

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();
        }
    }
    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}