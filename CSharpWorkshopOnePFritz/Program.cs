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
            var mariasRealCar = new Tesla.ModelS
        }
    }
}


namespace CSharpWorkshopOnePFritz.UserInterface
{
    public class Foo
    {
        public Ford.Fusion myCar;
        public Ford.Fusion MariasCars;
    }
}

namespace Ford {

    public class Fusion
    {
        public bool StartEngine()
        {
            return true;
        }
    }

}