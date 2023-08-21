using System;

namespace DragRace
{
    public class Lada : Car, IBooster
    {
        public override void SpeedUp()
        {
            _currentSpeed += 12;
        }

        public override void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Rrrrrrrr.....");
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 20;
        }
    }
}
