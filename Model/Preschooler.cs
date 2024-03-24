using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Kindergarden.Model
{
    public abstract class Preschooler
    {
        public string Name { get;}
        public int InitialSatisfaction { get;}
        public int Satisfaction { get; set; }
        public Preschooler(string name, int initialSatisfaction)
        {
            Name = name;
            InitialSatisfaction = Math.Clamp(initialSatisfaction, 1, 4);
            Satisfaction = initialSatisfaction;
        }
        public void ChangeSatisfaction(int amount)
        {
            Satisfaction = Math.Clamp(Satisfaction + amount, 1, 4);
        }

        public void Cry()
        {
            if (Satisfaction == 0)
            {
                Console.WriteLine($"{Name} is crying!");
            }
        }
       
    }
}
