namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected string _livingRegion;

        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight)
        {
            _livingRegion = livingRegion;
        }
    }
}