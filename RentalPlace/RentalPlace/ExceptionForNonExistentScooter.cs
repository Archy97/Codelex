using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPlace
{
    public class ExceptionForNonExistentScooter: Exception
    {
        public ExceptionForNonExistentScooter() : base("There is no scooter like that") { }
    }
}
