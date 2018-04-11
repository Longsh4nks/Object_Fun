using System;
namespace Escape.Models
{
    public class Character
    {
        public Character()
        {
            hp = max_hp;
        }

        public void TakeDamage(int val)
        {
            hp = hp - val;
        }

        public void Heal(HealthPotion potion)
        {
            hp = hp + potion.heal;
        }

        public int max_hp = 100;
        public int hp;

    }
}
