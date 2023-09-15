

namespace RentalPlace
{
    public class ScooterRentHistory
    {
        public string Id  { get; }
        public DateTime rentStart { get; }
        public DateTime? rentEnd { get;set;}

        public ScooterRentHistory(string id, DateTime StartTime )
        {
            Id = id;
            rentStart = StartTime;
            
        }
    }
}
