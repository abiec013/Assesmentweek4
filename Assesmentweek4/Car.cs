using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmentweek4
{
    class Car
    {
        private string vin;
        private string make;



        public string Vin
        {
            set { vin = value; }
            get { return vin;  }


        }
        public string Make
        {
            set { make = value; }
            get { return make; }

        }


        public Car ()
        {
            Vin = " ";
            Make = " ";

        }

        public Car(string vvin, string mmake)
        {
            Vin = vvin;
            Make = mmake;


        }

        public virtual void PrintInfo()
        {

            Console.WriteLine(Make + " " + Vin);

        }
            


        


        
    }
}
