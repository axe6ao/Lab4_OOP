﻿using System;

namespace Second
{
    public class Bow : Weapon
    {
        protected int chanceToHit = 50;
        Random random = new Random();

        public override int CalculateDamage()
        {
            if (IsHit())
            {
                return ProjectileAttack();
            }

            return 0;
        }

        public int ProjectileAttack()
        {
            return damage + 20;
        }

        public bool IsHit()
        {
            return random.Next(0, 101) <= chanceToHit ? true : false;
        }
    }
}