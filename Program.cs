using System;

namespace ClassExercise5222
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("What was your first car?");
            Console.WriteLine();


            Car myFirstCar = new Car()
            {
                Year = 2005,
                Make = "Ford",
                Model = "Escape",
            };

            Console.WriteLine(myFirstCar.Year);
            Console.WriteLine(myFirstCar.Make);
            Console.WriteLine(myFirstCar.Model);

        }
    }
}
