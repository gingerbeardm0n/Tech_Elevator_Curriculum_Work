using System;

namespace InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Honda";
            myCar.Model = "CR-V";
            myCar.year = 2020;

            //classname "Car" is the template, path, or source code

            Car herCar = new Car();
            herCar.Make = "Honda";
            herCar.Model = "Civic";
            herCar.year = 2019;

            Car chrisCar = new Car("Honda", "Civic", 2010);

            // don't have to set any of the values
            // it will set the variables to the default defined in the template class

            myCar.Display();
            herCar.Display();
            chrisCar.Display();

            if (myCar.Equals(chrisCar))
            {
                Console.WriteLine("They are equal");
            }

            Console.ReadLine();
        }

    }
}
