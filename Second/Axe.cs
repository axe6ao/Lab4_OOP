using System;

namespace Second
{
    public class Axe : Weapon
    {
        public override int CalculateDamage()
        {
            return SwingAttack() + 10;
        }

        public int SwingAttack()
        {
            return damage + 20;
        }
    }
}