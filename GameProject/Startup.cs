using System;
using System.Linq;

namespace Game
{
    class Startup
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(OneVSOne());
            Console.WriteLine(ThreeVsThree());
            Console.WriteLine(BattleRoyale());
        }
        static string OneVSOne()
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
                    break;
                }
                Console.WriteLine(unit[0].GetType() + " Unit 1 HP");
                Console.WriteLine(Math.Round(unit[0].HealthPoints, 1));
                Console.WriteLine(unit[1].GetType() + " Unit 2 HP");
                Console.WriteLine(Math.Round(unit[1].HealthPoints, 1));

            } while (unit[1].HealthPoints > 0 || unit[0].HealthPoints > 0);

            string winner;

            if (unit[0].HealthPoints < 0)
            {
                winner = $"{unit[1]} winner";
            }
            else
            {
                winner = $"{unit[0]} winner";
            }

            return winner;
            
        }

        static string ThreeVsThree()
        {
            int numberOfIdiots = 6;
            Unit[] unit = new Unit[numberOfIdiots];

            for (int i = 0; i < numberOfIdiots; i++)
            {
                unit[i] = Helper.CreateRandomUnit();
            }

            do
            {
                for (int i = 0; i < unit.Length; i++)
                {
                    if (unit[i].HealthPoints > 0)
                    {
                        Console.WriteLine($" {unit[i].GetType()} Unit {i} HP");
                        Console.WriteLine(Math.Round(unit[i].HealthPoints, 1));
                    }
                    else
                    {
                        //unit = unit.Where(e => e != unit[i]).ToArray();
                    }

                }

                for (int i = 0; i < (unit.Length / 2); i++)
                {
                    int enemy = Helper.EnemyUnitForGroup1(unit.Length);
                    unit[i].Attack(unit[enemy]);
                    unit[enemy].Defence();
                }

                for (int i = (unit.Length / 2); i < unit.Length; i++)
                {
                    int enemy = Helper.EnemyUnitForGroup2(unit.Length);
                    unit[i].Attack(unit[enemy]);
                    unit[enemy].Defence();
                }

                Console.WriteLine("_______________");

            } while ((unit[0].HealthPoints > 0 || unit[1].HealthPoints > 0 || unit[2].HealthPoints > 0) &&
                    (unit[3].HealthPoints > 0 || unit[4].HealthPoints > 0 || unit[5].HealthPoints > 0));

            string winner;

            if ((unit[0].HealthPoints > 0 || unit[1].HealthPoints > 0 || unit[2].HealthPoints > 0))
            {
                winner = "Team 1 Win";
            }
            else
            {
                winner = "Team 2 Win";
            }

            return winner;
        }

        static string BattleRoyale()
        {
            int winner;
            int numberOfIdiots = 100;
            Unit[] unit = new Unit[numberOfIdiots];

            for (int i = 0; i < numberOfIdiots; i++)
            {
                unit[i] = Helper.CreateRandomUnit();
            }

            do
            {
                for (int i = 0; i < unit.Length; i++)
                {
                    if (unit[i].HealthPoints > 0)
                    {
                        Console.WriteLine($" {unit[i].GetType()} Unit {i} HP");
                        Console.WriteLine(Math.Round(unit[i].HealthPoints, 1));
                    }
                    else
                    {
                        unit = unit.Where(e => e != unit[i]).ToArray();
                    }

                }

                for (int i = 0; i < (unit.Length); i++)
                {
                    int enemy = Helper.EnemyUnitForGroup1(unit.Length);
                    if (enemy != i)
                    {
                        unit[i].Attack(unit[enemy]);
                        unit[enemy].Defence();
                    }
                    else
                    {
                        winner = i;
                    }
                }

                Console.WriteLine("_______________");

            } while (unit.Length > 1);

            return $"Unit {unit[0]} Winned";
        }
    }
}