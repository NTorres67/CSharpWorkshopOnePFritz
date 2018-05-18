using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkshopOnePFritz 
{
    class Program
    {
        static void Main(string[] args)
        {

            var stuff = new UserInterface.Foo();
            var mariasRealCar = new Ford.Fusion();
            mariasRealCar.Color = "Red";

            Console.WriteLine($"Maria's care is the color {mariasRealCar.Color}");

        }
    }
}


namespace CSharpWorkshopOnePFritz.UserInterface
{
    public class Foo
    {
        public Ford.Fusion myCar;
        public Ford.Fusion MariasCar;

        public Foo()
        {
            MariasCar = new Ford.Fusion();
            MariasCar.Color = "Red";

            var carColor = MariasCar.Color;
        }
    }
}

namespace Ford.Fusion {

    public class Fusion
    {
        public bool StartEngine()
        {
            return true;
        }
    }

}