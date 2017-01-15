using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Models
{
    public class Vehicle : IVehicle
    {
        private string make;
        private string model;
        private decimal price;
        private int wheels;


        public Vehicle(string make,string model,decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Comments = new List<IComment>();
        }

        public IList<IComment> Comments { get; protected set; }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                Validator.ValidateNull(value, "Make name cannot be empty!");

                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, nameof(Make), Constants.MinMakeLength, Constants.MaxMakeLength));

                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;

            }
            set
            {
                Validator.ValidateNull(value, "Model name cannot be null!");

                Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, nameof(Model), Constants.MinModelLength, Constants.MaxModelLength));

                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {          
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice,
                    String.Format(Constants.NumberMustBeBetweenMinAndMax, nameof(Price), Constants.MinPrice, Constants.MaxPrice));

                this.price = value;
            }
        }

        public VehicleType Type { get; protected set; }

        public int Wheels
        {
            get
            {
                return this.wheels;
            }
            set
            {
                Validator.ValidateIntRange(value, Constants.MinWheels, Constants.MaxWheels,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, nameof(Wheels), Constants.MinWheels, Constants.MaxWheels));

                this.wheels = value;
            }
        }
    }
}

