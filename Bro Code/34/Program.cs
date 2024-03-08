﻿using System;

namespace My34thProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // overload constructors = technique to create multiple constuctors,
            //                                             with a different set of parameters
            //                                             name + parameters = signature

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella" );

            


        }
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}