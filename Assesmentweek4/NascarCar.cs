using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmentweek4
{
    class NascarCar:Car
    {
        private string teamname;

        public string TeamName
        {
            set { teamname = value;  }
            get { return teamname;   }

        }

        public NascarCar()
        {
            TeamName = " ";

        }

        public NascarCar(string vvin, string mmake,string tname)
        {
            Vin = vvin;
            Make = mmake;
            TeamName = tname;

        }

        public override void PrintInfo()
        {
            Console.WriteLine(Make + " " + Vin + " " + TeamName);
        }



    }
}
