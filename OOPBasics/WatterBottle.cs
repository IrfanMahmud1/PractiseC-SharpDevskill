using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class WatterBottle
    {
        private double capacity;
        private string color;
        private double waterAmount;

        public double Capacity
        {
            get { return capacity; }
        }

        public WatterBottle(double capacity, string color)
        {
            this.capacity = capacity;
            this.color = color; 
        }

        public double WaterAmount
        {
            get { return waterAmount; }
            set
            {
                if (value <= capacity)
                {
                    waterAmount = value;
                }
            }
        }
        public void AddWater(double Amount)
        {
            if(waterAmount + Amount <=capacity)
            {
                waterAmount += Amount;
            }
        }

        public void ReleaseWater(double Amount)
        {
            if (Amount > waterAmount )
            {
                waterAmount = 0;
            }
            else
            {
                waterAmount -= Amount;
            }
        }
    }
}
