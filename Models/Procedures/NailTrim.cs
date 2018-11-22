using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class NailTrim : Procedure
    {
        public NailTrim()
        {

        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);
            Animal currentAnimal = ((Animal)animal);
            animal.Happiness -= 7;
            animal.ProcedureTime -= procedureTime;

            if (!procedureHistory.ContainsKey(this))
            {
                procedureHistory.Add(this, new List<IAnimal>());
            }
            procedureHistory[this].Add(animal);
        }
    }
}
