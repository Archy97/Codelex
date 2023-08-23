using System;

namespace Hierarchy
{
    public abstract class Food
    {
        public int _quantity { get; private set; }

        public Food(int quantity)
        {
            _quantity = quantity;
        }
    }
}
