using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AnimalCentre.Models
{
    public class Hotel : IHotel
    {
        private int capacity;
        private Dictionary<string, IAnimal> animals;

        public Hotel()
        {
            this.capacity=10;
            this.animals = new Dictionary<string, IAnimal>();
        }

        public void Accommodate(IAnimal animal)
        {
            var currenrAnimal = ((Animal)animal);
            if (animals.Count >= this.capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }
            if (animals.ContainsKey(currenrAnimal.Name))
            {
                throw new ArgumentException($"Animal {currenrAnimal.Name} already exist");
            }
            this.animals.Add(currenrAnimal.Name, currenrAnimal);
        }

        public void Adopt(string animalName, string owner)
        {
            if (!animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }
            IAnimal currentAnimal = animals.FirstOrDefault(a => a.Key == animalName).Value;
            currentAnimal.Owner = owner;
            currentAnimal.IsAdopt = true;
            this.animals.Remove(animalName);
        }

        public IReadOnlyDictionary<string, IAnimal> Animals
        {
            get => new ReadOnlyDictionary<string, IAnimal>(this.animals);
        }



    }
}
