﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Felime : Mammal
    {
        public Felime(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight , livingRegion)
        {
        }
    }
}
