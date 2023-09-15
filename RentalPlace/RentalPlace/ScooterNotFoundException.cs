using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPlace
{
    public class ScooterNotFoundException : Exception
    {
        public ScooterNotFoundException() :base("There is no ID to remove")
        {
        }
    }
}
