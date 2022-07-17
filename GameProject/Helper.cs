using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Helper
    {
        public static int RandomUnit()
        {
            Random random = new Random();
            int randomUnit = random.Next(1, 3);
            return randomUnit;
        }

        public static Unit CreateRandomUnit()
        {
            Unit random;

            if (RandomUnit() == 1)
            {
                random = new Archer();
            }
            else
            {
                random = new Warrior();
            }

            return random;
        }

        public static int EnemyUnitForGroup1(int lenght)
        {
            Random random2 = new Random();
            int randomEnemyGroup2 = random2.Next(lenght);
            return randomEnemyGroup2;
        }

        public static int EnemyUnitForGroup2(int lenght)
        {
            Random random2 = new Random();
            int randomEnemyGroup1 = random2.Next(lenght);
            return randomEnemyGroup1;
        }

        public static bool IsAlive(int lenght)
        {
            bool Alive;

            if (lenght > 0)
            {
                 Alive = true;
            }
            else
            {
                 Alive = false;
            }

            return Alive;
        }
    }
}
