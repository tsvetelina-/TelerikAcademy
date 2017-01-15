using Dealership.Contracts;
using System;
using Dealership.Models;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Factories
{
    public class DealershipFactory : IDealershipFactory
    {
        public IVehicle CreateCar(string make, string model, decimal price, int seats)
        {
            IVehicle car = new Car(make,model,price,seats);

            Validator.ValidateNull(car, Constants.UserCannotBeNull);

            return car;
        }

        public IVehicle CreateMotorcycle(string make, string model, decimal price, string category)
        {
            IVehicle motorcycle = new MotorCycle(make, model, price, category);

            Validator.ValidateNull(motorcycle, Constants.UserCannotBeNull);

            return motorcycle;
        }

        public IVehicle CreateTruck(string make, string model, decimal price, int weightCapacity)
        {
            IVehicle truck = new Truck(make, model, price, weightCapacity);

            Validator.ValidateNull(truck , Constants.UserCannotBeNull);

            return truck;
        }

        public IUser CreateUser(string username, string firstName, string lastName, string password, string role)
        {
            IUser user = new User(username, firstName, lastName, password, role);

            Validator.ValidateNull(user, Constants.UserCannotBeNull);

            return user;
        }

        public IComment CreateComment(string content)
        {
            return new Comment(content);
        }
    }
}
