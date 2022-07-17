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
                unit[1].Attack(unit[0]);
                unit[0].Defence();
                if (unit[1].HealthPoints <= 0 || unit[0].HealthPoints <= 0)
                {
                    Console.WriteLine("Killed");
                    break;
                }
                Console.WriteLine(unit[0].GetType() + " Unit 1 HP");
                Console.WriteLine(Math.Round(unit[0].HealthPoints, 1));
                Console.WriteLine(unit[1].GetType() + " Unit 2 HP");
                Console.WriteLine(Math.Round(unit[1].HealthPoints, 1));

            } while (unit[1].HealthPoints > 0 || unit[0].HealthPoints > 0);
            if (unit[0].HealthPoints < 0)
            {
                Console.WriteLine(unit[1].ToString() + " killed " + unit[0].GetType());
            }
            else
            {
                Console.WriteLine(unit[0].ToString() + " killed " + unit[1].GetType());
            }
            

        }
    }
}