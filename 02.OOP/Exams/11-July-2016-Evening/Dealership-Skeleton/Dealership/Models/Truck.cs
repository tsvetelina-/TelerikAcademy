using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price,int weightCapacity)
            : base(make, model, price)
        {
            base.Wheels = (int)VehicleType.Truck;
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
            set
            {
                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity,
                    String.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight-capacity",
                    Constants.MinCapacity, Constants.MaxCapacity));

                this.weightCapacity = value;
            }
        }

    }
}
