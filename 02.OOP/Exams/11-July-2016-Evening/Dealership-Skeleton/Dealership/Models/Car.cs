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
            base.Type = VehicleType.Car;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
            set
            {
                Validator.ValidateIntRange(value, Constants.MinSeats,Constants.MaxSeats,
                    String.Format(Constants.NumberMustBeBetweenMinAndMax, nameof(Seats),
                    Constants.MinSeats, Constants.MaxSeats));

                this.seats = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString());

            sb.Append(String.Format("  Seats: {0}", this.Seats));

            return sb.ToString().TrimEnd();
        }

    }
}
