using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDeliveryData
{
    public class Car
    {
        public Car(Model model, Payload payload, Tyre[] carTyres)
        {
            this.Model = model;
            this.Payload = payload;
            this.CarTyres = carTyres;
        }

        public Model Model { get; }
        public Payload Payload { get; }
        public Tyre[] CarTyres { get; }
    }
}
