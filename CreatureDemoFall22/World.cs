using System;
using System.Collections.Generic;
using System.Text;
using static CreatureDemoFall22.Utility;


namespace CreatureDemoFall22
{
    class World
    {
        public string Name = "GatorLand";
        public List<Creature> Creatures = new List<Creature>() 
        { 
        new Fish(),
        new Reptile(),
        new Amphibian()
        };

        public void Start()
        {

            foreach(Creature c in Creatures)
            {
                Print(c.Eat(new Creature()));
            }
        }


    }
}
