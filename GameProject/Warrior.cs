using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Warrior : Unit
    {
        public Warrior() : base(200, 20, 0.5)
        {
            
        }

        public override double Attack(Unit unit)
        {
            return base.Attack(unit);
        }

        public override double Defence()
        {
            DamageTaken = DamageTaken * 0.7;
            HealthPoints -= DamageTaken;
            return DamageTaken;
        }

    }
}
