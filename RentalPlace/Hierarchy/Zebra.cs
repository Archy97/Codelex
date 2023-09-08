namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zebra sound!");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                foodEaten += food._quantity;
            }
            else
            {
                throw new WrongFoodException(_animalType);
            }
        }
        public override string ToString()
        {
            return $"{_animalType}[{_animalName}, {Math.Round(_animalWeight, 2)}, {_livingRegion}, {foodEaten}]";
        }
    }
}