using System;

namespace DragRace
{
    public class Audi : Car
    {
        public override void SpeedUp() 
        {
            _currentSpeed += 5;
        }

        public override void SlowDown() 
        {
            _currentSpeed -= 5;
        }

        public override void StartEngine() 
        {
            Console.WriteLine("Rrrrrrrr.....");
        }
    }
}