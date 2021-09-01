using System;

namespace Constructor
{
    public class Vehicle
    {
        private readonly string  _registrationNumber;
       // public Vehicle()
        //{
      //      Console.WriteLine("Vehicle is being initialized");

        //}
        public Vehicle(string registrationnumber)
        {
            _registrationNumber = registrationnumber;
            Console.WriteLine("Vehicle is being initialized.{0}", registrationnumber);
        }
    }
}
