using System;
using System.Collections.Generic;

namespace Escape.Models
{
    public class Bag
    {
        public Bag()
        {
            bag = new List<HealthPotion>();
        }

        public void Add()
        {
            HealthPotion potion = new HealthPotion();
            bag.Add(potion);
        }

        public HealthPotion Use()
        {
            HealthPotion temp = bag[0];
            bag.Remove(temp);
            return temp;
        }

        public void Drop()
        {
            HealthPotion temp = bag[0];
            bag.Remove(temp);
        }

        List<HealthPotion> bag;
    }
}
