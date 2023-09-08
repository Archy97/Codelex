namespace Hierarchy
{
    public class WrongFoodException : Exception
    {
        private object AnimalType;

        public WrongFoodException(object animalType) : base($"The {animalType} cannot eat this food.")
        {
            AnimalType = animalType;
        }
    }
}