using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("Squawk!");
        }
    }
}
