using System;

namespace Game
{
    public abstract class Unit
    {
        private double _hp;
        private double _ad;
        private double _attackCoef;
        private double _damageTaken;

        public double AttackCoef
        {
            get
            {
                return _attackCoef;
            }
            set
            {
                _attackCoef = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
            }
        }

        public double AttackDamage
        {
            get
            {
                return _ad;
            }
        }

        public double DamageTaken
        {
            get
            {
                return _damageTaken;
            }
            set
            {
                _damageTaken = value;
            }
        }

        public Unit(double healthPoints, double attackDamage)
        {

            if (healthPoints > 0)
            {
                _hp = healthPoints;
            }
            else
            {
                throw new ArgumentException("Died");
            }

            if (attackDamage > 0)
            {
                _ad = attackDamage;
            }
            else
            {
                throw new ArgumentException("Too low attack damage");
            }
        }

        public virtual double Attack(Unit unit)
        {
            unit.DamageTaken = AttackDamage * AttackCoef;
            return unit.DamageTaken;
        }

        public abstract double Defence();
    }
}
