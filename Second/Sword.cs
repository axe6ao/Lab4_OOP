namespace Second
{
    public class Sword : Weapon
    {
        public override int CalculateDamage()
        {
            return ThrustAttack();
        }

        public override void Repair()
        {
            condition += 50;
        }


        public int ThrustAttack()
        {
            return damage + 20;
        }
    }
}