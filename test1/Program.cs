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
            Unite unite1 = new Unite("unite1", 15, 10, Faction.Goodness, 100);
            Unite unite2 = new Unite("unite2", 25, 5, Faction.Evile, 100);
            for (int i = 0; i < 10; i++)
            {
                unite1.Attak(unite2);
                unite2.Attak(unite1);
                if (!unite1.IsLive() || !unite2.IsLive())
                {
                    break;
                }

            }

        }
    }
}
