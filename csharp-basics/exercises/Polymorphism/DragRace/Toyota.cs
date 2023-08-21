using System;

namespace DragRace
{
    public class Toyota : Car
    {
        public override void SpeedUp()
        {
            _currentSpeed += 15;
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
