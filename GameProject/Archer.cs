using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Archer : Unit
    {
        public Archer() : base(120, 35, 1.2)
        {
        }

        public bool Dodge()
        {
            Random rd = new Random();
            int dodge = rd.Next(0, 100);
            return dodge <= 70;
        }

        public bool Crit()
        {
            Random rd = new Random();
            int crit = rd.Next(0, 100);
            return crit <= 33;
        }

        public override double Defence()
        {
            double attack;

            if (Dodge())
            {
                attack = 0;
            }
            else
            {
                attack = DamageTaken;
            }

            HealthPoints -= attack;
            return attack;
        }

        public override double Attack(Unit unit)
        {
            if (Crit())
            {
                unit.DamageTaken = base.Attack(unit) * 2;
            }
            else
            {
                unit.DamageTaken = base.Attack(unit);
            }

            return unit.DamageTaken;
        }
    }
}
