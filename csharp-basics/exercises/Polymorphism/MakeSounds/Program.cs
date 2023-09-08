using MakeSounds;
using System;
using System.Collections.Generic;

namespace SoundExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sounds = new List<ISound>();
            sounds.Add(new Radio());
            sounds.Add(new Parrot());
            sounds.Add(new Firework());

            foreach (var sound in sounds)
            {
                sound.PlaySound();
            }
        }
    }
}
