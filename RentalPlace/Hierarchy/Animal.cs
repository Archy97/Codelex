namespace Hierarchy
{
    public abstract class Animal
    {
        protected string _animalName;
        protected string _animalType;
        protected double _animalWeight;
        protected int foodEaten;

        public Animal(string animalType, string animalName, double animalWeight)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}