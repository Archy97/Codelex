using AdApp;
using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> _campaign;

        public Campaign() 
        {
            _campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            _campaign.Add(a);
        }

        public int GetCost()
        {
            return _campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            return $"Advert Campaign\n{string.Join("\n", _campaign)}\n\nTotal Cost:{GetCost()}";
        }
    }
}
