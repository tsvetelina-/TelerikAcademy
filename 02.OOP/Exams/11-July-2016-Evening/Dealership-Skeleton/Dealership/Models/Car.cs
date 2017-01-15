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
    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            base.Wheels = (int)VehicleType.Car;
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
            set
            {
                Validator.ValidateIntRange(value, Constants.MinWheels, Constants.MaxWheels,
                    String.Format(Constants.NumberMustBeBetweenMinAndMax, nameof(Wheels),
                    Constants.MinWheels, Constants.MaxWheels));

                this.seats = value;
            }
        }

    }
}
