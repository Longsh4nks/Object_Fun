using System;
using Escape.Models;

namespace Escape
{
    class Program
    {
        static void Main(string[] args)
        {
            Character cory = new Character();
            Bag bag = new Bag();
            bag.Add();
            bag.Add();
            cory.TakeDamage(20);
            cory.Heal(bag.Use());
            Console.WriteLine(cory.hp);

        }
    }
}
