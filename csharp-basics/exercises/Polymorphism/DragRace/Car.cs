using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public abstract class Car
    {

        protected int  _currentSpeed = 0;


        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }


        public abstract void SpeedUp();


        public abstract void SlowDown();



        public abstract void StartEngine();
    }
}
