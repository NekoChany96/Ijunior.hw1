using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit unit1 = new Unit("unite1", 15, 10, Faction.Goodness, 100);
            Unit unit2 = new Unit("unite2", 25, 5, Faction.Evile, 100);
            int countAttack = 10;
            for (int i = 0; i < countAttack; i++)
            {
                unit1.Attack(unit2);
                unit2.Attack(unit1);
                if (!unit1.IsLive || !unit2.IsLive)
                {
                    break;
                }

            }

        }
    }
}
