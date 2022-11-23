using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class Ferrari : CarFeatures
    {
        public Ferrari(string model, string marka, int milage, double FuelAmount, double FuelUsage) : base(model, marka, milage, FuelAmount, FuelUsage)
        {

        }
    }
}
