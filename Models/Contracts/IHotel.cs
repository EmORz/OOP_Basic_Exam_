﻿namespace AnimalCentre.Models.Contracts
{
    using AnimalCentre.Models.Animals;
    using System.Collections.Generic;

    public interface IHotel
    {
        IReadOnlyDictionary<string, IAnimal> Animals { get; }
        void Accommodate(IAnimal animal);
        void Adopt(string animalName, string owner);
    }
}
