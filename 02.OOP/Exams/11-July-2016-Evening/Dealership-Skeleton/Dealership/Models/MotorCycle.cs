using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;
using Dealership.Common;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class MotorCycle : Vehicle, IMotorcycle
    {
        private string category;

        public MotorCycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            base.Wheels = (int)VehicleType.Motorcycle;
            this.Category = category;
            base.Type = VehicleType.Motorcycle;
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, nameof(Category),
                    Constants.MinCategoryLength, Constants.MaxCategoryLength));

                this.category = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString());

            sb.Append(String.Format("  Category: {0}", this.Category));

            return sb.ToString();
        }

    }
}
