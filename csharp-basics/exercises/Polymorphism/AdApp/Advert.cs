namespace AdApp
{
    public class Advert
    {
        private int _fee;

        public Advert() 
        {
            _fee = 0;
        }

        public Advert(int fee) 
        {
            _fee = fee;
        }

        public int getFee()
        {
            return _fee;
        }

        public void SetFee(int fee) 
        {
            _fee = fee;
        }

        public virtual int Cost() 
        {
            return _fee;
        }

        public override string ToString() 
        {
            
            string className = GetType().Name;

            return $"\nAdvert: {className} = Fee " + _fee;
        }
    }
}
