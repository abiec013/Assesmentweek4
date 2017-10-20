using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmentweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("vin254525".PadRight(15), "Chevrolet".PadRight(15));
            Car car2 = new Car("vin456254".PadRight(15), "Ford".PadRight(15));

            NascarCar ncar1 = new NascarCar("vin425236".PadRight(15), "Lamborguini".PadRight(15), "Kellogs");
            NascarCar ncar2 = new NascarCar("vin456896".PadRight(15), "Ferrari".PadRight(15), "Italia");
            NascarCar ncar3 = new NascarCar("vin236698".PadRight(15), "Maseratti".PadRight(15), "Detroit");


            Car[] listofcars = new Car[5];

            listofcars[0] = car1;
            listofcars[1] = car2;

            listofcars[2] = ncar1;
            listofcars[3] = ncar2;
            listofcars[4] = ncar3;


            for (int i = 0; i < listofcars.Length; i++)
            {
                listofcars[i].PrintInfo();
            }




        }
    }
}
