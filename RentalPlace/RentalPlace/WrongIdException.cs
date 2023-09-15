using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPlace
{
    public class WrongIdException : Exception
    {
        public WrongIdException() : base ("The id is wrong")
        {
        }
    }
}
