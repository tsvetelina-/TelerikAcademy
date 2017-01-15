﻿
using System;
using System.Collections.Generic;
using Dealership.Common.Enums;
using Dealership.Contracts;
using Dealership.Common;
using System.Text;

namespace Dealership.Models
{
    public class User : IUser
    {
        private string firstName;
        private string lastName;
        private string password;
        private string role;
        private string username;


        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);
            this.Vehicles = new List<IVehicle>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Validator.ValidateNull(value, Constants.UserCannotBeNull);
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname",
                    Constants.MinNameLength, Constants.MaxNameLength));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                Validator.ValidateNull(value, Constants.UserCannotBeNull);
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname",
                    Constants.MinNameLength, Constants.MaxNameLength));

                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                Validator.ValidateNull(value, Constants.UserCannotBeNull);
                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength,
                   String.Format(Constants.StringMustBeBetweenMinAndMax, nameof(Password),
                    Constants.MinPasswordLength, Constants.MaxPasswordLength));
                Validator.ValidateSymbols(value, Constants.PasswordPattern,
                    String.Format(Constants.InvalidSymbols, nameof(Password)));

                this.password = value;
            }
        }

        public Role Role { get; set; }

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                Validator.ValidateNull(value, Constants.UserCannotBeNull);
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                   String.Format(Constants.StringMustBeBetweenMinAndMax, nameof(Username),
                   Constants.MinNameLength, Constants.MaxNameLength));
                Validator.ValidateSymbols(value, Constants.UsernamePattern,
                    String.Format(Constants.InvalidSymbols, nameof(Username)));

                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles { get; set; }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            throw new NotImplementedException();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);

            if (this.Role != Role.Admin)
            {
                var count = this.Vehicles.Count;

                if (count == 5)
                {
                    if (this.Role != Role.Normal)
                    {
                        Vehicles.Add(vehicle);
                    }
                    else
                    {
                        throw new ArgumentException(String.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
                    }
                }
                else
                {
                    Vehicles.Add(vehicle);
                }

            }
            else
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }

        }

        public string PrintVehicles()
        {
            var sb = new StringBuilder();
            var counter = 0;
            sb.AppendLine(String.Format("--USER {0}--", this.Username));

            foreach (var vehicle in Vehicles)
            {
                counter += 1;
                sb.AppendLine(String.Format("{0}. {1}:", counter, vehicle.Type));
                sb.Append(vehicle.ToString());               
            }

            return sb.ToString().TrimEnd();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
            Vehicles.Remove(vehicle);
        }
    }
}
