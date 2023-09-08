using System;

namespace DragRace
{
    public class Tesla : Car
    {
        public override void SpeedUp()
        {
            _currentSpeed += 10;
        }

        public override void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Silence");
        }
    }
}