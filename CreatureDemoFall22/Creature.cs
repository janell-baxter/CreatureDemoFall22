using System;
using System.Collections.Generic;
using System.Text;

namespace CreatureDemoFall22
{
    class Creature
    {
        public string CommonName;
        public double Length;
        private bool Hungry = true;


        public string Eat(Creature creature) 
        {
            Hungry = false;
            return $"{CommonName} ate {creature.CommonName}";
        }
        public void Sleep() { }
       


    }
}
