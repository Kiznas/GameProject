using System;

namespace Game
{
    class Startup
    {
        static void Main(string[] args)
        {
            Unit[] unit = new Unit[2];
            unit[0] = Helper.CreateRandomUnit();
            unit[1] = Helper.CreateRandomUnit();
            do
            {
                unit[0].Attack(unit[1]);
                unit[1].Defence();
                if (unit[1].HealthPoints <= 0)
                {
                    Console.WriteLine("Killed");
                    break;
                }
                Console.WriteLine(Math.Round(unit[1].HealthPoints, 1));

            } while (unit[1].HealthPoints > 0);

            Console.WriteLine(unit[0].ToString() + " killed " + unit[1].GetType());

        }
    }
}