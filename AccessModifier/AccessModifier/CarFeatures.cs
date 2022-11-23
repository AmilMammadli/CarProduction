using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class CarFeatures
    {
        public string model { get; set; }
        public string marka { get; set; }
        public int milage { get; set; }
        public double FuelAmount { get; set; }
        public double FuelUsage { get; set; }
        public CarFeatures(string model, string marka, int milage, double FuelAmount, double FuelUsage) : base()
        {
            this.model = model;
            this.marka = marka;
            this.milage = milage;
            this.FuelAmount = FuelAmount;
            this.FuelUsage = FuelUsage;
        }

        public double getFuelAmount()
        {
            return FuelAmount;
        }

        public void getAmountmilage()
        {
            int oneLitrMilage = (int)(100 / FuelUsage);
            int GoToMilage = (int)(FuelAmount * oneLitrMilage);
        }

        public void getAmountService()
        {
            if (milage > 5000)
            {
                int count = milage / 5000;
                Console.WriteLine("car went to service " + count + " times");

            }

            int c = 0;
            bool check = false;

            while (milage > 5000)
            {
                milage = milage - 5000;
                check = true;
            }

            if (check == true)
            {
                int goToServiceMil = 5000 - milage;
                Console.WriteLine("you must go service after " + goToServiceMil + " milage");
            }


            if (check == false)
            {
                c = 5000 - milage;
                Console.WriteLine("you must go service after " + c + " milage");
            }
        }
    }
}
