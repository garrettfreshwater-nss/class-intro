using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main (string[] args)
        {
            Car myFordBronco = new Car ();
            myFordBronco.Make = "Ford";
            myFordBronco.Model = "Bronco";
            myFordBronco.Year = 1982;

            Car mySubaru = new Car ()
            {
                Make = "Subaru",
                Model = "Forester",
                Year = 1999,
            };

            Console.WriteLine (mySubaru.Description);
            Console.WriteLine (myFordBronco.Description);

            myFordBronco.Drive (60);
        }
    }
}