using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Models
{
    internal class Chicken
    {
        public const int MinAge = 0;
        public const int MaxAge = 15;

        /*
         * private string name;
        private int age;
        */

        internal Chicken(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name)) 
                throw new ArgumentException("Name cannot be empty.");

            if (age < MinAge || age > MaxAge)
                throw new ArgumentException($"Age should be between {MinAge} and {MaxAge}.");

            this.Name = name;
            this.Age = age;
        }   

        public string Name { get; }
        public int Age { get; }

       /*
        * public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
               
                this.age = value;
            }
        }
       */

        public double GetProductPerDay()
        {
            return this.CalculateProductPerDay();
        }

        private double CalculateProductPerDay()
        {
            if (this.Age <= 3) return 1.5;
            else if (this.Age <= 7) return 2;
            else if (this.Age <= 11) return 1;
            else return 0.75;
        }
    }
}