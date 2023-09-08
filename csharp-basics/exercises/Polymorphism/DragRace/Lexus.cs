using System;

namespace DragRace
{
    public class Lexus : Car, IBooster
    {
        public override void SpeedUp()
        {
            _currentSpeed += 9;
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
            _currentSpeed += 15;
        }
    }
}
