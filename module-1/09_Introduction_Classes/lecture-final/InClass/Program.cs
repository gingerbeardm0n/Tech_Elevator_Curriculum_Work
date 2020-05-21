using System;

namespace InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make= "Honda";
            myCar.Model = "CR-V";
            myCar.year = 2020;

            Car herCar = new Car();

            herCar.Make = "Honda";
            herCar.Model = "Civic";
            herCar.year = 2019;

            Car chrisCar = new Car("Honda", "Civic", 2010);



            myCar.Display();
            herCar.Display();
            chrisCar.Display();

            if (myCar.Equals(chrisCar))
            {
                Console.WriteLine("They are equal");
            }

            Console.WriteLine(chrisCar);


            Console.ReadLine();
        }
    }
}
