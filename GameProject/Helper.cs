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
    }
}
