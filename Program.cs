using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFordBronco = new Car(4000, "Ford", "Bronco", 1982);

            Car mySubaru = new Car(20000, "Subaru", "Forrester", 1999);

            Console.WriteLine(mySubaru.Description);
            Console.WriteLine(myFordBronco.Description);

            myFordBronco.Drive(9999);

            Console.WriteLine($"Bronco needs service: 🏎 🏎 {myFordBronco.NeedsMaintenance}");

            myFordBronco.Drive(60);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Service(true);
        }
    }
}