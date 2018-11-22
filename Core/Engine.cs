using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Core
{
    public class Engine
    {
        private AnimalCentre animalCentre;

        public Engine()
        {
            this.animalCentre = new AnimalCentre();
        }
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split();
                var command = tokens[0];
                var args = tokens.Skip(1).ToArray();
                var result = string.Empty;
                try
                {
                    switch (command)
                    {
                        case "RegisterAnimal":
                            string type = args[0];
                            string name = args[1];
                            int energy = int.Parse(args[2]);
                            int happiness = int.Parse(args[3]);
                            int procedureTime = int.Parse(args[4]);
                            Console.WriteLine(animalCentre.RegisterAnimal(type, name, energy, happiness, procedureTime));
                            break;
                        case "Chip":
                            string name1 = args[0];
                            int procedureTime1 = int.Parse(args[1]);
                            Console.WriteLine( (animalCentre.Chip(name1, procedureTime1)));
                            break;
                        case "Vaccinate":
                            Console.WriteLine((animalCentre.Vaccinate(args[0], int.Parse(args[1]))));                      
                            break;
                        case "Fitness":
                            Console.WriteLine(animalCentre.Fitness(args[0], int.Parse(args[1])));
                            break;
                        case "Play":
                            Console.WriteLine(animalCentre.Play(args[0], int.Parse(args[1])));
                            break;
                        case "DentalCare":
                            Console.WriteLine(animalCentre.DentalCare(args[0], int.Parse(args[1])));
                            break;
                        case "NailTrim":
                            Console.WriteLine(animalCentre.NailTrim(args[0], int.Parse(args[1])));
                            break;
                        case "Adopt":
                            Console.WriteLine(animalCentre.Adopt(args[0], args[1]));
                            break;
                        case "History":
                            Console.WriteLine(animalCentre.History(args[0]));
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("InvalidOperationException: " + ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("ArgumentException: " + ex.Message);
                }

                input = Console.ReadLine();
            }
            animalCentre.Print();
        }
    }
}
