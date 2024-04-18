using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDeliveryData
{
    public class Payload
    {
        public Payload(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight { get; }
        public string Type { get; }
    }
}
