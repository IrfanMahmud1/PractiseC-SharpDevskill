using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    internal class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    internal class Rectangle
    {
        public readonly double width;
        public readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double AreaOfRectangle()
        {
            return width * height;
        }
    }

    internal class BankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;

            }
        }
    }

    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public string GetCarInfo()
        {
            return Make + " " + Model;
        }
    }

    internal class Temperature
    {
        private double celcius { get; set; }
        public double Celcius
        {
            get { return celcius; }
            set { celcius = value; }
        }

        public double CelciusToFahrenheit()
        {
            return (celcius * 9 / 5 ) + 32;
        }
    }
}
