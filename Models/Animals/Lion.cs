using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animals
{
    public class Lion : Animal
    {
        public Lion(string name, int happiness, int energy, int procedureTime) 
            : base(name, happiness, energy, procedureTime)
        {
        }
        public override string ToString()
        {
            return $"    Animal type: {this.GetType().Name} - {Name} - Happiness: {Happiness} - Energy: {Energy}";

        }
    }
}
