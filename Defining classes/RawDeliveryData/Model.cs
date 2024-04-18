using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDeliveryData
{
    public class Model
    {
        public Model(string name, int speed, int power)
        {
            this.Name = name;
            this.Speed = speed;
            this.Power = power;
        }

        public string Name { get; }
        public int Speed { get; }
        public int Power { get; }
    }
}
